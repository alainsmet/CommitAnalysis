using LibGit2Sharp;
using System.Data;

namespace CommitAnalysis
{
    public partial class BranchHistory : Form
    {
        public Repository currentRepository;
        private string FormBaseTitle = "Branch history";
        private bool webViewInitialised = false;
        private DataTable commitsDataTable;
        private DataTable filesList;
        private List<string> filesListFilter = new List<string>();

        public BranchHistory()
        {
            InitializeComponent();
            InitBranchHistoryWindow();
            currentRepository = new Repository();
        }

        public void ClearComboBox()
        {
            cbBranchesList.Items.Clear();
        }

        public void PopulateComboBox(List<string> list, string selectedBranch)
        {
            cbBranchesList.DataSource = list;
            if (selectedBranch == "")
            {
                cbBranchesList.SelectedIndex = -1;
            }
            else
            {
                cbBranchesList.SelectedItem = selectedBranch;
            }
        }

        public void SelectCommit(string commitId)
        {
            if (commitId == "") { return; }

            foreach (DataGridViewRow row in dgvBranchHistory.Rows)
            {
                if (row.Cells["commitId"].Value.ToString() == commitId)
                {
                    row.Selected = true;
                    dgvBranchHistory.CurrentCell = row.Cells["commitId"];
                    break;
                }
            }
        }

        public void SetRepositoryPath(string path)
        {
            lbRepositoryPath.Text = path;
        }

        private void PrepareCommitsDataTable()
        {
            commitsDataTable = new DataTable();
            Helper.AddDataTableColumn(commitsDataTable, "commitId");
            Helper.AddDataTableColumn(commitsDataTable, "commitTag");
            Helper.AddDataTableColumn(commitsDataTable, "commitDate");
            Helper.AddDataTableColumn(commitsDataTable, "commitAuthor");
            Helper.AddDataTableColumn(commitsDataTable, "commitAuthorLink");
            Helper.AddDataTableColumn(commitsDataTable, "commitParentCount");
            Helper.AddDataTableColumn(commitsDataTable, "JIRATicket");
            Helper.AddDataTableColumn(commitsDataTable, "JIRATicketLink");
            Helper.AddDataTableColumn(commitsDataTable, "PRNumber");
            Helper.AddDataTableColumn(commitsDataTable, "PRNumberLink");
            Helper.AddDataTableColumn(commitsDataTable, "commitMessage");
            dgvBranchHistory.DataSource = commitsDataTable;
        }

        private void PrepareFilesListDataTable()
        {
            filesList = new DataTable();
            Helper.AddDataTableColumn(filesList, "fileName");
            Helper.AddDataTableColumn(filesList, "status");
            Helper.AddDataTableColumn(filesList, "fileHash");
            Helper.AddDataTableColumn(filesList, "fileModifyDate");
            Helper.AddDataTableColumn(filesList, "fileAuthor");
            Helper.AddDataTableColumn(filesList, "fileCommitHash");
            Helper.AddDataTableColumn(filesList, "fileCommitMessage");
            dgvFilesHashList.DataSource = filesList;
        }

