using LibGit2Sharp;
using System.Data;
using System.Text;
using System.Web;

namespace CommitAnalysis
{
    public partial class MainWindow : Form
    {
        private string gitFolder = ".git";
        private string fileHashHeaderString = "File hash for ";
        private string fileHashesHeaderString = "File hashes for ";
        private string commitNameString = "Commit name for ";
        private string fileCommitHistoryString = "File commit history";
        private string referenceBranchString = "reference branch";
        private string targetBranchString = "target branch";
        private string firstCbTagItemString = "(latest commit)";
        private string noTagItemString = "(no tag)";
        private string cbHashesRefSelected = "";
        private string cbHashesTargetSelected = "";
        private int dgvFilesDifferenceSelectedRowIndex = -1;
        private bool updateComboBoxesFlag = true;
        private bool webViewInitialised = false;
        private Commit refCommit = null;
        private Commit targetCommit = null;
        private Repository currentRepository = null;
        private DataTable filesDifferencesTable = new DataTable();
        private List<string> filesListFilter = new List<string>();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            tbRepositoryPath.Text = Properties.Settings.Default.RepositoryPath.ToString();
            InitializeFileCommitHistoryString();
            InitializeHtml();
            UpdateInformation();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeFileCommitHistoryString()
        {
            tpFileCommitHistory.Text = fileCommitHistoryString;
        }

        private async void InitializeHtml()
        {
            await wvFileDifferences.EnsureCoreWebView2Async(null);
        }

        private void ClearComboBoxes()
        {
            cbBranchRef.Items.Clear();
            cbBranchTarget.Items.Clear();
            ClearTagComboBox(cbTagsRef);
            ClearTagComboBox(cbTagsTarget);
        }

        private void PopulateComboBoxes(List<string> list)
        {
            foreach (string item in list)
            {
                cbBranchRef.Items.Add(item);
                cbBranchTarget.Items.Add(item);
            }
            cbBranchRef.SelectedIndex = -1;
            cbBranchTarget.SelectedIndex = -1;
        }

        private void ConfigureDgvFilesDifference()
        {
            filesDifferencesTable.Clear();
            filesDifferencesTable.Columns.Clear();
            Helper.AddDataTableColumn(filesDifferencesTable, "Filename");
            Helper.AddDataTableColumn(filesDifferencesTable, "OldFilename");
            Helper.AddDataTableColumn(filesDifferencesTable, "State");
            Helper.AddDataTableColumn(filesDifferencesTable, "FileHashRef");
            Helper.AddDataTableColumn(filesDifferencesTable, "FileHashTarget");
            dgvFilesDifference.DataSource = filesDifferencesTable;
        }

        private void ResetDgvColumnsProperties()
        {
            dgvFilesDifference.Columns["Filename"].HeaderText = "Complete filepath";
            dgvFilesDifference.Columns["Filename"].Width = 400;
            dgvFilesDifference.Columns["OldFilename"].HeaderText = "Old filepath";
            dgvFilesDifference.Columns["FileHashRef"].HeaderText = fileHashHeaderString + referenceBranchString;
            dgvFilesDifference.Columns["FileHashRef"].DefaultCellStyle.Font = Helper.hashFont;
            dgvFilesDifference.Columns["FileHashRef"].Width = 300;
            dgvFilesDifference.Columns["FileHashTarget"].HeaderText = fileHashHeaderString + targetBranchString;
            dgvFilesDifference.Columns["FileHashTarget"].DefaultCellStyle.Font = Helper.hashFont;
            dgvFilesDifference.Columns["FileHashTarget"].Width = 300;
        }

        private void UpdateInformation()
        {
            ClearComboBoxes();
            ConfigureDgvFilesDifference();
            ResetDgvColumnsProperties();
            ClearHashComboBoxes();
            ClearFilesDifferenceList();
            ClearFileCommitHistoryList();
            InitializeFileCommitHistoryString();
            CheckApplyFilterActivation();

            string gitFolderPath = Path.Combine(tbRepositoryPath.Text, gitFolder);

            if (Directory.Exists(gitFolderPath))
            {
                SetCurrentRepository(tbRepositoryPath.Text);
                List<string> branchesList = Helper.FetchBranches(tbRepositoryPath.Text);
                PopulateComboBoxes(branchesList);
            }
            else
            {
                ClearCurrentRepository();
                lbStatusMessage.Text = "Warning : this folder is not managed by Git versioning";
            }

            ClearFileDifferences();

        }

        private void ClearFilesDifferenceList()
        {
            filesDifferencesTable.Rows.Clear();
            lbStatusMessage.Text = string.Empty;
        }

        private void ClearFileCommitHistoryList()
        {
            dgvFileCommitHistory.Rows.Clear();
        }

        private void ClearTagComboBox(ComboBox targetTagCombobox)
        {
            if (targetTagCombobox == null) { return; }
            targetTagCombobox.Items.Clear();
            targetTagCombobox.Items.Add(firstCbTagItemString);
            targetTagCombobox.Items.Add(noTagItemString);
            targetTagCombobox.SelectedIndex = 0;
        }

        private void FillTagComboBox(ComboBox targetTagCombobox, string branchName)
        {
            if (targetTagCombobox == null) { return; }
            ClearTagComboBox(targetTagCombobox);

            List<string> tags = Helper.FetchTagsInBranch<string>(currentRepository, branchName);

            foreach (string tag in tags)
            {
                targetTagCombobox.Items.Add(tag);
            }

        }

        private void FillHashComboBox(ComboBox targetHashComboBox, string branchName)
        {
            if (targetHashComboBox == null) { return; }
            targetHashComboBox.Items.Clear();
            var selectedBranch = currentRepository.Branches[branchName];
            foreach (var commit in selectedBranch.Commits)
            {
                targetHashComboBox.Items.Add(commit.Id.ToString());
            }
            if (targetHashComboBox.Items.Count > 0)
            {
                targetHashComboBox.SelectedIndex = 0;
            }
        }

