namespace CommitAnalysis
{
    partial class BranchHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchHistory));
            cbBranchesList = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            lbRepositoryPath = new Label();
            cmsDataGridView = new ContextMenuStrip(components);
            setAsReferenceCommitToolStripMenuItem = new ToolStripMenuItem();
            setAsTargetCommitToolStripMenuItem = new ToolStripMenuItem();
            dgvBranchHistory = new Zuby.ADGV.AdvancedDataGridView();
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            wvCommitInfo = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            splitContainer2 = new SplitContainer();
            tvFileTree = new TreeView();
            rtbFileInfo = new RichTextBox();
            tabPage4 = new TabPage();
            dgvFilesHashList = new Zuby.ADGV.AdvancedDataGridView();
            btnOpenFilesList = new Button();
            tbFilesListPath = new TextBox();
            label3 = new Label();
            ofdFilesListFiler = new OpenFileDialog();
            cmsDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBranchHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wvCommitInfo).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilesHashList).BeginInit();
            SuspendLayout();
            // 
            // cbBranchesList
            // 
            cbBranchesList.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBranchesList.FormattingEnabled = true;
            cbBranchesList.Location = new Point(70, 38);
            cbBranchesList.Name = "cbBranchesList";
            cbBranchesList.Size = new Size(708, 23);
            cbBranchesList.TabIndex = 0;
            cbBranchesList.SelectionChangeCommitted += cbBranchesList_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 41);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Branch :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Repository :";
            // 
            // lbRepositoryPath
            // 
            lbRepositoryPath.AutoSize = true;
            lbRepositoryPath.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbRepositoryPath.Location = new Point(89, 12);
            lbRepositoryPath.Name = "lbRepositoryPath";
            lbRepositoryPath.Size = new Size(95, 15);
            lbRepositoryPath.TabIndex = 4;
            lbRepositoryPath.Text = "Repository path";
            // 
            // cmsDataGridView
            // 
            cmsDataGridView.Items.AddRange(new ToolStripItem[] { setAsReferenceCommitToolStripMenuItem, setAsTargetCommitToolStripMenuItem });
            cmsDataGridView.Name = "cmsDataGridView";
            cmsDataGridView.Size = new Size(202, 48);
            // 
            // setAsReferenceCommitToolStripMenuItem
            // 
            setAsReferenceCommitToolStripMenuItem.Name = "setAsReferenceCommitToolStripMenuItem";
            setAsReferenceCommitToolStripMenuItem.Size = new Size(201, 22);
            setAsReferenceCommitToolStripMenuItem.Text = "Set as reference commit";
            // 
            // setAsTargetCommitToolStripMenuItem
            // 
            setAsTargetCommitToolStripMenuItem.Name = "setAsTargetCommitToolStripMenuItem";
            setAsTargetCommitToolStripMenuItem.Size = new Size(201, 22);
            setAsTargetCommitToolStripMenuItem.Text = "Set as target commit";
            // 
            // dgvBranchHistory
            // 
            dgvBranchHistory.AllowUserToAddRows = false;
            dgvBranchHistory.AllowUserToDeleteRows = false;
            dgvBranchHistory.AllowUserToOrderColumns = true;
            dgvBranchHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(229, 230, 235);
            dgvBranchHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBranchHistory.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBranchHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBranchHistory.ContextMenuStrip = cmsDataGridView;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBranchHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBranchHistory.Dock = DockStyle.Fill;
            dgvBranchHistory.FilterAndSortEnabled = true;
            dgvBranchHistory.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvBranchHistory.GridColor = SystemColors.ControlLight;
            dgvBranchHistory.Location = new Point(0, 0);
            dgvBranchHistory.MaxFilterButtonImageHeight = 23;
            dgvBranchHistory.Name = "dgvBranchHistory";
            dgvBranchHistory.ReadOnly = true;
            dgvBranchHistory.RightToLeft = RightToLeft.No;
            dgvBranchHistory.RowHeadersVisible = false;
            dgvBranchHistory.RowTemplate.Height = 25;
            dgvBranchHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBranchHistory.ShowCellErrors = false;
            dgvBranchHistory.Size = new Size(764, 290);
            dgvBranchHistory.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvBranchHistory.TabIndex = 6;
            dgvBranchHistory.CellContentClick += dgvBranchHistory_CellContentClick;
            dgvBranchHistory.CellPainting += dgvBranchHistory_CellPainting;
            dgvBranchHistory.RowPrePaint += dgvBranchHistory_RowPrePaint;
            dgvBranchHistory.SelectionChanged += dgvBranchHistory_SelectionChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(14, 67);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvBranchHistory);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(764, 512);
            splitContainer1.SplitterDistance = 290;
            splitContainer1.TabIndex = 7;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(764, 218);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(wvCommitInfo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(756, 190);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Commit info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // wvCommitInfo
            // 
            wvCommitInfo.AllowExternalDrop = true;
            wvCommitInfo.CreationProperties = null;
            wvCommitInfo.DefaultBackgroundColor = Color.White;
            wvCommitInfo.Dock = DockStyle.Fill;
            wvCommitInfo.Location = new Point(3, 3);
            wvCommitInfo.Name = "wvCommitInfo";
            wvCommitInfo.Size = new Size(750, 184);
            wvCommitInfo.TabIndex = 1;
            wvCommitInfo.ZoomFactor = 1D;
            wvCommitInfo.CoreWebView2InitializationCompleted += wvCommitInfo_CoreWebView2InitializationCompleted;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(756, 190);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Differences";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(splitContainer2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(756, 190);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "File tree";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tvFileTree);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(rtbFileInfo);
            splitContainer2.Size = new Size(750, 184);
            splitContainer2.SplitterDistance = 250;
            splitContainer2.TabIndex = 0;
            // 
            // tvFileTree
            // 
            tvFileTree.Dock = DockStyle.Fill;
            tvFileTree.Location = new Point(0, 0);
            tvFileTree.Name = "tvFileTree";
            tvFileTree.Size = new Size(250, 184);
            tvFileTree.TabIndex = 0;
            tvFileTree.NodeMouseClick += tvFileTree_NodeMouseClick;
            // 
            // rtbFileInfo
            // 
            rtbFileInfo.Dock = DockStyle.Fill;
            rtbFileInfo.Location = new Point(0, 0);
            rtbFileInfo.Name = "rtbFileInfo";
            rtbFileInfo.Size = new Size(496, 184);
            rtbFileInfo.TabIndex = 0;
            rtbFileInfo.Text = "";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvFilesHashList);
            tabPage4.Controls.Add(btnOpenFilesList);
            tabPage4.Controls.Add(tbFilesListPath);
            tabPage4.Controls.Add(label3);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(756, 190);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Files hash extractor";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvFilesHashList
            // 
            dgvFilesHashList.AllowUserToAddRows = false;
            dgvFilesHashList.AllowUserToDeleteRows = false;
            dgvFilesHashList.AllowUserToOrderColumns = true;
            dgvFilesHashList.AllowUserToResizeRows = false;
            dgvFilesHashList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFilesHashList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilesHashList.FilterAndSortEnabled = true;
            dgvFilesHashList.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvFilesHashList.Location = new Point(10, 41);
            dgvFilesHashList.MaxFilterButtonImageHeight = 23;
            dgvFilesHashList.Name = "dgvFilesHashList";
            dgvFilesHashList.ReadOnly = true;
            dgvFilesHashList.RightToLeft = RightToLeft.No;
            dgvFilesHashList.RowHeadersVisible = false;
            dgvFilesHashList.RowTemplate.Height = 25;
            dgvFilesHashList.Size = new Size(739, 143);
            dgvFilesHashList.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvFilesHashList.TabIndex = 5;
            // 
            // btnOpenFilesList
            // 
            btnOpenFilesList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenFilesList.Location = new Point(714, 8);
            btnOpenFilesList.Name = "btnOpenFilesList";
            btnOpenFilesList.Size = new Size(35, 26);
            btnOpenFilesList.TabIndex = 4;
            btnOpenFilesList.Text = "...";
            btnOpenFilesList.UseVisualStyleBackColor = true;
            btnOpenFilesList.Click += btnOpenFilesList_Click;
            // 
            // tbFilesListPath
            // 
            tbFilesListPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFilesListPath.Location = new Point(82, 10);
            tbFilesListPath.Name = "tbFilesListPath";
            tbFilesListPath.ReadOnly = true;
            tbFilesListPath.Size = new Size(626, 23);
            tbFilesListPath.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 13);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 0;
            label3.Text = "List of files :";
            // 
            // ofdFilesListFiler
            // 
            ofdFilesListFiler.FileName = "openFileDialog1";
            // 
            // BranchHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 591);
            Controls.Add(splitContainer1);
            Controls.Add(lbRepositoryPath);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbBranchesList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BranchHistory";
            Text = "Branch explorer";
            Load += BranchHistory_Load;
            cmsDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBranchHistory).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)wvCommitInfo).EndInit();
            tabPage3.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilesHashList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbBranchesList;
        private Label label1;
        private Label label2;
        private Label lbRepositoryPath;
        private ContextMenuStrip cmsDataGridView;
        private ToolStripMenuItem setAsReferenceCommitToolStripMenuItem;
        private ToolStripMenuItem setAsTargetCommitToolStripMenuItem;
        private Zuby.ADGV.AdvancedDataGridView dgvBranchHistory;
        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvCommitInfo;
        private TabPage tabPage3;
        private SplitContainer splitContainer2;
        private TreeView tvFileTree;
        private RichTextBox rtbFileInfo;
        private TabPage tabPage4;
        private Label label3;
        private TextBox tbFilesListPath;
        private Button btnOpenFilesList;
        private Zuby.ADGV.AdvancedDataGridView dgvFilesHashList;
        private OpenFileDialog ofdFilesListFiler;
    }
}