        private void ResetDgvColumnsProperties()
        {
            dgvBranchHistory.Columns["commitId"].HeaderText = "Commit ID";
            dgvBranchHistory.Columns["commitId"].DefaultCellStyle.Font = Helper.hashFont;
            dgvBranchHistory.Columns["commitTag"].HeaderText = "Tag";
            dgvBranchHistory.Columns["commitDate"].HeaderText = "Date";
            dgvBranchHistory.Columns["commitAuthor"].HeaderText = "Author";
            dgvBranchHistory.Columns["commitAuthorLink"].Visible = false;
            dgvBranchHistory.Columns["commitParentCount"].Visible = false;
            dgvBranchHistory.Columns["JIRATicket"].HeaderText = "JIRA Ticket";
            dgvBranchHistory.Columns["JIRATicketLink"].Visible = false;
            dgvBranchHistory.Columns["PRNumber"].HeaderText = "Pull Request";
            dgvBranchHistory.Columns["PRNumberLink"].Visible = false;
            dgvBranchHistory.Columns["commitMessage"].HeaderText = "Message";
            Helper.ChangeColumnToLinkColumn(dgvBranchHistory, "commitAuthor", "commitAuthorLink");
            Helper.ChangeColumnToLinkColumn(dgvBranchHistory, "JIRATicket", "JIRATicketLink");
            Helper.ChangeColumnToLinkColumn(dgvBranchHistory, "PRNumber", "PRNumberLink");

            dgvFilesHashList.Columns["fileName"].HeaderText = "File";
            dgvFilesHashList.Columns["fileName"].MinimumWidth = 100;
            dgvFilesHashList.Columns["status"].HeaderText = "Status";
            dgvFilesHashList.Columns["fileHash"].HeaderText = "File hash";
            dgvFilesHashList.Columns["fileHash"].DefaultCellStyle.Font = Helper.hashFont;
            dgvFilesHashList.Columns["fileAuthor"].HeaderText = "Author";
            dgvFilesHashList.Columns["fileModifyDate"].HeaderText = "Date";
            dgvFilesHashList.Columns["fileCommitHash"].HeaderText = "Commit hash";
            dgvFilesHashList.Columns["fileCommitHash"].DefaultCellStyle.Font = Helper.hashFont;
            dgvFilesHashList.Columns["fileCommitMessage"].HeaderText = "Message";
        }

        public void PopulateBranchHistory()
        {
            if (cbBranchesList.Text == "" || cbBranchesList.Text == string.Empty) { return; }
            dgvBranchHistory.SuspendLayout();
            LibGit2Sharp.Branch selectedBranch = currentRepository.Branches[Helper.GetBranchName(cbBranchesList.Text)];
            List<Tag> tagsList = Helper.FetchTagsInBranch<Tag>(currentRepository, selectedBranch.FriendlyName);

            commitsDataTable.Clear();

            foreach (var commit in selectedBranch.Commits)
            {
                DataRow newDataRow = commitsDataTable.NewRow();
                newDataRow["commitId"] = commit.Id;

                string tagString = string.Empty;

                foreach (Tag tag in tagsList)
                {
                    if (tag.Target.Sha == commit.Sha)
                    {
                        tagString = tagString + tag.FriendlyName + " ";
                    }
                }

                tagString = tagString.Trim();
                newDataRow["commitTag"] = tagString;
                newDataRow["commitMessage"] = commit.MessageShort;
                newDataRow["commitDate"] = commit.Committer.When.LocalDateTime.ToString();

                List<string> author = Helper.ExtractAuthorAndEmail(commit.Author.ToString());

                newDataRow["commitAuthor"] = author[0];
                newDataRow["commitAuthorLink"] = "mailto:" + author[1];
                newDataRow["PRNumber"] = Helper.ExtractPullRequest(commit.MessageShort);

                if (newDataRow["PRNumber"].ToString() != "")
                {
                    newDataRow["PRNumberLink"] = Properties.Settings.Default.GitHubBaseAddress.ToString() + newDataRow["PRNumber"].ToString().Replace("#", "");
                }

                newDataRow["commitParentCount"] = commit.Parents.Count();

                if (commit.Parents.Count() < 2)
                {
                    newDataRow["JIRATicket"] = Helper.ExtractJIRATicket(commit);
                    newDataRow["JIRATicketLink"] = Properties.Settings.Default.JIRABaseAddress.ToString() + Helper.ExtractJIRATicket(commit);
                }
                commitsDataTable.Rows.Add(newDataRow);

            }
            Helper.SizeDgvColumnsManually(dgvBranchHistory);
            dgvBranchHistory.ResumeLayout();
        }

        public void InitBranchHistoryWindow()
        {
            PrepareCommitsDataTable();
            PrepareFilesListDataTable();
            ResetDgvColumnsProperties();
            ClearFileTree();
            InitializeHtml();
        }

        private void ClearCommitInfo()
        {
            if (webViewInitialised == false) { return; }
            string htmlContent = @"
            <!DOCTYPE html>
            <html>
            <head>
                <title>Commit info</title>
            </head>
            <body>
            </body>
            </html>";
            wvCommitInfo.NavigateToString(htmlContent);
        }