        private void SetCurrentRepository(string repositoryPath)
        {
            currentRepository = new Repository(repositoryPath);
        }

        private void ClearCurrentRepository()
        {
            currentRepository = null;
        }

        private void SetCommits()
        {
            refCommit = null;
            targetCommit = null;

            Branch refBranch = null;
            Branch targetBranch = null;

            if (cbBranchRef.SelectedItem != null)
            {
                refBranch = currentRepository.Branches[Helper.GetBranchName(cbBranchRef.Text)];
            }

            if (cbBranchTarget.SelectedItem != null)
            {
                targetBranch = currentRepository.Branches[Helper.GetBranchName(cbBranchTarget.Text)];
            }

            if (refBranch != null)
            {
                refCommit = refBranch.Tip;
                Commit tagRefCommit = GetTagCommit(cbTagsRef, refBranch);
                if (tagRefCommit != null)
                {
                    refCommit = tagRefCommit;
                }
                else
                {
                    Commit foundRefCommit = Helper.GetCommitById(cbHashesRef.Text, currentRepository);
                    if (foundRefCommit != null) { refCommit = foundRefCommit; }
                }
            }
            if (targetBranch != null)
            {
                targetCommit = targetBranch.Tip;
                Commit tagTargetCommit = GetTagCommit(cbTagsTarget, targetBranch);
                if (tagTargetCommit != null)
                {
                    targetCommit = tagTargetCommit;
                }
                else
                {
                    Commit foundTargetCommit = Helper.GetCommitById(cbHashesTarget.Text, currentRepository);
                    if (foundTargetCommit != null) { targetCommit = foundTargetCommit; }
                }
            }
        }

        private Commit GetTagCommit(ComboBox cbTag, Branch branch)
        {
            Commit result = null;

            if (cbTag.SelectedIndex <= 1) { return result; }

            var tag = currentRepository.Tags[cbTag.Text];
            if (tag == null) { return result; };

            Commit tagCommit = (Commit)tag.Target;
            if (tagCommit == null) { return result; }

            result = branch.Commits.FirstOrDefault(commit => commit.Sha == tagCommit.Sha);

            return result;
        }



        private void UpdateHashComboBoxes()
        {
            if (refCommit != null && cbHashesRef.Text != refCommit.Sha.ToString())
            {
                cbHashesRef.Text = refCommit.Sha.ToString();
            }
            if (targetCommit != null && cbHashesTarget.Text != targetCommit.Sha.ToString())
            {
                cbHashesTarget.Text = targetCommit.Sha.ToString();
            }
        }

        private void ClearHashComboBoxes()
        {
            cbHashesRef.Items.Clear();
            cbHashesRef.Text = string.Empty;
            cbHashesRefSelected = "";
            cbHashesTarget.Items.Clear();
            cbHashesTarget.Text = string.Empty;
            cbHashesTargetSelected = "";
        }

        private void ClearFilesListFilter()
        {
            filesListFilter.Clear();
        }

        private void PopulateFilesListFilter()
        {
            filesListFilter = Helper.ParseFilterFile(tbFilesFilterPath.Text);
        }

        private void GetFilesDifference()
        {
            if (cbApplyFilter.Checked == true && tbFilesFilterPath.Text != "")
            {
                GetFilesDifferenceWithFilter();
            }
            else
            {
                GetFilesDifferenceOnly();
            }
        }

        private void GetFilesDifferenceWithFilter()
        {
            if (refCommit == null || targetCommit == null) { return; }

            var changes = currentRepository.Diff.Compare<TreeChanges>(refCommit.Tree, targetCommit.Tree);

            filesDifferencesTable.Rows.Clear();

            foreach (string file in filesListFilter)
            {
                DataRow newDataRow = filesDifferencesTable.NewRow();
                newDataRow["Filename"] = file;

                bool fileFound = false;

                foreach (var change in changes)
                {
                    if (change.Path == file || change.OldPath == file)
                    {
                        fileFound = true;

                        var refTreeEntry = refCommit[change.OldPath];
                        var targetTreeEntry = targetCommit[change.Path];
                        if (change.OldPath != change.Path)
                        {
                            newDataRow["Filename"] = change.Path;
                            newDataRow["OldFilename"] = change.OldPath;
                        }
                        else
                        {
                            newDataRow["OldFilename"] = string.Empty;
                        }
                        newDataRow["State"] = change.Status.ToString();
                        if (refTreeEntry != null)
                        {
                            newDataRow["FileHashRef"] = refTreeEntry.Target.Sha.ToString();
                        }

                        if (targetTreeEntry != null)
                        {
                            newDataRow["FileHashTarget"] = targetTreeEntry.Target.Sha.ToString();
                        }
                        break;
                    }
                }

                if (!fileFound)
                {
                    var refTreeEntry = refCommit[file];
                    var targetTreeEntry = targetCommit[file];

                    if (refTreeEntry == null || targetTreeEntry == null)
                    {
                        newDataRow["OldFilename"] = string.Empty;
                        newDataRow["State"] = "Not found";
                        newDataRow["FileHashRef"] = string.Empty;
                        newDataRow["FileHashTarget"] = string.Empty;
                    }
                    else
                    {
                        newDataRow["OldFilename"] = string.Empty;
                        newDataRow["State"] = "Identical";
                        newDataRow["FileHashRef"] = refTreeEntry.Target.Sha.ToString();
                        newDataRow["FileHashTarget"] = targetTreeEntry.Target.Sha.ToString();
                    }


                }

                filesDifferencesTable.Rows.Add(newDataRow);
            }

            if (filesDifferencesTable.Rows.Count > 0)
            {
                Helper.SizeDgvColumnsManually(dgvFilesDifference, 5);
            }

        }

