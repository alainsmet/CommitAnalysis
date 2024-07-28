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
            cbApplyFilter = new CheckBox();
            tbFilesFilterPath = new TextBox();
            ofdFilesListFiler = new OpenFileDialog();
            btnReloadFilter = new Button();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, analysisToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(888, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshRepositorygitPullToolStripMenuItem, settingsToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // refreshRepositorygitPullToolStripMenuItem
            // 
            refreshRepositorygitPullToolStripMenuItem.Name = "refreshRepositorygitPullToolStripMenuItem";
            refreshRepositorygitPullToolStripMenuItem.Size = new Size(229, 22);
            refreshRepositorygitPullToolStripMenuItem.Text = "Refresh repository (git pull) ...";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(229, 22);
            settingsToolStripMenuItem.Text = "Settings ...";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(226, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(229, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // analysisToolStripMenuItem
            // 
            analysisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getUniqueListOfTicketsToolStripMenuItem, showBranchHistoryToolStripMenuItem, seeGitSubrepositoriesToolStripMenuItem });
            analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            analysisToolStripMenuItem.Size = new Size(62, 20);
            analysisToolStripMenuItem.Text = "&Analysis";
            // 
            // getUniqueListOfTicketsToolStripMenuItem
            // 
            getUniqueListOfTicketsToolStripMenuItem.Name = "getUniqueListOfTicketsToolStripMenuItem";
            getUniqueListOfTicketsToolStripMenuItem.Size = new Size(205, 22);
            getUniqueListOfTicketsToolStripMenuItem.Text = "Perform full comparison";
            getUniqueListOfTicketsToolStripMenuItem.Click += getUniqueListOfTicketsToolStripMenuItem_Click;
            // 
            // showBranchHistoryToolStripMenuItem
            // 
            showBranchHistoryToolStripMenuItem.Name = "showBranchHistoryToolStripMenuItem";
            showBranchHistoryToolStripMenuItem.Size = new Size(205, 22);
            showBranchHistoryToolStripMenuItem.Text = "Branch explorer ...";
            showBranchHistoryToolStripMenuItem.Click += showBranchHistoryToolStripMenuItem_Click;
            // 
            // seeGitSubrepositoriesToolStripMenuItem
            // 
            seeGitSubrepositoriesToolStripMenuItem.Name = "seeGitSubrepositoriesToolStripMenuItem";
            seeGitSubrepositoriesToolStripMenuItem.Size = new Size(205, 22);
            seeGitSubrepositoriesToolStripMenuItem.Text = "See Git subrepositories ...";
            // 
            // tbRepositoryPath
            // 
            tbRepositoryPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbRepositoryPath.Location = new Point(123, 38);
            tbRepositoryPath.Name = "tbRepositoryPath";
            tbRepositoryPath.ReadOnly = true;
            tbRepositoryPath.Size = new Size(672, 23);
            tbRepositoryPath.TabIndex = 2;
            // 
            // btnRepositoryPath
            // 
            btnRepositoryPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRepositoryPath.Location = new Point(799, 36);
            btnRepositoryPath.Name = "btnRepositoryPath";
            btnRepositoryPath.Size = new Size(35, 26);
            btnRepositoryPath.TabIndex = 3;
            btnRepositoryPath.Text = "...";
            ttMainWindow.SetToolTip(btnRepositoryPath, "Open a repository");
            btnRepositoryPath.UseVisualStyleBackColor = true;
            btnRepositoryPath.Click += btnRepositoryPath_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 4;
            label1.Text = "Repository path :";
            // 
            // cbBranchRef
            // 
            cbBranchRef.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbBranchRef.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBranchRef.FormattingEnabled = true;
            cbBranchRef.Location = new Point(56, 22);
            cbBranchRef.Name = "cbBranchRef";
            cbBranchRef.Size = new Size(366, 23);
            cbBranchRef.TabIndex = 5;
            cbBranchRef.SelectionChangeCommitted += cbBranchRef_SelectionChangeCommitted;
            // 
            // cbBranchTarget
            // 
            cbBranchTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbBranchTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBranchTarget.FormattingEnabled = true;
            cbBranchTarget.Location = new Point(56, 22);
            cbBranchTarget.Name = "cbBranchTarget";
            cbBranchTarget.Size = new Size(370, 23);
            cbBranchTarget.TabIndex = 6;
            cbBranchTarget.SelectionChangeCommitted += cbBranchTarget_SelectionChangeCommitted;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(12, 239);
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
            splitContainer1.Size = new Size(864, 375);
            splitContainer1.SplitterDistance = 204;
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
            dgvFilesDifference.MaxFilterButtonImageHeight = 23;
            dgvFilesDifference.Name = "dgvFilesDifference";
            dgvFilesDifference.ReadOnly = true;
            dgvFilesDifference.RightToLeft = RightToLeft.No;
            dgvFilesDifference.RowHeadersVisible = false;
            dgvFilesDifference.RowTemplate.Height = 25;
            dgvFilesDifference.Size = new Size(864, 204);
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
            tcFileInfo.Name = "tcFileInfo";
            tcFileInfo.SelectedIndex = 0;
            tcFileInfo.Size = new Size(864, 167);
            tcFileInfo.TabIndex = 1;
            // 
            // tpFileCommitHistory
            // 
            tpFileCommitHistory.Controls.Add(dgvFileCommitHistory);
            tpFileCommitHistory.Location = new Point(4, 24);
            tpFileCommitHistory.Name = "tpFileCommitHistory";
            tpFileCommitHistory.Padding = new Padding(3);
            tpFileCommitHistory.Size = new Size(856, 139);
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
            dgvFileCommitHistory.Location = new Point(3, 3);
            dgvFileCommitHistory.Name = "dgvFileCommitHistory";
            dgvFileCommitHistory.ReadOnly = true;
            dgvFileCommitHistory.RowHeadersVisible = false;
            dgvFileCommitHistory.RowTemplate.Height = 25;
            dgvFileCommitHistory.Size = new Size(850, 133);
            dgvFileCommitHistory.TabIndex = 0;
            dgvFileCommitHistory.CellContentClick += dgvFileCommitHistory_CellContentClick;
            // 
            // FileHistoryHashRef
            // 
            dataGridViewCellStyle1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FileHistoryHashRef.DefaultCellStyle = dataGridViewCellStyle1;
            FileHistoryHashRef.HeaderText = "File hashes for reference branch";
            FileHistoryHashRef.Name = "FileHistoryHashRef";
            FileHistoryHashRef.ReadOnly = true;
            FileHistoryHashRef.Width = 300;
            // 
            // CommitDateRef
            // 
            CommitDateRef.HeaderText = "Commit date";
            CommitDateRef.Name = "CommitDateRef";
            CommitDateRef.ReadOnly = true;
            // 
            // RefCommitName
            // 
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            RefCommitName.DefaultCellStyle = dataGridViewCellStyle2;
            RefCommitName.HeaderText = "Commit name for reference branch";
            RefCommitName.Name = "RefCommitName";
            RefCommitName.ReadOnly = true;
            // 
            // FileHistoryHashTarget
            // 
            dataGridViewCellStyle3.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FileHistoryHashTarget.DefaultCellStyle = dataGridViewCellStyle3;
            FileHistoryHashTarget.HeaderText = "File hashes for target branch";
            FileHistoryHashTarget.Name = "FileHistoryHashTarget";
            FileHistoryHashTarget.ReadOnly = true;
            FileHistoryHashTarget.Width = 300;
            // 
            // CommitDateTarget
            // 
            CommitDateTarget.HeaderText = "Commit date";
            CommitDateTarget.Name = "CommitDateTarget";
            CommitDateTarget.ReadOnly = true;
            // 
            // TargetCommitName
            // 
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            TargetCommitName.DefaultCellStyle = dataGridViewCellStyle4;
            TargetCommitName.HeaderText = "Commit name for target branch";
            TargetCommitName.Name = "TargetCommitName";
            TargetCommitName.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(wvFileDifferences);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(856, 139);
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
            wvFileDifferences.Location = new Point(3, 3);
            wvFileDifferences.Name = "wvFileDifferences";
            wvFileDifferences.Size = new Size(850, 133);
            wvFileDifferences.TabIndex = 1;
            wvFileDifferences.ZoomFactor = 1D;
            wvFileDifferences.CoreWebView2InitializationCompleted += wvFileDifferences_CoreWebView2InitializationCompleted;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbStatusMessage });
            statusStrip1.Location = new Point(0, 626);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(888, 22);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbStatusMessage
            // 
            lbStatusMessage.Name = "lbStatusMessage";
            lbStatusMessage.Size = new Size(118, 17);
            lbStatusMessage.Text = "toolStripStatusLabel1";
            // 
            // cbTagsRef
            // 
            cbTagsRef.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbTagsRef.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTagsRef.FormattingEnabled = true;
            cbTagsRef.Location = new Point(56, 51);
            cbTagsRef.Name = "cbTagsRef";
            cbTagsRef.Size = new Size(366, 23);
            cbTagsRef.TabIndex = 13;
            cbTagsRef.SelectionChangeCommitted += cbTagsRef_SelectionChangeCommitted;
            // 
            // cbTagsTarget
            // 
            cbTagsTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbTagsTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTagsTarget.FormattingEnabled = true;
            cbTagsTarget.Location = new Point(56, 51);
            cbTagsTarget.Name = "cbTagsTarget";
            cbTagsTarget.Size = new Size(370, 23);
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
            gbReference.Name = "gbReference";
            gbReference.Size = new Size(428, 124);
            gbReference.TabIndex = 14;
            gbReference.TabStop = false;
            gbReference.Text = "Reference commit";
            // 
            // btnExploreRefBranch
            // 
            btnExploreRefBranch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExploreRefBranch.Location = new Point(387, 80);
            btnExploreRefBranch.Name = "btnExploreRefBranch";
            btnExploreRefBranch.Size = new Size(35, 26);
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
            cbHashesRef.Location = new Point(56, 82);
            cbHashesRef.Name = "cbHashesRef";
            cbHashesRef.Size = new Size(325, 23);
            cbHashesRef.TabIndex = 15;
            cbHashesRef.SelectedValueChanged += cbHashesRef_SelectedValueChanged;
            cbHashesRef.KeyDown += cbHashesRef_KeyDown;
            cbHashesRef.Leave += cbHashesRef_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 85);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 14;
            label4.Text = "Hash";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 14;
            label3.Text = "Tag";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 26);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
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
            gbTarget.Name = "gbTarget";
            gbTarget.Size = new Size(432, 124);
            gbTarget.TabIndex = 15;
            gbTarget.TabStop = false;
            gbTarget.Text = "Target commit";
            // 
            // btnExploreTargetBranch
            // 
            btnExploreTargetBranch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExploreTargetBranch.Location = new Point(391, 80);
            btnExploreTargetBranch.Name = "btnExploreTargetBranch";
            btnExploreTargetBranch.Size = new Size(35, 26);
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
            cbHashesTarget.Location = new Point(56, 82);
            cbHashesTarget.Name = "cbHashesTarget";
            cbHashesTarget.Size = new Size(329, 23);
            cbHashesTarget.TabIndex = 15;
            cbHashesTarget.SelectedValueChanged += cbHashesTarget_SelectedValueChanged;
            cbHashesTarget.KeyDown += cbHashesTarget_KeyDown;
            cbHashesTarget.Leave += cbHashesTarget_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 85);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 14;
            label7.Text = "Hash";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 54);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 14;
            label6.Text = "Tag";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 26);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 14;
            label5.Text = "Branch";
            // 
            // splitContainer2
            // 
            splitContainer2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer2.Location = new Point(12, 79);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(gbReference);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(gbTarget);
            splitContainer2.Size = new Size(864, 124);
            splitContainer2.SplitterDistance = 428;
            splitContainer2.TabIndex = 16;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Image = Properties.Resources.icons8_synchroniser_25;
            btnRefresh.Location = new Point(837, 36);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(39, 26);
            btnRefresh.TabIndex = 3;
            ttMainWindow.SetToolTip(btnRefresh, "Refresh the repository");
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRepositoryPath_Click;
            // 
            // btnOpenFilesFilter
            // 
            btnOpenFilesFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenFilesFilter.Location = new Point(799, 207);
            btnOpenFilesFilter.Name = "btnOpenFilesFilter";
            btnOpenFilesFilter.Size = new Size(35, 26);
            btnOpenFilesFilter.TabIndex = 20;
            btnOpenFilesFilter.Text = "...";
            ttMainWindow.SetToolTip(btnOpenFilesFilter, "Open a repository");
            btnOpenFilesFilter.UseVisualStyleBackColor = true;
            btnOpenFilesFilter.Click += btnOpenFilesFilter_Click;
            // 
            // cbApplyFilter
            // 
            cbApplyFilter.AutoSize = true;
            cbApplyFilter.Location = new Point(12, 211);
            cbApplyFilter.Name = "cbApplyFilter";
            cbApplyFilter.Size = new Size(99, 19);
            cbApplyFilter.TabIndex = 18;
            cbApplyFilter.Text = "Apply a filter :";
            cbApplyFilter.UseVisualStyleBackColor = true;
            cbApplyFilter.CheckedChanged += cbApplyFilter_CheckedChanged;
            // 
            // tbFilesFilterPath
            // 
            tbFilesFilterPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFilesFilterPath.Location = new Point(114, 209);
            tbFilesFilterPath.Name = "tbFilesFilterPath";
            tbFilesFilterPath.ReadOnly = true;
            tbFilesFilterPath.Size = new Size(681, 23);
            tbFilesFilterPath.TabIndex = 19;
            // 
            // ofdFilesListFiler
            // 
            ofdFilesListFiler.FileName = "openFileDialog1";
            // 
            // btnReloadFilter
            // 
            btnReloadFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReloadFilter.Image = Properties.Resources.icons8_synchroniser_25;
            btnReloadFilter.Location = new Point(838, 207);
            btnReloadFilter.Name = "btnReloadFilter";
            btnReloadFilter.Size = new Size(39, 26);
            btnReloadFilter.TabIndex = 21;
            ttMainWindow.SetToolTip(btnReloadFilter, "Reload filter file");
            btnReloadFilter.UseVisualStyleBackColor = true;
            btnReloadFilter.Click += btnReloadFilter_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 648);
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
    }
}