        private async Task DisplayCommitInfo(int dgvRowIndex)
        {
            if (webViewInitialised == false) { return; }
            ClearCommitInfo();
            if (dgvRowIndex < 0 || dgvRowIndex > dgvBranchHistory.Rows.Count - 1) { return; }
            string selectedCommitHash = dgvBranchHistory.Rows[dgvRowIndex].Cells["commitId"].Value.ToString();

            Commit selectedCommit = currentRepository.Lookup<Commit>(selectedCommitHash);
            if (selectedCommit == null) { return; }

            string htmlContent = @"
            <!DOCTYPE html>
            <html>
            <head>
                <title>Commit info</title>
                <style>
                    body {
                        font-family: Arial, Helvetica, sans-serif;
                        font-size: 0.875em;
                    }
                    p {
                        margin-top: 0px;
                        margin-bottom: 0px;
                    }
                    .infobox {
                        padding: 10px;
                        margin-bottom: 15px;
                        box-shadow: rgba(0, 0, 0, 0.05) 0px 6px 24px 0px, rgba(0, 0, 0, 0.08) 0px 0px 0px 1px;
                    }
                </style>
            </head>
            <body>
                <div class=""infobox"">
                    <p>Author : " + selectedCommit.Author.Name + @" </p>
                    <p>Author e-mail : <a href=""mailto:" + selectedCommit.Author.Email + @""">" + selectedCommit.Author.Email + @"</a></p>
                    <p>Committer : " + selectedCommit.Committer.Name + @" </p>
                    <p>Committer e-mail : <a href=""mailto:" + selectedCommit.Author.Email + @""">" + selectedCommit.Committer.Email + @"</a></p>
                    <p>Commit date : " + selectedCommit.Committer.When.LocalDateTime.ToString() + @" </p>
                    <p>Commit hash : " + selectedCommit.Id.ToString() + @" </p>
                </div>
                <div class=""infobox"">
                    <p>Commit message :</p>
                    <p>" + selectedCommit.Message + @"
                </div>
            </body>
            </html>";

            wvCommitInfo.NavigateToString(htmlContent);

        }

        private async void InitializeHtml()
        {
            await wvCommitInfo.EnsureCoreWebView2Async(null);
        }

        private void ListFiles(Tree treeEntries, FileTreeNode parentNode)
        {
            foreach (var entry in treeEntries)
            {
                FileTreeNode newNode = new FileTreeNode(entry.Name);
                newNode.FileHash = entry.Target.Id.ToString();
                newNode.FilePath = entry.Path.ToString();
                switch (entry.TargetType)
                {
                    case TreeEntryTargetType.Tree:
                        newNode.IsFolder = true;
                        ListFiles((Tree)entry.Target, newNode);
                        break;
                    case TreeEntryTargetType.GitLink:
                    case TreeEntryTargetType.Blob:
                    default:
                        break;
                }

                parentNode.Nodes.Add(newNode);
            }
        }

        private void ClearFileTree()
        {
            tvFileTree.Nodes.Clear();
        }

        private async Task FillFileTree(int dgvRowIndex)
        {
            tvFileTree.SuspendLayout();
            ClearFileTree();
            if (dgvRowIndex < 0 || dgvRowIndex > dgvBranchHistory.Rows.Count - 1) { return; }
            string selectedCommitHash = dgvBranchHistory.Rows[dgvRowIndex].Cells["commitId"].Value.ToString();

            Commit selectedCommit = currentRepository.Lookup<Commit>(selectedCommitHash);
            if (selectedCommit == null) { return; }

            Tree fileTree = selectedCommit.Tree;
            if (fileTree == null) { return; }

            tvFileTree.TreeViewNodeSorter = new FileTreeNodeSorter();

            FileTreeNode parentNode = new FileTreeNode();
            parentNode.Text = "File tree for commit " + selectedCommit.Id.ToString();
            ListFiles(fileTree, parentNode);
            parentNode.Expand();
            tvFileTree.Nodes.Add(parentNode);
            tvFileTree.Sort();
            tvFileTree.ResumeLayout();
        }

        private void ClearTreeFileInfo()
        {
            rtbFileInfo.Clear();
        }

        private void ClearFilesListFilter()
        {
            filesListFilter.Clear();
        }