        private void GetFilesDifferenceOnly()
        {
            if (refCommit == null || targetCommit == null) { return; }

            var changes = currentRepository.Diff.Compare<TreeChanges>(refCommit.Tree, targetCommit.Tree);

            int differenceCount = changes.Count();
            int addedCount = 0;
            int deletedCount = 0;

            filesDifferencesTable.Rows.Clear();

            foreach (var change in changes)
            {

                var refTreeEntry = refCommit[change.OldPath];
                var targetTreeEntry = targetCommit[change.Path];

                DataRow newDataRow = filesDifferencesTable.NewRow();
                newDataRow["Filename"] = change.Path;
                if (change.OldPath != change.Path)
                {
                    newDataRow["OldFilename"] = change.OldPath;
                }
                else
                {
                    newDataRow["OldFilename"] = string.Empty;
                }

                newDataRow["State"] = change.Status.ToString();

                if (refTreeEntry != null)
                {
                    newDataRow["FileHashRef"] = refTreeEntry.Target.Sha.ToString();
                }

                if (targetTreeEntry != null)
                {
                    newDataRow["FileHashTarget"] = targetTreeEntry.Target.Sha.ToString();
                }

                filesDifferencesTable.Rows.Add(newDataRow);
            }

            dgvFilesDifference.DataSource = filesDifferencesTable;

            if (differenceCount == 0)
            {
                lbStatusMessage.Text = "No differences between the two branches.";
            }
            else
            {
                Helper.SizeDgvColumnsManually(dgvFilesDifference, 5);
                lbStatusMessage.Text = $"{differenceCount} differences, from which {addedCount} files added and {deletedCount} files deleted.";
            }

        }

        private void GetFileHistory(string filePath, string oldFilePath, string refFileHash, string targetFileHash, ref List<TreeEntry> refFileHistory, ref List<TreeEntry> targetFileHistory, ref List<Commit> refFileHistoryCommit, ref List<Commit> targetFileHistoryCommit)
        {
            var refCommitsList = currentRepository.Branches[Helper.GetBranchName(cbBranchRef.Text)].Commits.ToList();
            var targetCommitsList = currentRepository.Branches[Helper.GetBranchName(cbBranchTarget.Text)].Commits.ToList();

            string refLastFileHash = String.Empty;
            string targetLastFileHash = String.Empty;

            int refCommitsListCount = refCommitsList.Count();
            int targetCommitsListCount = targetCommitsList.Count();

            refFileHistory = new List<TreeEntry>();
            targetFileHistory = new List<TreeEntry>();

            refFileHistoryCommit = new List<Commit>();
            targetFileHistoryCommit = new List<Commit>();

            Commit refFileHistoryCommitTemp = null;
            Commit targetFileHistoryCommitTemp = null;

            bool refCommitStartFlag = false;
            bool refFirstIterationFlag = false;
            bool targetCommitStartFlag = false;
            bool targetFirstIterationFlag = false;

            string refFilePath = filePath;

            if (oldFilePath != "" && oldFilePath != string.Empty) { refFilePath = oldFilePath; }

            for (int i = 0; i < Math.Max(refCommitsListCount, targetCommitsListCount); i++)
            {
                if (i < refCommitsListCount)
                {
                    var refTreeEntry = refCommitsList[i][refFilePath];
                    if (refTreeEntry != null && refLastFileHash != refTreeEntry.Target.Sha.ToString())
                    {
                        if (i > 0 && refCommitStartFlag == true && refFirstIterationFlag == false)
                        {
                            refFirstIterationFlag = true;
                        }
                        if (refTreeEntry.Target.Sha.ToString() == refFileHash)
                        {
                            refCommitStartFlag = true;
                        }
                        if (refCommitStartFlag)
                        {
                            if (refFirstIterationFlag)
                            {
                                refFileHistoryCommit.Add(refFileHistoryCommitTemp);
                            }
                            refFileHistory.Add(refTreeEntry);
                            refLastFileHash = refTreeEntry.Target.Sha.ToString();
                            refFileHistoryCommitTemp = refCommitsList[i];
                        }
                    }
                    else if (refTreeEntry != null)
                    {
                        refFileHistoryCommitTemp = refCommitsList[i];
                    }
                }

                if (i < targetCommitsListCount)
                {
                    var targetTreeEntry = targetCommitsList[i][filePath];
                    if (targetTreeEntry != null && targetLastFileHash != targetTreeEntry.Target.Sha.ToString())
                    {
                        if (i > 0 && targetCommitStartFlag == true && targetFirstIterationFlag == false)
                        {
                            targetFirstIterationFlag = true;
                        }
                        if (targetTreeEntry.Target.Sha.ToString() == targetFileHash)
                        {
                            targetCommitStartFlag = true;
                        }
                        if (targetCommitStartFlag)
                        {
                            if (targetFirstIterationFlag)
                            {
                                targetFileHistoryCommit.Add(targetFileHistoryCommitTemp);
                            }
                            targetFileHistory.Add(targetTreeEntry);
                            targetLastFileHash = targetTreeEntry.Target.Sha.ToString();
                            targetFileHistoryCommitTemp = targetCommitsList[i];
                        }
                    }
                    else if (targetTreeEntry != null)
                    {
                        targetFileHistoryCommitTemp = targetCommitsList[i];
                    }
                }
            }

            if (refFileHistoryCommitTemp != null)
            {
                refFileHistoryCommit.Add(refFileHistoryCommitTemp);
            }

            if (targetFileHistoryCommitTemp != null)
            {
                targetFileHistoryCommit.Add(targetFileHistoryCommitTemp);
            }

        }

