using LibGit2Sharp;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CommitAnalysis
{
    internal class Helper
    {
        public static Font hashFont = new Font("Consolas", (float)9.75);

        public static string GenerateJIRAFilter(Dictionary<string, List<string>> ticketsList)
        {
            string JIRAFilter = string.Empty;
            foreach (var ticket in ticketsList)
            {
                JIRAFilter += " or key=\"" + ticket.Key + "\"";
            }
            if (JIRAFilter != string.Empty)
            {
                return JIRAFilter.Remove(0, 4);
            }
            return JIRAFilter;
        }

        public static List<string> FetchBranches(string repositoryPath)
        {
            List<string> branchesList = new List<string>();
            if (repositoryPath.Trim() == "") { return branchesList; }

            var currentRepository = new Repository(repositoryPath);

            foreach (var branch in currentRepository.Branches)
            {
                string branchType = "Local : ";
                if (branch.IsRemote)
                {
                    branchType = "Remote : ";
                }
                branchesList.Add(branchType + branch.FriendlyName);
            }

            branchesList.Sort();

            return branchesList;
        }

        public static List<T> FetchTagsInBranch<T>(Repository repo, string branchName)
        {
            List<T> tagsList = new List<T>();
            foreach (var tag in repo.Tags)
            {
                Commit commit = repo.Lookup<Commit>(tag.Target.Sha);
                if (IsCommitInBranch(commit, branchName, repo))
                {
                    if (typeof(T) == typeof(string))
                    {
                        tagsList.Add((T)(object)tag.FriendlyName);
                    }
                    else if (typeof(T) == typeof(Tag))
                    {
                        tagsList.Add((T)(object)tag);
                    }
                }
            }
            if (typeof(T) == typeof(string))
            {
                tagsList.Sort();
            }
            return tagsList;
        }


        public static string GetBranchName(string rawBranchName)
        {
            string[] branchName = rawBranchName.Split(":", StringSplitOptions.TrimEntries);
            if (branchName.Length == 1)
            {
                return rawBranchName;
            }
            return branchName[1];
        }

        public static bool IsCommitInBranch(Commit commit, string branchName, Repository repo)
        {
            LibGit2Sharp.Branch branch = repo.Branches[branchName];
            return branch.Commits.Contains(commit);
        }

        public static bool CommitContainsFile(Commit commit, string filePath, string fileId)
        {
            TreeEntry entry = commit[filePath];

            if (entry == null) { return false; }
            if (entry.Target.Id.ToString() != fileId) { return false; }
            return true;

        }

        public static Commit GetCommitFileChanged(string filePath, string fileId, string branchName, Repository repo)
        {
            LibGit2Sharp.Branch branch = repo.Branches[branchName];
            return GetCommitFileChanged(filePath, fileId, branch);
        }

        public static Commit GetCommitFileChanged(string filePath, string fileId, LibGit2Sharp.Branch branch)
        {
            List<Commit> commitsList = branch.Commits
                                            .OrderBy(c => c.Committer.When)
                                            .ToList();
            return GetCommitFileChanged(filePath, fileId, commitsList);
        }

        public static Commit GetCommitFileChanged(string filePath, string fileId, List<Commit> commits)
        {
            Commit foundCommit = null;

            foreach (Commit commit in commits)
            {
                if (CommitContainsFile(commit, filePath, fileId))
                {
                    foundCommit = commit;
                    break;
                }
            }

            return foundCommit;
        }

        public static Commit GetCommitById(string id, Repository repo)
        {
            if (repo == null || id == String.Empty) { return null; }
            return repo.Lookup<Commit>(id);
        }

        public static List<Tag> GetCommitsTags(string commitId, Repository repo)
        {
            List<Tag> tags = new List<Tag>();
            if (repo == null || commitId == null) { return tags; }
            tags = repo.Tags.Where(tag => tag.Target.Id.ToString() == commitId).ToList();
            return tags;
        }

        public static string ExtractJIRATicket(string commitMessage)
        {
            string pattern = Properties.Settings.Default.JIRATicketRegex;
            MatchCollection ticketMatches = Regex.Matches(commitMessage, pattern);
            if (ticketMatches.Count > 0)
            {
                return ticketMatches[0].Value;
            }

            return commitMessage.Trim().Split(' ')[0].Replace(":", "").Trim();
        }

        public static string ExtractJIRATicket(Commit commit)
        {
            string pattern = Properties.Settings.Default.JIRATicketRegex;

            MatchCollection ticketMatches = Regex.Matches(commit.MessageShort, pattern);
            if (ticketMatches.Count > 0)
            {
                return ticketMatches[0].Value;
            }

            string commitMessage = commit.Message.Remove(0, commit.MessageShort.Length).Trim();

            ticketMatches = Regex.Matches(commitMessage, pattern);
            if (ticketMatches.Count > 0)
            {
                return ticketMatches[0].Value;
            }

            return commit.MessageShort.Trim().Split(' ')[0].Replace(":", "").Trim();
        }

        public static string ExtractPullRequest(string commitMessage)
        {
            string pattern = Properties.Settings.Default.PRRegex;
            MatchCollection PRMatches = Regex.Matches(commitMessage, pattern);

            if (PRMatches.Count > 0) { return PRMatches[0].Value; }

            return String.Empty;

        }

        public static List<string> ExtractAuthorAndEmail(string authorString)
        {
            List<string> result = new List<string> { authorString, "" };

            int indexStartEmail = authorString.IndexOf("<");
            int indexEndEmail = authorString.IndexOf(">");

            if (indexStartEmail == -1) { return result; }
            if (indexEndEmail == -1) { return result; }

            result[0] = authorString.Substring(0, indexStartEmail);
            result[1] = authorString.Substring(indexStartEmail + 1, indexEndEmail - indexStartEmail - 1);

            return result;

        }

        public static List<FileDifference> ExtractFileDifferences(string patchContent)
        {
            List<FileDifference> fileDifferences = new List<FileDifference>();
            
            if (patchContent == null) { return fileDifferences; }

            StringReader patchContentReader = new StringReader(patchContent);
            FileDifference currentDifference = null;
            string line = null;

            while ((line = patchContentReader.ReadLine()) != null)
            {
                if (line.StartsWith("@@"))
                {
                    if (currentDifference != null)
                    {
                        fileDifferences.Add(currentDifference);
                    }
                    currentDifference = new FileDifference();
                    string[] tokens = line.Split(' ');
                    currentDifference.ReferenceFileStartLine = Convert.ToInt32(tokens[1].Substring(1).Split(',')[0]);
                    currentDifference.ComparedFileStartLine = Convert.ToInt32(tokens[2].Substring(1).Split(',')[0]);
                } else if (line.StartsWith("+") && currentDifference != null)
                {
                    currentDifference.ComparedFileLines.Add(line);
                } else if (line.StartsWith("-") && currentDifference != null)
                {
                    currentDifference.ReferenceFileLines.Add(line);
                } else if (currentDifference != null)
                {
                    currentDifference.ReferenceFileLines.Add(line);
                    currentDifference.ComparedFileLines.Add(line);
                }
            }

            if (currentDifference != null)
            {
                fileDifferences.Add(currentDifference);
            }

            return fileDifferences;
        }

        public static List<string> ParseFilterFile(string filterFilePath)
        {
            List<string> filesList = new List<string>();
            if (filterFilePath == "" || filterFilePath == string.Empty) { return filesList; }
            if (!File.Exists(filterFilePath)) { return filesList; }

            FileStream filterFileStream = File.OpenRead(filterFilePath);
            StreamReader filterFileStreamReader = new StreamReader(filterFileStream);
            string line = string.Empty;
            while ((line = filterFileStreamReader.ReadLine()) != null)
            {
                if (!filesList.Contains(line))
                {
                    filesList.Add(line);
                }
            }
            return filesList;
        }

        public static void SizeDgvColumnsManually(DataGridView dataGridView, int padding = 10)
        {
            Graphics graph = Graphics.FromHwnd(dataGridView.Handle);

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                Font headerFont = column.HeaderCell.Style.Font;
                if (headerFont == null)
                {
                    headerFont = dataGridView.DefaultCellStyle.Font;
                }
                SizeF maxWidth = graph.MeasureString(column.HeaderText.ToString(), headerFont); // TextRenderer.MeasureText(column.HeaderText.ToString(),column.HeaderCell.Style.Font).Width;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[column.Index].Value != null)
                    {
                        Font cellFont = row.Cells[column.Index].Style.Font;
                        if (cellFont == null)
                        {
                            cellFont = column.DefaultCellStyle.Font;
                            if (cellFont == null)
                            {
                                cellFont = dataGridView.DefaultCellStyle.Font;
                            }
                        }
                        SizeF cellWidth = graph.MeasureString(row.Cells[column.Index].Value.ToString(), cellFont);// TextRenderer.MeasureText(row.Cells[column.Index].Value.ToString(), row.Cells[column.Index].Style.Font).Width;

                        if (cellWidth.Width > maxWidth.Width)
                        {
                            maxWidth = cellWidth;
                        }
                    }
                }

                column.Width = Math.Max((int)maxWidth.Width + padding, column.MinimumWidth);
            }
        }

        public static void AddDataTableColumn(DataTable targetDataTable, string columnName)
        {
            DataColumn newDataColumn = new DataColumn();
            newDataColumn.ColumnName = columnName;
            targetDataTable.Columns.Add(newDataColumn);
        }

        public static void ChangeColumnToLinkColumn(DataGridView targetDataGridView, string columnName, string urlColumnName)
        {
            if (!targetDataGridView.Columns.Contains(columnName)) { return; }

            DataGridViewColumn originalColumn = targetDataGridView.Columns[columnName];

            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.Name = originalColumn.Name;
            linkColumn.HeaderText = originalColumn.HeaderText;
            linkColumn.DataPropertyName = originalColumn.DataPropertyName;

            linkColumn.UseColumnTextForLinkValue = false;
            linkColumn.TrackVisitedState = true;
            linkColumn.LinkBehavior = LinkBehavior.HoverUnderline;
            linkColumn.LinkColor = System.Drawing.Color.Blue;
            linkColumn.VisitedLinkColor = System.Drawing.Color.Purple;
            linkColumn.Tag = urlColumnName;

            int columnIndex = originalColumn.DisplayIndex;

            targetDataGridView.Columns.Remove(originalColumn);

            targetDataGridView.Columns.Insert(columnIndex, linkColumn);
        }

        public static int GetDgvFirstSelectedRowIndex(DataGridView targetDataGridView)
        {
            if (targetDataGridView == null) { return -1; }
            if (targetDataGridView.Rows.Count == 0) { return -1; }
            if (targetDataGridView.SelectedCells.Count == 0) { return -1; }
            int rowIndex = targetDataGridView.RowCount - 1;
            foreach (DataGridViewCell cell in targetDataGridView.SelectedCells)
            {
                if (rowIndex > cell.RowIndex)
                {
                    rowIndex = cell.RowIndex;
                }
            }
            return rowIndex;
        }

        public static DialogResult OpenFilterFile(OpenFileDialog openFileDialog)
        {
            if (openFileDialog == null) { return DialogResult.Cancel; }
            openFileDialog.Title = "Choose a file containing a list of files ...";
            openFileDialog.FileName = "";
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            return openFileDialog.ShowDialog();
        }

        public static void ExecuteUrl(string url)
        {
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