        private void CheckFilesTree(Tree treeEntries, List<Commit> commitsList)
        {
            foreach (var entry in treeEntries)
            {
                if (filesListFilter.Contains(entry.Path))
                {
                    DataRow newFileEntry = filesList.NewRow();
                    newFileEntry["fileName"] = entry.Path;
                    newFileEntry["status"] = "Found";
                    newFileEntry["fileHash"] = entry.Target.Id.ToString();

                    Commit fileCommit = Helper.GetCommitFileChanged(newFileEntry["fileName"].ToString(), newFileEntry["fileHash"].ToString(), commitsList);

                    if (fileCommit != null)
                    {
                        newFileEntry["fileAuthor"] = fileCommit.Author.Name;
                        newFileEntry["fileModifyDate"] = fileCommit.Committer.When.Date.ToShortDateString();
                        newFileEntry["fileCommitHash"] = fileCommit.Id.ToString();
                        newFileEntry["fileCommitMessage"] = fileCommit.MessageShort;
                    }
                    else
                    {
                        newFileEntry["fileAuthor"] = "";
                        newFileEntry["fileModifyDate"] = "";
                        newFileEntry["fileCommitHash"] = "";
                        newFileEntry["fileCommitMessage"] = "";
                    }

                    filesList.Rows.Add(newFileEntry);
                }
                switch (entry.TargetType)
                {
                    case TreeEntryTargetType.Tree:
                        CheckFilesTree((Tree)entry.Target, commitsList);
                        break;
                    case TreeEntryTargetType.GitLink:
                    case TreeEntryTargetType.Blob:
                    default:
                        break;
                }
            }
        }

        private void PopulateFilesListFilter()
        {
            filesListFilter = Helper.ParseFilterFile(tbFilesListPath.Text);
        }

        private async Task RetrieveFilesListInformation(int dgvRowIndex)
        {
            PrepareFilesListDataTable();

            if (dgvRowIndex < 0 || dgvRowIndex > dgvBranchHistory.Rows.Count - 1) { return; }
            if (tbFilesListPath.Text == "") { return; }
            string selectedCommitHash = dgvBranchHistory.Rows[dgvRowIndex].Cells["commitId"].Value.ToString();

            Commit selectedCommit = currentRepository.Lookup<Commit>(selectedCommitHash);
            if (selectedCommit == null) { return; }

            Tree fileTree = selectedCommit.Tree;
            if (fileTree == null) { return; }

            LibGit2Sharp.Branch selectedBranch = currentRepository.Branches[Helper.GetBranchName(cbBranchesList.Text)];
            List<Commit> commitsList = selectedBranch.Commits
                                            .OrderBy(c => c.Committer.When)
                                            .ToList();

            CheckFilesTree(fileTree, commitsList);

            foreach (var file in filesListFilter)
            {
                bool isFileFound = false;
                foreach (DataRow fileFound in filesList.Rows)
                {
                    if (fileFound["fileName"].ToString() == file)
                    {
                        isFileFound = true;
                        break;
                    }
                }

                if (isFileFound == false)
                {
                    DataRow newFileEntry = filesList.NewRow();
                    newFileEntry["fileName"] = file;
                    newFileEntry["status"] = "Not found";
                    newFileEntry["fileHash"] = "";
                    filesList.Rows.Add(newFileEntry);
                }

            }

            Helper.SizeDgvColumnsManually(dgvFilesHashList);
        }

        private void cbBranchesList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Text = FormBaseTitle + " - " + Helper.GetBranchName(cbBranchesList.Text);
            PopulateBranchHistory();
        }