        private List<CommitItem> CreateMergedSortedList(List<TreeEntry> refFileHistory, List<TreeEntry> targetFileHistory, List<Commit> refFileHistoryCommit, List<Commit> targetFileHistoryCommit)
        {
            List<CommitItem> mergedList = new List<CommitItem>();

            for (int i = 0; i < refFileHistory.Count; i++)
            {
                if (refFileHistory[i] == null) { continue; }
                if (refFileHistoryCommit[i] == null) { continue; }
                mergedList.Add(new CommitItem(refFileHistory[i].Target.Sha.ToString(), refFileHistoryCommit[i].MessageShort.ToString(), refFileHistoryCommit[i].Committer.When));
            }

            for (int i = 0; i < targetFileHistory.Count; i++)
            {
                if (targetFileHistory[i] == null) { continue; }
                if (targetFileHistoryCommit[i] == null) { continue; }
                mergedList.Add(new CommitItem(targetFileHistory[i].Target.Sha.ToString(), targetFileHistoryCommit[i].MessageShort.ToString(), targetFileHistoryCommit[i].Committer.When));

            }

            mergedList = mergedList
                .GroupBy(item => new { item.Hash, item.Description, item.DateTimeOffset })
                .Select(groupe => groupe.First())
                .ToList();

            mergedList = mergedList.OrderByDescending(item => item.DateTimeOffset).ToList();

            return mergedList;
        }

        private void FillDgvFileCommitHistory(List<TreeEntry> refFileHistory, List<TreeEntry> targetFileHistory, List<Commit> refFileHistoryCommit, List<Commit> targetFileHistoryCommit)
        {
            List<CommitItem> mergedList = CreateMergedSortedList(refFileHistory, targetFileHistory, refFileHistoryCommit, targetFileHistoryCommit);

            foreach (CommitItem item in mergedList)
            {
                int indexRow = dgvFileCommitHistory.Rows.Add();
                DataGridViewRow newRow = dgvFileCommitHistory.Rows[indexRow];

                for (int i = 0; i < refFileHistory.Count; i++)
                {
                    if (refFileHistory[i] == null) { continue; }
                    if (refFileHistoryCommit[i] == null) { continue; }
                    string currentHash = refFileHistory[i].Target.Sha.ToString();
                    string currentDescription = refFileHistoryCommit[i].MessageShort.ToString();
                    DateTimeOffset currentDateTimeOffset = refFileHistoryCommit[i].Committer.When;

                    if (item.Hash == currentHash && item.Description == currentDescription && item.DateTimeOffset == currentDateTimeOffset)
                    {
                        if (refFileHistoryCommit[i].Parents.Count() > 1)
                        {
                            newRow.Cells["FileHistoryHashRef"].Style.ForeColor = Color.LightGray;
                            newRow.Cells["CommitDateRef"].Style.ForeColor = Color.LightGray;
                            newRow.Cells["RefCommitName"] = new DataGridViewTextBoxCell();
                            newRow.Cells["RefCommitName"].Style.ForeColor = Color.LightGray;
                        }
                        else
                        {
                            newRow.Cells["RefCommitName"].ToolTipText = Properties.Settings.Default.JIRABaseAddress.ToString() + Helper.ExtractJIRATicket(refFileHistoryCommit[i]);
                        }
                        newRow.Cells["FileHistoryHashRef"].Value = currentHash;
                        newRow.Cells["CommitDateRef"].Value = currentDateTimeOffset.Date.ToShortDateString();
                        newRow.Cells["RefCommitName"].Value = currentDescription;
                        break;
                    }

                }

                for (int i = 0; i < targetFileHistory.Count; i++)
                {
                    if (targetFileHistory[i] == null) { continue; }
                    if (targetFileHistoryCommit[i] == null) { continue; }
                    string currentHash = targetFileHistory[i].Target.Sha.ToString();
                    string currentDescription = targetFileHistoryCommit[i].MessageShort.ToString();
                    DateTimeOffset currentDateTimeOffset = targetFileHistoryCommit[i].Committer.When;

                    if (item.Hash == currentHash && item.Description == currentDescription && item.DateTimeOffset == currentDateTimeOffset)
                    {
                        if (targetFileHistoryCommit[i].Parents.Count() > 1)
                        {
                            newRow.Cells["FileHistoryHashTarget"].Style.ForeColor = Color.LightGray;
                            newRow.Cells["CommitDateTarget"].Style.ForeColor = Color.LightGray;
                            newRow.Cells["TargetCommitName"] = new DataGridViewTextBoxCell();
                            newRow.Cells["TargetCommitName"].Style.ForeColor = Color.LightGray;
                        }
                        else
                        {
                            newRow.Cells["TargetCommitName"].ToolTipText = Properties.Settings.Default.JIRABaseAddress.ToString() + Helper.ExtractJIRATicket(targetFileHistoryCommit[i]);
                        }
                        newRow.Cells["FileHistoryHashTarget"].Value = currentHash;
                        newRow.Cells["CommitDateTarget"].Value = currentDateTimeOffset.Date.ToShortDateString();
                        newRow.Cells["TargetCommitName"].Value = currentDescription;
                        break;
                    }

                }
            }
            Helper.SizeDgvColumnsManually(dgvFileCommitHistory);
        }

        private void ClearFileDifferences()
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
            wvFileDifferences.NavigateToString(htmlContent);
        }

