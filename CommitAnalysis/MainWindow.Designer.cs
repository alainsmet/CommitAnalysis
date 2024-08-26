namespace CommitAnalysis
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            refreshRepositorygitPullToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            analysisToolStripMenuItem = new ToolStripMenuItem();
            getUniqueListOfTicketsToolStripMenuItem = new ToolStripMenuItem();
            showBranchHistoryToolStripMenuItem = new ToolStripMenuItem();
            seeGitSubrepositoriesToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            reportAnIssueToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            tbRepositoryPath = new TextBox();
            btnRepositoryPath = new Button();
            label1 = new Label();
            cbBranchRef = new ComboBox();
            cbBranchTarget = new ComboBox();
            fbdDialog = new FolderBrowserDialog();
            splitContainer1 = new SplitContainer();
            dgvFilesDifference = new Zuby.ADGV.AdvancedDataGridView();
            tcFileInfo = new TabControl();
            tpFileCommitHistory = new TabPage();
            dgvFileCommitHistory = new DataGridView();
            FileHistoryHashRef = new DataGridViewTextBoxColumn();
            CommitDateRef = new DataGridViewTextBoxColumn();
            RefCommitName = new DataGridViewLinkColumn();
            FileHistoryHashTarget = new DataGridViewTextBoxColumn();
            CommitDateTarget = new DataGridViewTextBoxColumn();
            TargetCommitName = new DataGridViewLinkColumn();
            tabPage2 = new TabPage();
            wvFileDifferences = new Microsoft.Web.WebView2.WinForms.WebView2();
            statusStrip1 = new StatusStrip();
            lbStatusMessage = new ToolStripStatusLabel();
            cbTagsRef = new ComboBox();
            cbTagsTarget = new ComboBox();
            gbReference = new GroupBox();
            btnExploreRefBranch = new Button();
            cbHashesRef = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            gbTarget = new GroupBox();
            btnExploreTargetBranch = new Button();
            cbHashesTarget = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            splitContainer2 = new SplitContainer();
            btnRefresh = new Button();
            ttMainWindow = new ToolTip(components);
            btnOpenFilesFilter = new Button();
            btnReloadFilter = new Button();
            cbApplyFilter = new CheckBox();
            tbFilesFilterPath = new TextBox();
            ofdFilesListFiler = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilesDifference).BeginInit();
            tcFileInfo.SuspendLayout();
            tpFileCommitHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFileCommitHistory).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wvFileDifferences).BeginInit();
            statusStrip1.SuspendLayout();
            gbReference.SuspendLayout();
            gbTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, analysisToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1015, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshRepositorygitPullToolStripMenuItem, settingsToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // refreshRepositorygitPullToolStripMenuItem
            // 
            refreshRepositorygitPullToolStripMenuItem.Name = "refreshRepositorygitPullToolStripMenuItem";
            refreshRepositorygitPullToolStripMenuItem.Size = new Size(286, 26);
            refreshRepositorygitPullToolStripMenuItem.Text = "Refresh repository (git pull) ...";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(286, 26);
            settingsToolStripMenuItem.Text = "Settings ...";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(283, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(286, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // analysisToolStripMenuItem
            // 
            analysisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getUniqueListOfTicketsToolStripMenuItem, showBranchHistoryToolStripMenuItem, seeGitSubrepositoriesToolStripMenuItem });
            analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            analysisToolStripMenuItem.Size = new Size(76, 24);
            analysisToolStripMenuItem.Text = "&Analysis";
            // 
            // getUniqueListOfTicketsToolStripMenuItem
            // 
            getUniqueListOfTicketsToolStripMenuItem.Name = "getUniqueListOfTicketsToolStripMenuItem";
            getUniqueListOfTicketsToolStripMenuItem.Size = new Size(257, 26);
            getUniqueListOfTicketsToolStripMenuItem.Text = "Perform full comparison";
            getUniqueListOfTicketsToolStripMenuItem.Click += getUniqueListOfTicketsToolStripMenuItem_Click;
            // 
            // showBranchHistoryToolStripMenuItem
            // 
            showBranchHistoryToolStripMenuItem.Name = "showBranchHistoryToolStripMenuItem";
            showBranchHistoryToolStripMenuItem.Size = new Size(257, 26);
            showBranchHistoryToolStripMenuItem.Text = "Branch explorer ...";
            showBranchHistoryToolStripMenuItem.Click += showBranchHistoryToolStripMenuItem_Click;
            // 
            // seeGitSubrepositoriesToolStripMenuItem
            // 
            seeGitSubrepositoriesToolStripMenuItem.Name = "seeGitSubrepositoriesToolStripMenuItem";
            seeGitSubrepositoriesToolStripMenuItem.Size = new Size(257, 26);
            seeGitSubrepositoriesToolStripMenuItem.Text = "See Git subrepositories ...";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportAnIssueToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // reportAnIssueToolStripMenuItem
            // 
            reportAnIssueToolStripMenuItem.Name = "reportAnIssueToolStripMenuItem";
            reportAnIssueToolStripMenuItem.Size = new Size(224, 26);
            reportAnIssueToolStripMenuItem.Text = "Report an issue";
            reportAnIssueToolStripMenuItem.Click += reportAnIssueToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // tbRepositoryPath
            // 
            tbRepositoryPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbRepositoryPath.Location = new Point(141, 51);
            tbRepositoryPath.Margin = new Padding(3, 4, 3, 4);
            tbRepositoryPath.Name = "tbRepositoryPath";
            tbRepositoryPath.ReadOnly = true;
            tbRepositoryPath.Size = new Size(767, 27);
            tbRepositoryPath.TabIndex = 2;
            // 
            // btnRepositoryPath
            // 
            btnRepositoryPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRepositoryPath.Location = new Point(913, 48);
            btnRepositoryPath.Margin = new Padding(3, 4, 3, 4);
            btnRepositoryPath.Name = "btnRepositoryPath";
            btnRepositoryPath.Size = new Size(40, 35);
            btnRepositoryPath.TabIndex = 3;
            btnRepositoryPath.Text = "...";
            ttMainWindow.SetToolTip(btnRepositoryPath, "Open a repository");
            btnRepositoryPath.UseVisualStyleBackColor = true;
            btnRepositoryPath.Click += btnRepositoryPath_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 55);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 4;
            label1.Text = "Repository path :";
            // 
            // cbBranchRef
            // 
            cbBranchRef.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbBranchRef.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBranchRef.FormattingEnabled = true;
            cbBranchRef.Location = new Point(64, 29);
            cbBranchRef.Margin = new Padding(3, 4, 3, 4);
            cbBranchRef.Name = "cbBranchRef";
            cbBranchRef.Size = new Size(417, 28);
            cbBranchRef.TabIndex = 5;
            cbBranchRef.SelectionChangeCommitted += cbBranchRef_SelectionChangeCommitted;
            // 
            // cbBranchTarget
            // 
            cbBranchTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbBranchTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBranchTarget.FormattingEnabled = true;
            cbBranchTarget.Location = new Point(64, 29);
            cbBranchTarget.Margin = new Padding(3, 4, 3, 4);
            cbBranchTarget.Name = "cbBranchTarget";
            cbBranchTarget.Size = new Size(422, 28);
            cbBranchTarget.TabIndex = 6;
            cbBranchTarget.SelectionChangeCommitted += cbBranchTarget_SelectionChangeCommitted;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(14, 319);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvFilesDifference);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tcFileInfo);
            splitContainer1.Size = new Size(987, 500);
            splitContainer1.SplitterDistance = 272;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 11;
            // 
            // dgvFilesDifference
            // 
            dgvFilesDifference.AllowUserToAddRows = false;
            dgvFilesDifference.AllowUserToDeleteRows = false;
            dgvFilesDifference.AllowUserToOrderColumns = true;
            dgvFilesDifference.AllowUserToResizeRows = false;
            dgvFilesDifference.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilesDifference.Dock = DockStyle.Fill;
            dgvFilesDifference.FilterAndSortEnabled = true;
            dgvFilesDifference.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvFilesDifference.Location = new Point(0, 0);
            dgvFilesDifference.Margin = new Padding(3, 4, 3, 4);
            dgvFilesDifference.MaxFilterButtonImageHeight = 23;
            dgvFilesDifference.Name = "dgvFilesDifference";
            dgvFilesDifference.ReadOnly = true;
            dgvFilesDifference.RightToLeft = RightToLeft.No;
            dgvFilesDifference.RowHeadersVisible = false;
            dgvFilesDifference.RowHeadersWidth = 51;
            dgvFilesDifference.RowTemplate.Height = 25;
            dgvFilesDifference.Size = new Size(987, 272);
            dgvFilesDifference.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvFilesDifference.TabIndex = 10;
            dgvFilesDifference.RowPrePaint += dgvFilesDifference_RowPrePaint;
            dgvFilesDifference.SelectionChanged += dgvFilesDifference_SelectionChanged;
            // 
            // tcFileInfo
            // 
            tcFileInfo.Controls.Add(tpFileCommitHistory);
            tcFileInfo.Controls.Add(tabPage2);
            tcFileInfo.Dock = DockStyle.Fill;
            tcFileInfo.Location = new Point(0, 0);
            tcFileInfo.Margin = new Padding(3, 4, 3, 4);
            tcFileInfo.Name = "tcFileInfo";
            tcFileInfo.SelectedIndex = 0;
            tcFileInfo.Size = new Size(987, 223);
            tcFileInfo.TabIndex = 1;
            // 
            // tpFileCommitHistory
            // 
            tpFileCommitHistory.Controls.Add(dgvFileCommitHistory);
            tpFileCommitHistory.Location = new Point(4, 29);
            tpFileCommitHistory.Margin = new Padding(3, 4, 3, 4);
            tpFileCommitHistory.Name = "tpFileCommitHistory";
            tpFileCommitHistory.Padding = new Padding(3, 4, 3, 4);
            tpFileCommitHistory.Size = new Size(979, 190);
            tpFileCommitHistory.TabIndex = 0;
            tpFileCommitHistory.Text = "File commit history";
            tpFileCommitHistory.UseVisualStyleBackColor = true;
            // 
            // dgvFileCommitHistory
            // 
            dgvFileCommitHistory.AllowUserToAddRows = false;
            dgvFileCommitHistory.AllowUserToDeleteRows = false;
            dgvFileCommitHistory.AllowUserToOrderColumns = true;
            dgvFileCommitHistory.AllowUserToResizeRows = false;
            dgvFileCommitHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFileCommitHistory.Columns.AddRange(new DataGridViewColumn[] { FileHistoryHashRef, CommitDateRef, RefCommitName, FileHistoryHashTarget, CommitDateTarget, TargetCommitName });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvFileCommitHistory.DefaultCellStyle = dataGridViewCellStyle5;
            dgvFileCommitHistory.Dock = DockStyle.Fill;
            dgvFileCommitHistory.Location = new Point(3, 4);
            dgvFileCommitHistory.Margin = new Padding(3, 4, 3, 4);
            dgvFileCommitHistory.Name = "dgvFileCommitHistory";
            dgvFileCommitHistory.ReadOnly = true;
            dgvFileCommitHistory.RowHeadersVisible = false;
            dgvFileCommitHistory.RowHeadersWidth = 51;
            dgvFileCommitHistory.RowTemplate.Height = 25;
            dgvFileCommitHistory.Size = new Size(973, 182);
            dgvFileCommitHistory.TabIndex = 0;
            dgvFileCommitHistory.CellContentClick += dgvFileCommitHistory_CellContentClick;
            // 
            // FileHistoryHashRef
            // 
            dataGridViewCellStyle1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FileHistoryHashRef.DefaultCellStyle = dataGridViewCellStyle1;
            FileHistoryHashRef.HeaderText = "File hashes for reference branch";
            FileHistoryHashRef.MinimumWidth = 6;
            FileHistoryHashRef.Name = "FileHistoryHashRef";
            FileHistoryHashRef.ReadOnly = true;
            FileHistoryHashRef.Width = 300;
            // 
            // CommitDateRef
            // 
            CommitDateRef.HeaderText = "Commit date";
            CommitDateRef.MinimumWidth = 6;
            CommitDateRef.Name = "CommitDateRef";
            CommitDateRef.ReadOnly = true;
            CommitDateRef.Width = 125;
            // 
            // RefCommitName
            // 
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            RefCommitName.DefaultCellStyle = dataGridViewCellStyle2;
            RefCommitName.HeaderText = "Commit name for reference branch";
            RefCommitName.MinimumWidth = 6;
            RefCommitName.Name = "RefCommitName";
            RefCommitName.ReadOnly = true;
            RefCommitName.Width = 125;
            // 
            // FileHistoryHashTarget
            // 
            dataGridViewCellStyle3.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FileHistoryHashTarget.DefaultCellStyle = dataGridViewCellStyle3;
            FileHistoryHashTarget.HeaderText = "File hashes for target branch";
            FileHistoryHashTarget.MinimumWidth = 6;
            FileHistoryHashTarget.Name = "FileHistoryHashTarget";
            FileHistoryHashTarget.ReadOnly = true;
            FileHistoryHashTarget.Width = 300;
            // 
            // CommitDateTarget
            // 
            CommitDateTarget.HeaderText = "Commit date";
            CommitDateTarget.MinimumWidth = 6;
            CommitDateTarget.Name = "CommitDateTarget";
            CommitDateTarget.ReadOnly = true;
            CommitDateTarget.Width = 125;
            // 
            // TargetCommitName
            // 
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            TargetCommitName.DefaultCellStyle = dataGridViewCellStyle4;
            TargetCommitName.HeaderText = "Commit name for target branch";
            TargetCommitName.MinimumWidth = 6;
            TargetCommitName.Name = "TargetCommitName";
            TargetCommitName.ReadOnly = true;
            TargetCommitName.Width = 125;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(wvFileDifferences);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(979, 190);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Differences";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // wvFileDifferences
            // 
            wvFileDifferences.AllowExternalDrop = true;
            wvFileDifferences.CreationProperties = null;
            wvFileDifferences.DefaultBackgroundColor = Color.White;
            wvFileDifferences.Dock = DockStyle.Fill;
            wvFileDifferences.Location = new Point(3, 4);
            wvFileDifferences.Margin = new Padding(3, 4, 3, 4);
            wvFileDifferences.Name = "wvFileDifferences";
            wvFileDifferences.Size = new Size(973, 182);
            wvFileDifferences.TabIndex = 1;
            wvFileDifferences.ZoomFactor = 1D;
            wvFileDifferences.CoreWebView2InitializationCompleted += wvFileDifferences_CoreWebView2InitializationCompleted;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbStatusMessage });
            statusStrip1.Location = new Point(0, 838);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1015, 26);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbStatusMessage
            // 
            lbStatusMessage.Name = "lbStatusMessage";
            lbStatusMessage.Size = new Size(151, 20);
            lbStatusMessage.Text = "toolStripStatusLabel1";
            // 
            // cbTagsRef
            // 
            cbTagsRef.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbTagsRef.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTagsRef.FormattingEnabled = true;
            cbTagsRef.Location = new Point(64, 68);
            cbTagsRef.Margin = new Padding(3, 4, 3, 4);
            cbTagsRef.Name = "cbTagsRef";
            cbTagsRef.Size = new Size(417, 28);
            cbTagsRef.TabIndex = 13;
            cbTagsRef.SelectionChangeCommitted += cbTagsRef_SelectionChangeCommitted;
            // 
            // cbTagsTarget
            // 
            cbTagsTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbTagsTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTagsTarget.FormattingEnabled = true;
            cbTagsTarget.Location = new Point(64, 68);
            cbTagsTarget.Margin = new Padding(3, 4, 3, 4);
            cbTagsTarget.Name = "cbTagsTarget";
            cbTagsTarget.Size = new Size(422, 28);
            cbTagsTarget.TabIndex = 13;
            cbTagsTarget.SelectionChangeCommitted += cbTagsTarget_SelectionChangeCommitted;
            // 
            // gbReference
            // 
            gbReference.Controls.Add(btnExploreRefBranch);
            gbReference.Controls.Add(cbHashesRef);
            gbReference.Controls.Add(label4);
            gbReference.Controls.Add(label3);
            gbReference.Controls.Add(label2);
            gbReference.Controls.Add(cbBranchRef);
            gbReference.Controls.Add(cbTagsRef);
            gbReference.Dock = DockStyle.Fill;
            gbReference.Location = new Point(0, 0);
            gbReference.Margin = new Padding(3, 4, 3, 4);
            gbReference.Name = "gbReference";
            gbReference.Padding = new Padding(3, 4, 3, 4);
            gbReference.Size = new Size(488, 165);
            gbReference.TabIndex = 14;
            gbReference.TabStop = false;
            gbReference.Text = "Reference commit";
            // 
            // btnExploreRefBranch
            // 
            btnExploreRefBranch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExploreRefBranch.Location = new Point(441, 107);
            btnExploreRefBranch.Margin = new Padding(3, 4, 3, 4);
            btnExploreRefBranch.Name = "btnExploreRefBranch";
            btnExploreRefBranch.Size = new Size(40, 35);
            btnExploreRefBranch.TabIndex = 16;
            btnExploreRefBranch.Text = "...";
            ttMainWindow.SetToolTip(btnExploreRefBranch, "Explore reference branch");
            btnExploreRefBranch.UseVisualStyleBackColor = true;
            btnExploreRefBranch.Click += btnExploreRefBranch_Click;
            // 
            // cbHashesRef
            // 
            cbHashesRef.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbHashesRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbHashesRef.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbHashesRef.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbHashesRef.FormattingEnabled = true;
            cbHashesRef.Location = new Point(64, 109);
            cbHashesRef.Margin = new Padding(3, 4, 3, 4);
            cbHashesRef.Name = "cbHashesRef";
            cbHashesRef.Size = new Size(370, 27);
            cbHashesRef.TabIndex = 15;
            cbHashesRef.SelectedValueChanged += cbHashesRef_SelectedValueChanged;
            cbHashesRef.KeyDown += cbHashesRef_KeyDown;
            cbHashesRef.Leave += cbHashesRef_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 113);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 14;
            label4.Text = "Hash";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 72);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 14;
            label3.Text = "Tag";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 35);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 14;
            label2.Text = "Branch";
            // 
            // gbTarget
            // 
            gbTarget.Controls.Add(btnExploreTargetBranch);
            gbTarget.Controls.Add(cbHashesTarget);
            gbTarget.Controls.Add(cbBranchTarget);
            gbTarget.Controls.Add(label7);
            gbTarget.Controls.Add(cbTagsTarget);
            gbTarget.Controls.Add(label6);
            gbTarget.Controls.Add(label5);
            gbTarget.Dock = DockStyle.Fill;
            gbTarget.Location = new Point(0, 0);
            gbTarget.Margin = new Padding(3, 4, 3, 4);
            gbTarget.Name = "gbTarget";
            gbTarget.Padding = new Padding(3, 4, 3, 4);
            gbTarget.Size = new Size(494, 165);
            gbTarget.TabIndex = 15;
            gbTarget.TabStop = false;
            gbTarget.Text = "Target commit";
            // 
            // btnExploreTargetBranch
            // 
            btnExploreTargetBranch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExploreTargetBranch.Location = new Point(447, 107);
            btnExploreTargetBranch.Margin = new Padding(3, 4, 3, 4);
            btnExploreTargetBranch.Name = "btnExploreTargetBranch";
            btnExploreTargetBranch.Size = new Size(40, 35);
            btnExploreTargetBranch.TabIndex = 16;
            btnExploreTargetBranch.Text = "...";
            ttMainWindow.SetToolTip(btnExploreTargetBranch, "Explore target branch");
            btnExploreTargetBranch.UseVisualStyleBackColor = true;
            btnExploreTargetBranch.Click += btnExploreTargetBranch_Click;
            // 
            // cbHashesTarget
            // 
            cbHashesTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbHashesTarget.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbHashesTarget.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbHashesTarget.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbHashesTarget.FormattingEnabled = true;
            cbHashesTarget.Location = new Point(64, 109);
            cbHashesTarget.Margin = new Padding(3, 4, 3, 4);
            cbHashesTarget.Name = "cbHashesTarget";
            cbHashesTarget.Size = new Size(375, 27);
            cbHashesTarget.TabIndex = 15;
            cbHashesTarget.SelectedValueChanged += cbHashesTarget_SelectedValueChanged;
            cbHashesTarget.KeyDown += cbHashesTarget_KeyDown;
            cbHashesTarget.Leave += cbHashesTarget_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 113);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 14;
            label7.Text = "Hash";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 72);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 14;
            label6.Text = "Tag";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 35);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 14;
            label5.Text = "Branch";
            // 
            // splitContainer2
            // 
            splitContainer2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer2.Location = new Point(14, 105);
            splitContainer2.Margin = new Padding(3, 4, 3, 4);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(gbReference);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(gbTarget);
            splitContainer2.Size = new Size(987, 165);
            splitContainer2.SplitterDistance = 488;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 16;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Image = Properties.Resources.icons8_synchroniser_25;
            btnRefresh.Location = new Point(957, 48);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(45, 35);
            btnRefresh.TabIndex = 3;
            ttMainWindow.SetToolTip(btnRefresh, "Refresh the repository");
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRepositoryPath_Click;
            // 
            // btnOpenFilesFilter
            // 
            btnOpenFilesFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenFilesFilter.Location = new Point(913, 276);
            btnOpenFilesFilter.Margin = new Padding(3, 4, 3, 4);
            btnOpenFilesFilter.Name = "btnOpenFilesFilter";
            btnOpenFilesFilter.Size = new Size(40, 35);
            btnOpenFilesFilter.TabIndex = 20;
            btnOpenFilesFilter.Text = "...";
            ttMainWindow.SetToolTip(btnOpenFilesFilter, "Open a repository");
            btnOpenFilesFilter.UseVisualStyleBackColor = true;
            btnOpenFilesFilter.Click += btnOpenFilesFilter_Click;
            // 
            // btnReloadFilter
            // 
            btnReloadFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReloadFilter.Image = Properties.Resources.icons8_synchroniser_25;
            btnReloadFilter.Location = new Point(958, 276);
            btnReloadFilter.Margin = new Padding(3, 4, 3, 4);
            btnReloadFilter.Name = "btnReloadFilter";
            btnReloadFilter.Size = new Size(45, 35);
            btnReloadFilter.TabIndex = 21;
            ttMainWindow.SetToolTip(btnReloadFilter, "Reload filter file");
            btnReloadFilter.UseVisualStyleBackColor = true;
            btnReloadFilter.Click += btnReloadFilter_Click;
            // 
            // cbApplyFilter
            // 
            cbApplyFilter.AutoSize = true;
            cbApplyFilter.Location = new Point(14, 281);
            cbApplyFilter.Margin = new Padding(3, 4, 3, 4);
            cbApplyFilter.Name = "cbApplyFilter";
            cbApplyFilter.Size = new Size(124, 24);
            cbApplyFilter.TabIndex = 18;
            cbApplyFilter.Text = "Apply a filter :";
            cbApplyFilter.UseVisualStyleBackColor = true;
            cbApplyFilter.CheckedChanged += cbApplyFilter_CheckedChanged;
            // 
            // tbFilesFilterPath
            // 
            tbFilesFilterPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFilesFilterPath.Location = new Point(130, 279);
            tbFilesFilterPath.Margin = new Padding(3, 4, 3, 4);
            tbFilesFilterPath.Name = "tbFilesFilterPath";
            tbFilesFilterPath.ReadOnly = true;
            tbFilesFilterPath.Size = new Size(778, 27);
            tbFilesFilterPath.TabIndex = 19;
            // 
            // ofdFilesListFiler
            // 
            ofdFilesListFiler.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 864);
            Controls.Add(btnReloadFilter);
            Controls.Add(btnOpenFilesFilter);
            Controls.Add(tbFilesFilterPath);
            Controls.Add(cbApplyFilter);
            Controls.Add(splitContainer2);
            Controls.Add(statusStrip1);
            Controls.Add(splitContainer1);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnRepositoryPath);
            Controls.Add(tbRepositoryPath);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainWindow";
            Text = "Commit Analysis";
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFilesDifference).EndInit();
            tcFileInfo.ResumeLayout(false);
            tpFileCommitHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFileCommitHistory).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)wvFileDifferences).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            gbReference.ResumeLayout(false);
            gbReference.PerformLayout();
            gbTarget.ResumeLayout(false);
            gbTarget.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox tbRepositoryPath;
        private Button btnRepositoryPath;
        private Label label1;
        private ComboBox cbBranchRef;
        private ComboBox cbBranchTarget;
        private FolderBrowserDialog fbdDialog;
        // private DataGridView dgvFilesDifference;
        private SplitContainer splitContainer1;
        private DataGridView dgvFileCommitHistory;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem analysisToolStripMenuItem;
        private ToolStripMenuItem getUniqueListOfTicketsToolStripMenuItem;
        private ToolStripMenuItem showBranchHistoryToolStripMenuItem;
        private ComboBox cbTagsRef;
        private ComboBox cbTagsTarget;
        private ToolStripStatusLabel lbStatusMessage;
        private DataGridViewTextBoxColumn FileHistoryHashRef;
        private DataGridViewTextBoxColumn CommitDateRef;
        private DataGridViewLinkColumn RefCommitName;
        private DataGridViewTextBoxColumn FileHistoryHashTarget;
        private DataGridViewTextBoxColumn CommitDateTarget;
        private DataGridViewLinkColumn TargetCommitName;
        private GroupBox gbReference;
        private GroupBox gbTarget;
        private SplitContainer splitContainer2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private ToolStripMenuItem refreshRepositorygitPullToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Button btnRefresh;
        private Zuby.ADGV.AdvancedDataGridView dgvFilesDifference;
        private TabControl tcFileInfo;
        private TabPage tpFileCommitHistory;
        private TabPage tabPage2;
        private ComboBox cbHashesRef;
        private ComboBox cbHashesTarget;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Button btnExploreRefBranch;
        private Button btnExploreTargetBranch;
        private ToolTip ttMainWindow;
        private CheckBox cbApplyFilter;
        private TextBox tbFilesFilterPath;
        private Button btnOpenFilesFilter;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvFileDifferences;
        private ToolStripMenuItem seeGitSubrepositoriesToolStripMenuItem;
        private OpenFileDialog ofdFilesListFiler;
        private Button btnReloadFilter;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem reportAnIssueToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}