        private void dgvBranchHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }

            if (dgvBranchHistory[e.ColumnIndex, e.RowIndex] is not DataGridViewLinkCell linkCell) { return; }

            string urlColumnName = dgvBranchHistory.Columns[e.ColumnIndex].Tag.ToString();
            if (!dgvBranchHistory.Columns.Contains(urlColumnName)) { return; }

            string url = dgvBranchHistory.Rows[e.RowIndex].Cells[urlColumnName].Value.ToString();
            if (url == null) { return; }

            Helper.ExecuteUrl(url);
        }

        private void BranchHistory_Load(object sender, EventArgs e)
        {
            //typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dgvBranchHistory, new object[] { true });
            
            this.CenterToParent();
        }

        private void dgvBranchHistory_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvBranchHistory.SelectedRows.Count == 0 || dgvBranchHistory.SelectedRows.Count > 1) { return; }
            int indexSelectedRow = dgvBranchHistory.SelectedRows[0].Index;
            string selectedEmail = dgvBranchHistory.Rows[indexSelectedRow].Cells["commitAuthorLink"].Value.ToString();
            if (selectedEmail == null) { return; }
            if (dgvBranchHistory.Rows[e.RowIndex].Cells["commitAuthorLink"].Value.ToString() == selectedEmail)
            {
                dgvBranchHistory.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                Font boldFont = new Font(dgvBranchHistory.DefaultCellStyle.Font, FontStyle.Bold);

                dgvBranchHistory.Rows[e.RowIndex].Cells["commitAuthor"].Style.Font = boldFont;
            }
            else
            {
                dgvBranchHistory.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
                dgvBranchHistory.Rows[e.RowIndex].Cells["commitAuthor"].Style.Font = dgvBranchHistory.DefaultCellStyle.Font;
            }
        }

        private void dgvBranchHistory_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (Properties.Settings.Default.ShowBranchLines == false) { return; }
            if (e.ColumnIndex != 0) { return; }
            if (e.RowIndex < 0) { return; }

            e.PaintBackground(e.CellBounds, true);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Brush brush = new SolidBrush(Color.Green);
            Pen pen = new Pen(Color.Green, 2);

            int diameter = 10;
            int cellLeftPadding = 4;
            int x = e.CellBounds.X + cellLeftPadding;
            int y = e.CellBounds.Y + (e.CellBounds.Height - diameter) / 2;

            if (dgvBranchHistory.Rows[e.RowIndex].Cells["commitTag"].Value.ToString() != "")
            {
                graphics.FillRectangle(brush, x, y, diameter, diameter);
            }
            else
            {
                graphics.FillEllipse(brush, x, y, diameter, diameter);
            }

            int padding = diameter + 6;
            Rectangle textRect = new Rectangle(e.CellBounds.X + padding, e.CellBounds.Y, e.CellBounds.Width - padding, e.CellBounds.Height);
            TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font, textRect, e.CellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

            if (Convert.ToInt32(dgvBranchHistory.Rows[e.RowIndex].Cells["commitParentCount"].Value.ToString()) == 1)
            {
                graphics.DrawLine(pen, x + diameter / 2, y + diameter / 2, x + diameter / 2, e.CellBounds.Y + e.CellBounds.Height);
            }

            e.Handled = true;
        }

        private async void dgvBranchHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBranchHistory.SelectedRows.Count == 0)
            {
                ClearCommitInfo();
                ClearFileTree();
                ClearTreeFileInfo();
                return;
            }
            ClearTreeFileInfo();
            await DisplayCommitInfo(dgvBranchHistory.SelectedRows[0].Index);
            await FillFileTree(dgvBranchHistory.SelectedRows[0].Index);
            await RetrieveFilesListInformation(dgvBranchHistory.SelectedRows[0].Index);
        }

        private void tvFileTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ClearTreeFileInfo();
            FileTreeNode selectedNode = e.Node as FileTreeNode;
            if (selectedNode == null) { return; }
            rtbFileInfo.AppendText(selectedNode.Text + ", hash : " + selectedNode.FileHash);
            rtbFileInfo.AppendText("\nComplete path : " + selectedNode.FilePath);
        }

        private void btnOpenFilesList_Click(object sender, EventArgs e)
        {
            DialogResult openFileResult = Helper.OpenFilterFile(ofdFilesListFiler);
            if (openFileResult == DialogResult.OK)
            {
                tbFilesListPath.Text = ofdFilesListFiler.FileName;
                ClearFilesListFilter();
                PopulateFilesListFilter();
                if (dgvBranchHistory.SelectedRows.Count > 0)
                {
                    RetrieveFilesListInformation(dgvBranchHistory.SelectedRows[0].Index);
                }
            }
        }

        private void wvCommitInfo_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess) { webViewInitialised = true; }
        }
    }
}