        private void FillFileDifferences(List<TreeEntry> refFileHistory, List<TreeEntry> targetFileHistory)
        {

            if (refFileHistory.Count == 0 || targetFileHistory.Count == 0)
            {
                ClearFileDifferences();
                return;
            }

            GitObject refFile = refFileHistory[0].Target;
            GitObject targetFile = targetFileHistory[0].Target;

            ContentChanges fileDifferences = currentRepository.Diff.Compare((Blob)refFile, (Blob)targetFile);

            StringBuilder htmlContent = new StringBuilder();
            htmlContent.Append(@"
            <!DOCTYPE html>
            <html>
            <head>
                <title>Commit info</title>
                <style>
                    body {
                        font-family: ui-monospace, SFMono-Regular, SF Mono, Menlo, Consolas, Liberation Mono, monospace;
                        font-size: 12px;
                    }
                    p {
                        margin-top: 0px;
                        margin-bottom: 0px;
                    }
                    table {
                        border: 1px solid #d0d7de;
                        border-radius: 6px;
                        border-style: solid;
                        border-collapse:collapse;
                        width: 100%;
                        margin-bottom: 10px;
                        table-layout: fixed;
                    }
                    .infobox {
                        padding: 10px;
                        margin-bottom: 15px;
                        box-shadow: rgba(0, 0, 0, 0.05) 0px 6px 24px 0px, rgba(0, 0, 0, 0.08) 0px 0px 0px 1px;
                    }
                    .added {
                        background-color: #e6ffec;
                    }
                    .added-accent {
                        background-color: #ccffd8;
                    }
                    .removed {
                        background-color: #ffebe9;
                    }
                    .removed-accent {
                        background-color: #ffd7d5;
                    }
                    .not-present {
                        background-color: #f4f6f8;
                    }
                    .col-number {
                        text-align: right;
                        width: 1%;
                        min-width: 50px;
                        line-height: 20px;
                        vertical-align: top;
                        padding-right: 10px;
                        padding-left: 10px;
                    }
                    .col-code {
                        width: 49%;
                        padding-left: 22px;
                        padding-right: 22px;
                        vertical-align: top;
                        word-wrap: break-word;
                    }
                    .line-number {
                        text-align: right;
                        min-width: 50px;
                        line-height: 20px;
                        vertical-align: top;
                        padding-right: 10px;
                        padding-left: 10px;
                    }
                    .line-number-right {
                        border-left: 1px solid hsla(210,18%,87%,1);
                    }
                    .line-code {
                        padding-left: 22px;
                        padding-right: 22px;
                        line-height: 20px;
                        vertical-align: top;
                        word-wrap: break-word;
                    }
                    .line-patch {
                        padding-top: 8px;
                        padding-bottom: 8px;
                        padding-left: 22px;
                        background-color: #ddf4ff;
                        vertical-align: middle;
                        color: #656d76;
                    }
                </style>
            </head>
            <body>
                <table>
                    <colgroup>
                        <col class=""col-number"">
                        <col class=""col-code"">
                        <col class=""col-number"">
                        <col class=""col-code"">
                    </colgroup>

            ");

            List<FileDifference> differences = Helper.ExtractFileDifferences(fileDifferences.Patch);

            foreach (FileDifference difference in differences)
            {
                int numberOfLines = Math.Max(difference.ReferenceFileLines.Count(), difference.ComparedFileLines.Count());
                int currentIndexRef = 0;
                int currentIndexTarget = 0;

                string refDifferenceString = "-" + difference.ReferenceFileStartLine.ToString() + "," + difference.ReferenceFileLines.Count().ToString();
                string targetDifferenceString = "+" + difference.ComparedFileStartLine.ToString() + "," + difference.ComparedFileLines.Count().ToString();

                htmlContent.Append(@"<tr><td class=""line-patch"" colspan=""4"">@@ " + refDifferenceString + " " + targetDifferenceString + "</td></tr>");

                for (int i = 0; i < numberOfLines; i++)
                {
                    htmlContent.Append("<tr>");
                    string refLine = difference.ReferenceFileLines[Math.Min(currentIndexRef, difference.ReferenceFileLines.Count() - 1)];
                    int refLineNumber = difference.ReferenceFileStartLine + currentIndexRef;
                    string targetLine = difference.ComparedFileLines[Math.Min(currentIndexTarget, difference.ComparedFileLines.Count() - 1)];
                    int targetLineNumber = difference.ComparedFileStartLine + currentIndexTarget;

                    if (refLine == targetLine || (refLine.StartsWith("-") && targetLine.StartsWith("+")))
                    {
                        string refClass = "";
                        string refNumberClass = "";
                        string targetClass = "";
                        string targetNumberClass = "";

                        if (refLine.StartsWith("-"))
                        {
                            refClass = "removed";
                            refNumberClass = "removed-accent";
                        }
                        if (targetLine.StartsWith("+"))
                        {
                            targetClass = "added";
                            targetNumberClass = "added-accent";
                        }
                        htmlContent.Append(@"<td class=""line-number " + refClass + " " + refNumberClass + @""">" + refLineNumber.ToString() + @"</td><td class=""line-code " + refClass + @""">" + HttpUtility.HtmlEncode(refLine) + @"</td><td class=""line-number line-number-right " + targetClass + " " + targetNumberClass + @""">" + targetLineNumber.ToString() + @"</td><td class=""line-code " + targetClass + @""">" + HttpUtility.HtmlEncode(targetLine) + "</td></tr>");
                        currentIndexRef++;
                        currentIndexTarget++;
                    }
                    else if (targetLine.StartsWith("+"))
                    {
                        htmlContent.Append(@"<td class=""line-number not-present""></td><td class=""line-code not-present""></td><td class=""line-number line-number-right added added-accent"">" + targetLineNumber.ToString() + @"</td><td class=""line-code added"">" + HttpUtility.HtmlEncode(targetLine) + "</td></tr>");
                        currentIndexTarget++;
                    }
                    else if (refLine.StartsWith("-"))
                    {
                        htmlContent.Append(@"<td class=""line-number removed removed-accent"">" + refLineNumber.ToString() + @"</td><td class=""line-code removed"">" + HttpUtility.HtmlEncode(refLine) + @"</td><td class=""line-number line-number-right not-present""></td><td class=""line-code not-present""></td></tr>");
                        currentIndexRef++;
                    }
                }
            }

            htmlContent.Append("</table></body>");
            wvFileDifferences.NavigateToString(htmlContent.ToString().Substring(0, Math.Min(1572825, htmlContent.Length)));

        }

        private void GenerateListOfTickets(ref Dictionary<string, List<string>> refTickets, ref Dictionary<string, List<string>> targetTickets, ref Dictionary<string, List<string>> refFilesTickets, ref Dictionary<string, List<string>> targetFilesTickets)
        {

            refTickets = new Dictionary<string, List<string>>();
            targetTickets = new Dictionary<string, List<string>>();

            refFilesTickets = new Dictionary<string, List<string>>();
            targetFilesTickets = new Dictionary<string, List<string>>();

            foreach (DataGridViewRow row in dgvFilesDifference.Rows)
            {
                List<TreeEntry> refFileHistory = new List<TreeEntry>();
                List<TreeEntry> targetFileHistory = new List<TreeEntry>();
                List<Commit> refFileHistoryCommit = new List<Commit>();
                List<Commit> targetFileHistoryCommit = new List<Commit>();

                if (row.Cells["Filename"].Value.ToString() == null) { continue; }

                string filePath = GetDbvCellValue(row, "Filename");
                string oldFilePath = GetDbvCellValue(row, "OldFilename");

                if (filePath == string.Empty) { continue; }

                string refFileHash = GetDbvCellValue(row, "FileHashRef");
                string targetFileHash = GetDbvCellValue(row, "FileHashTarget");

                GetFileHistory(filePath, oldFilePath, refFileHash, targetFileHash, ref refFileHistory, ref targetFileHistory, ref refFileHistoryCommit, ref targetFileHistoryCommit);
                CompareFileHistory(filePath, ref refTickets, ref refFilesTickets, refFileHistory, targetFileHistory, refFileHistoryCommit);
                CompareFileHistory(filePath, ref targetTickets, ref targetFilesTickets, targetFileHistory, refFileHistory, targetFileHistoryCommit);
            }
        }

        private void CompareFileHistory(string filePath, ref Dictionary<string, List<string>> ticketsDict, ref Dictionary<string, List<string>> filesTicketsDict, List<TreeEntry> baseFileHistory, List<TreeEntry> comparedFileHistory, List<Commit> baseFileHistoryCommit)
        {
            for (int i = 0; i < baseFileHistory.Count; i++)
            {
                if (baseFileHistoryCommit[i] == null) { continue; }
                if (baseFileHistoryCommit[i].Parents.Count() > 1) { continue; }

                bool fileShaFound = false;

                for (int j = 0; j < comparedFileHistory.Count; j++)
                {
                    if (baseFileHistory[i].Target.Sha == comparedFileHistory[j].Target.Sha)
                    {
                        fileShaFound = true;
                        break;
                    }
                }

                if (fileShaFound) { break; }

                string commitTicket = Helper.ExtractJIRATicket(baseFileHistoryCommit[i]);

                if (ticketsDict.ContainsKey(commitTicket))
                {
                    ticketsDict[commitTicket].Add(filePath);
                }
                else
                {
                    ticketsDict.Add(commitTicket, new List<string> { filePath });
                }

                if (filesTicketsDict.ContainsKey(filePath))
                {
                    filesTicketsDict[filePath].Add(commitTicket);
                }
                else
                {
                    filesTicketsDict.Add(filePath, new List<string> { commitTicket });
                }
            }
        }



        private void btnRepositoryPath_Click(object sender, EventArgs e)
        {
            fbdDialog.Description = "Select the repository path";
            fbdDialog.ShowNewFolderButton = false;
            DialogResult resultFolderPath = fbdDialog.ShowDialog();

            if (resultFolderPath == DialogResult.OK)
            {
                Properties.Settings.Default.RepositoryPath = fbdDialog.SelectedPath;
                Properties.Settings.Default.Save();

                tbRepositoryPath.Text = fbdDialog.SelectedPath;
                UpdateInformation();
            }
        }

        private void UpdateDgvHeaders(string branchType, string message)
        {
            dgvFilesDifference.Columns["FileHash" + branchType].HeaderText = fileHashHeaderString + message;
            dgvFileCommitHistory.Columns["FileHistoryHash" + branchType].HeaderText = fileHashesHeaderString + message;
            dgvFileCommitHistory.Columns[branchType + "CommitName"].HeaderText = commitNameString + message;
        }


        private void cbSelectionUpdate()
        {
            DeactivateComboBoxesHandles();
            ClearFilesDifferenceList();
            ClearFileCommitHistoryList();
            InitializeFileCommitHistoryString();
            SetCommits();
            UpdateHashComboBoxes();
            GetFilesDifference();
            ActivateComboBoxesHandles();
        }

        private void CheckApplyFilterActivation()
        {
            btnOpenFilesFilter.Enabled = cbApplyFilter.Checked;
            btnReloadFilter.Enabled = cbApplyFilter.Checked;
            tbFilesFilterPath.Enabled = cbApplyFilter.Checked;
        }

        private void ValidateHashComboBoxValue(ComboBox targetComboBox, ref string oldValue)
        {
            if (targetComboBox.Items.Contains(targetComboBox.Text))
            {
                oldValue = targetComboBox.Text;
            }
            else
            {
                targetComboBox.Text = oldValue;
            }
        }

        private string GetDbvCellValue(DataGridView dgvTarget, string columnName, int rowIndex)
        {
            if (dgvTarget == null) { return string.Empty; }
            if (dgvTarget.Rows.Count - 1 < rowIndex) { return string.Empty; }
            if (!dgvTarget.Columns.Contains(columnName)) { return string.Empty; }
            if (dgvTarget.Rows[rowIndex].Cells[columnName].Value == null) { return string.Empty; }
            return dgvTarget.Rows[rowIndex].Cells[columnName].Value.ToString();
        }

        private string GetDbvCellValue(DataGridViewRow row, string columnName)
        {
            if (row == null) { return string.Empty; };
            if (row.Cells[columnName] == null) { return string.Empty; }
            if (row.Cells[columnName].Value == null) { return string.Empty; }
            return row.Cells[columnName].Value.ToString();
        }

        private void ShowBranchHistoryWindow(string branchName = "", string commitHash = "")
        {
            BranchHistory newBranchHistoryWindow = new BranchHistory();
            newBranchHistoryWindow.InitBranchHistoryWindow();
            newBranchHistoryWindow.currentRepository = currentRepository;
            newBranchHistoryWindow.ClearComboBox();
            newBranchHistoryWindow.SetRepositoryPath(tbRepositoryPath.Text);
            newBranchHistoryWindow.PopulateComboBox(Helper.FetchBranches(tbRepositoryPath.Text), branchName);
            newBranchHistoryWindow.PopulateBranchHistory();
            newBranchHistoryWindow.SelectCommit(commitHash);
            newBranchHistoryWindow.Show();
        }

        private void dgvFileCommitHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
            if (dgvFileCommitHistory[e.ColumnIndex, e.RowIndex] is not DataGridViewLinkCell linkCell) { return; }

            string url = linkCell.ToolTipText.ToString();
            Helper.ExecuteUrl(url);
        }

        private void getUniqueListOfTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> refTickets = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> targetTickets = new Dictionary<string, List<string>>();

            Dictionary<string, List<string>> refFilesTickets = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> targetFilesTickets = new Dictionary<string, List<string>>();

            GenerateListOfTickets(ref refTickets, ref targetTickets, ref refFilesTickets, ref targetFilesTickets);

            string refBranchString = "Branch : " + Helper.GetBranchName(cbBranchRef.Text);
            string targetBranchString = "Branch : " + Helper.GetBranchName(cbBranchTarget.Text);

            if (cbTagsRef.SelectedIndex == 0)
            {
                refBranchString = refBranchString + " - Last commit";
            }
            else
            {
                refBranchString = refBranchString + " - Tag : " + cbTagsRef.Text;
            }
            if (cbTagsTarget.SelectedIndex == 0)
            {
                targetBranchString = targetBranchString + " - Last commit";
            }
            else
            {
                targetBranchString = targetBranchString + " - Tag : " + cbTagsTarget.Text;
            }
            refBranchString = refBranchString + " (" + cbHashesRef.Text + ")";
            targetBranchString = targetBranchString + " (" + cbHashesTarget.Text + ")";

            Analysis newAnalysis = new Analysis();
            newAnalysis.PopulateAnalysisDataGridViews(refTickets, targetTickets, refFilesTickets, targetFilesTickets);
            newAnalysis.PopulateBranchesNames(refBranchString, targetBranchString);
            newAnalysis.PopulateJIRAFilters(refTickets, targetTickets);
            newAnalysis.Show();
        }

        private void showBranchHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBranchHistoryWindow();
        }

        private void cbBranchRef_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbBranchRef.SelectedItem != null)
            {
                string refBranchName = Helper.GetBranchName(cbBranchRef.Text);
                UpdateDgvHeaders("Ref", refBranchName);
                FillTagComboBox(cbTagsRef, refBranchName);
                FillHashComboBox(cbHashesRef, refBranchName);
                cbSelectionUpdate();
            }
        }

        private void cbBranchTarget_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbBranchTarget.SelectedItem != null)
            {
                string targetBranchName = Helper.GetBranchName(cbBranchTarget.Text);
                UpdateDgvHeaders("Target", targetBranchName);
                FillTagComboBox(cbTagsTarget, targetBranchName);
                FillHashComboBox(cbHashesTarget, targetBranchName);
                cbSelectionUpdate();
            }
        }

        private void cbTagsRef_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (updateComboBoxesFlag == false) { return; }
            cbTagsChange(cbTagsRef, "Ref", cbBranchRef, referenceBranchString);
        }

        private void cbTagsTarget_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (updateComboBoxesFlag == false) { return; }
            cbTagsChange(cbTagsTarget, "Target", cbBranchTarget, targetBranchString);
        }

        private void cbTagsChange(ComboBox targetComboBox, string commitType, ComboBox targetBranchComboBox, string dgvHeaderString)
        {
            if (targetComboBox.SelectedIndex > 0)
            {
                UpdateDgvHeaders(commitType, targetComboBox.Text);
            }
            else if (targetBranchComboBox.SelectedItem != null)
            {
                string targetBranchName = Helper.GetBranchName(targetBranchComboBox.Text);
                UpdateDgvHeaders(commitType, targetBranchName);
            }
            else
            {
                UpdateDgvHeaders(commitType, dgvHeaderString);
            }
            cbSelectionUpdate();
        }

        private void dgvFilesDifference_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            if (sender == null) { return; }

            DataGridView dataGridViewTarget = sender as DataGridView;
            if (!dataGridViewTarget.Columns.Contains("State")) { return; }

            switch (dataGridViewTarget.Rows[e.RowIndex].Cells["State"].Value)
            {
                case "Added":
                    dataGridViewTarget.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                    break;
                case "Deleted":
                    dataGridViewTarget.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    dataGridViewTarget.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    break;
                case "Renamed":
                    dataGridViewTarget.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                    break;
                case "Identical":
                    dataGridViewTarget.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    break;
                case "Not found":
                    dataGridViewTarget.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gainsboro;
                    break;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void cbHashesRef_SelectedValueChanged(object sender, EventArgs e)
        {
            if (updateComboBoxesFlag == false) { return; }
            DeactivateComboBoxesHandles();
            List<Tag> commitTags = Helper.GetCommitsTags(cbHashesRef.Text, currentRepository);
            if (cbHashesRef.SelectedIndex == 0)
            {
                cbTagsRef.SelectedIndex = 0;
            }
            else if (commitTags.Any())
            {
                cbTagsRef.SelectedItem = commitTags[0].FriendlyName;
            }
            else
            {
                cbTagsRef.SelectedItem = noTagItemString;
            }
            if (cbHashesRef.SelectedValue != null) { cbHashesRefSelected = cbHashesRef.SelectedValue.ToString(); }

            ActivateComboBoxesHandles();
            cbSelectionUpdate();
        }

        private void cbHashesTarget_SelectedValueChanged(object sender, EventArgs e)
        {
            if (updateComboBoxesFlag == false) { return; }
            DeactivateComboBoxesHandles();
            List<Tag> commitTags = Helper.GetCommitsTags(cbHashesTarget.Text, currentRepository);
            if (cbHashesTarget.SelectedIndex == 0)
            {
                cbTagsTarget.SelectedIndex = 0;
            }
            else if (commitTags.Any())
            {
                cbTagsTarget.SelectedItem = commitTags[0].FriendlyName;
            }
            else
            {
                cbTagsTarget.SelectedItem = noTagItemString;
            }
            if (cbHashesTarget.SelectedValue != null) { cbHashesTargetSelected = cbHashesTarget.SelectedValue.ToString(); }
            ActivateComboBoxesHandles();
            cbSelectionUpdate();
        }

        private void DeactivateComboBoxesHandles()
        {
            updateComboBoxesFlag = false;
        }

        private void ActivateComboBoxesHandles()
        {
            updateComboBoxesFlag = true;
        }

        private void dgvFilesDifference_SelectionChanged(object sender, EventArgs e)
        {

            int currentRow = Helper.GetDgvFirstSelectedRowIndex(dgvFilesDifference);
            if (currentRow == dgvFilesDifferenceSelectedRowIndex) { return; }

            dgvFilesDifferenceSelectedRowIndex = currentRow;
            ClearFileCommitHistoryList();
            if (currentRow < 0) { return; }

            string filePath = GetDbvCellValue(dgvFilesDifference, "Filename", currentRow);
            string oldFilePath = GetDbvCellValue(dgvFilesDifference, "OldFilename", currentRow);
            tpFileCommitHistory.Text = fileCommitHistoryString + " for " + filePath;
            if (filePath == string.Empty) { return; }

            string refFileHash = GetDbvCellValue(dgvFilesDifference, "FileHashRef", currentRow);
            string targetFileHash = GetDbvCellValue(dgvFilesDifference, "FileHashTarget", currentRow);

            List<TreeEntry> refFileHistory = new List<TreeEntry>();
            List<TreeEntry> targetFileHistory = new List<TreeEntry>();
            List<Commit> refFileHistoryCommit = new List<Commit>();
            List<Commit> targetFileHistoryCommit = new List<Commit>();
            GetFileHistory(filePath, oldFilePath, refFileHash, targetFileHash, ref refFileHistory, ref targetFileHistory, ref refFileHistoryCommit, ref targetFileHistoryCommit);
            FillDgvFileCommitHistory(refFileHistory, targetFileHistory, refFileHistoryCommit, targetFileHistoryCommit);
            FillFileDifferences(refFileHistory, targetFileHistory);
        }

        private void cbApplyFilter_CheckedChanged(object sender, EventArgs e)
        {
            CheckApplyFilterActivation();
            if (tbFilesFilterPath.Text == "" || tbFilesFilterPath.Text == string.Empty) { return; }
            GetFilesDifference();
        }

        private void wvFileDifferences_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess) { webViewInitialised = true; }
        }

        private void cbHashesRef_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateHashComboBoxValue(cbHashesRef, ref cbHashesRefSelected);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cbHashesRef_Leave(object sender, EventArgs e)
        {
            ValidateHashComboBoxValue(cbHashesRef, ref cbHashesRefSelected);
        }

        private void cbHashesTarget_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateHashComboBoxValue(cbHashesTarget, ref cbHashesTargetSelected);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cbHashesTarget_Leave(object sender, EventArgs e)
        {
            ValidateHashComboBoxValue(cbHashesTarget, ref cbHashesTargetSelected);
        }

        private void btnExploreRefBranch_Click(object sender, EventArgs e)
        {
            ShowBranchHistoryWindow(cbBranchRef.Text, cbHashesRef.Text);
        }

        private void btnExploreTargetBranch_Click(object sender, EventArgs e)
        {
            ShowBranchHistoryWindow(cbBranchTarget.Text, cbHashesTarget.Text);
        }

        private void btnOpenFilesFilter_Click(object sender, EventArgs e)
        {
            DialogResult openFileResult = Helper.OpenFilterFile(ofdFilesListFiler);
            if (openFileResult == DialogResult.OK)
            {
                tbFilesFilterPath.Text = ofdFilesListFiler.FileName;
                ClearFilesListFilter();
                PopulateFilesListFilter();
                GetFilesDifference();
            }
        }

        private void btnReloadFilter_Click(object sender, EventArgs e)
        {
            ClearFilesListFilter();
            PopulateFilesListFilter();
            GetFilesDifference();
        }

        private void reportAnIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ExecuteUrl(Properties.Settings.Default.ReportBugUrl);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string refBranchOld = cbBranchRef.Text;
            string refTagOld = cbTagsRef.Text;
            string refHashOld = cbHashesRef.Text;
            string targetBranchOld = cbBranchTarget.Text;
            string targetTagOld = cbTagsTarget.Text;
            string targetHashOld = cbHashesTarget.Text;

            UpdateInformation();

            cbBranchRef.ChangeValue(refBranchOld);
            cbBranchTarget.ChangeValue(targetBranchOld);

            if(refTagOld == firstCbTagItemString || refTagOld == noTagItemString)
            {
                cbTagsRef.ChangeValue(refTagOld, false);
                cbHashesRef.ChangeValue(refHashOld);
            }
            else
            {
                cbTagsRef.ChangeValue(refTagOld);
            }

            if (targetTagOld == firstCbTagItemString || targetTagOld == noTagItemString)
            {
                cbTagsTarget.ChangeValue(targetTagOld, false);
                cbHashesTarget.ChangeValue(targetHashOld);
            }
            else
            {
                cbTagsTarget.ChangeValue(targetTagOld);
            }
        }
    }
}