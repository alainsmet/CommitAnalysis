namespace CommitAnalysis
{
    partial class Analysis
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analysis));
            tabControl4 = new TabControl();
            tabPage5 = new TabPage();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            dgvUniqueTicketsRef = new DataGridView();
            refTicketsName = new DataGridViewLinkColumn();
            refImpactedFiles = new DataGridViewTextBoxColumn();
            button2 = new Button();
            tbJIRAFilterRef = new TextBox();
            label4 = new Label();
            tvTicketsRef = new TreeView();
            tabPage3 = new TabPage();
            dgvFileTicketsRef = new DataGridView();
            refFilename = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            splitContainer2 = new SplitContainer();
            dgvUniqueTicketsTarget = new DataGridView();
            targetTicketsName = new DataGridViewLinkColumn();
            targetImpactedFiles = new DataGridViewTextBoxColumn();
            button1 = new Button();
            tbJIRAFilterTarget = new TextBox();
            label3 = new Label();
            tvTicketsTarget = new TreeView();
            tabPage4 = new TabPage();
            dgvFileTicketsTarget = new DataGridView();
            targetFilename = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            lbRefBranch = new Label();
            lbTargetBranch = new Label();
            tabControl4.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUniqueTicketsRef).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFileTicketsRef).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUniqueTicketsTarget).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFileTicketsTarget).BeginInit();
            SuspendLayout();
            // 
            // tabControl4
            // 
            tabControl4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl4.Controls.Add(tabPage5);
            tabControl4.Controls.Add(tabPage1);
            tabControl4.Controls.Add(tabPage3);
            tabControl4.Controls.Add(tabPage2);
            tabControl4.Controls.Add(tabPage4);
            tabControl4.Location = new Point(12, 83);
            tabControl4.Name = "tabControl4";
            tabControl4.SelectedIndex = 0;
            tabControl4.Size = new Size(976, 505);
            tabControl4.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(968, 477);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Files differences";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(968, 477);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Unique tickets ref";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvUniqueTicketsRef);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(tbJIRAFilterRef);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(tvTicketsRef);
            splitContainer1.Size = new Size(962, 471);
            splitContainer1.SplitterDistance = 320;
            splitContainer1.TabIndex = 1;
            // 
            // dgvUniqueTicketsRef
            // 
            dgvUniqueTicketsRef.AllowUserToAddRows = false;
            dgvUniqueTicketsRef.AllowUserToDeleteRows = false;
            dgvUniqueTicketsRef.AllowUserToResizeRows = false;
            dgvUniqueTicketsRef.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUniqueTicketsRef.Columns.AddRange(new DataGridViewColumn[] { refTicketsName, refImpactedFiles });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUniqueTicketsRef.DefaultCellStyle = dataGridViewCellStyle1;
            dgvUniqueTicketsRef.Dock = DockStyle.Fill;
            dgvUniqueTicketsRef.Location = new Point(0, 0);
            dgvUniqueTicketsRef.Name = "dgvUniqueTicketsRef";
            dgvUniqueTicketsRef.ReadOnly = true;
            dgvUniqueTicketsRef.RowHeadersVisible = false;
            dgvUniqueTicketsRef.RowTemplate.Height = 25;
            dgvUniqueTicketsRef.Size = new Size(320, 471);
            dgvUniqueTicketsRef.TabIndex = 0;
            dgvUniqueTicketsRef.CellContentClick += dgv_CellContentClick;
            // 
            // refTicketsName
            // 
            refTicketsName.HeaderText = "Ticket name";
            refTicketsName.Name = "refTicketsName";
            refTicketsName.ReadOnly = true;
            refTicketsName.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // refImpactedFiles
            // 
            refImpactedFiles.HeaderText = "Impacted files";
            refImpactedFiles.Name = "refImpactedFiles";
            refImpactedFiles.ReadOnly = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(597, 12);
            button2.Name = "button2";
            button2.Size = new Size(36, 25);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            // 
            // tbJIRAFilterRef
            // 
            tbJIRAFilterRef.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbJIRAFilterRef.Location = new Point(108, 13);
            tbJIRAFilterRef.Name = "tbJIRAFilterRef";
            tbJIRAFilterRef.Size = new Size(486, 23);
            tbJIRAFilterRef.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 4;
            label4.Text = "JIRA tickets filter :";
            // 
            // tvTicketsRef
            // 
            tvTicketsRef.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tvTicketsRef.Location = new Point(0, 47);
            tvTicketsRef.Name = "tvTicketsRef";
            tvTicketsRef.Size = new Size(638, 424);
            tvTicketsRef.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvFileTicketsRef);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(968, 477);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Tickets by file ref";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvFileTicketsRef
            // 
            dgvFileTicketsRef.AllowUserToAddRows = false;
            dgvFileTicketsRef.AllowUserToDeleteRows = false;
            dgvFileTicketsRef.AllowUserToResizeRows = false;
            dgvFileTicketsRef.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFileTicketsRef.Columns.AddRange(new DataGridViewColumn[] { refFilename });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFileTicketsRef.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFileTicketsRef.Dock = DockStyle.Fill;
            dgvFileTicketsRef.Location = new Point(0, 0);
            dgvFileTicketsRef.Name = "dgvFileTicketsRef";
            dgvFileTicketsRef.ReadOnly = true;
            dgvFileTicketsRef.RowHeadersVisible = false;
            dgvFileTicketsRef.RowTemplate.Height = 25;
            dgvFileTicketsRef.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFileTicketsRef.Size = new Size(968, 477);
            dgvFileTicketsRef.TabIndex = 0;
            dgvFileTicketsRef.CellContentClick += dgv_CellContentClick;
            // 
            // refFilename
            // 
            refFilename.HeaderText = "File";
            refFilename.Name = "refFilename";
            refFilename.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(968, 477);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Unique tickets target";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dgvUniqueTicketsTarget);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button1);
            splitContainer2.Panel2.Controls.Add(tbJIRAFilterTarget);
            splitContainer2.Panel2.Controls.Add(label3);
            splitContainer2.Panel2.Controls.Add(tvTicketsTarget);
            splitContainer2.Size = new Size(962, 471);
            splitContainer2.SplitterDistance = 320;
            splitContainer2.TabIndex = 1;
            // 
            // dgvUniqueTicketsTarget
            // 
            dgvUniqueTicketsTarget.AllowUserToAddRows = false;
            dgvUniqueTicketsTarget.AllowUserToDeleteRows = false;
            dgvUniqueTicketsTarget.AllowUserToResizeRows = false;
            dgvUniqueTicketsTarget.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUniqueTicketsTarget.Columns.AddRange(new DataGridViewColumn[] { targetTicketsName, targetImpactedFiles });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUniqueTicketsTarget.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUniqueTicketsTarget.Dock = DockStyle.Fill;
            dgvUniqueTicketsTarget.Location = new Point(0, 0);
            dgvUniqueTicketsTarget.Name = "dgvUniqueTicketsTarget";
            dgvUniqueTicketsTarget.ReadOnly = true;
            dgvUniqueTicketsTarget.RowHeadersVisible = false;
            dgvUniqueTicketsTarget.RowTemplate.Height = 25;
            dgvUniqueTicketsTarget.Size = new Size(320, 471);
            dgvUniqueTicketsTarget.TabIndex = 0;
            dgvUniqueTicketsTarget.CellContentClick += dgv_CellContentClick;
            // 
            // targetTicketsName
            // 
            targetTicketsName.HeaderText = "Ticket name";
            targetTicketsName.Name = "targetTicketsName";
            targetTicketsName.ReadOnly = true;
            targetTicketsName.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // targetImpactedFiles
            // 
            targetImpactedFiles.HeaderText = "Impacted files";
            targetImpactedFiles.Name = "targetImpactedFiles";
            targetImpactedFiles.ReadOnly = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(597, 12);
            button1.Name = "button1";
            button1.Size = new Size(36, 25);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // tbJIRAFilterTarget
            // 
            tbJIRAFilterTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbJIRAFilterTarget.Location = new Point(108, 13);
            tbJIRAFilterTarget.Name = "tbJIRAFilterTarget";
            tbJIRAFilterTarget.Size = new Size(486, 23);
            tbJIRAFilterTarget.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 1;
            label3.Text = "JIRA tickets filter :";
            // 
            // tvTicketsTarget
            // 
            tvTicketsTarget.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tvTicketsTarget.Location = new Point(0, 47);
            tvTicketsTarget.Name = "tvTicketsTarget";
            tvTicketsTarget.Size = new Size(638, 424);
            tvTicketsTarget.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvFileTicketsTarget);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(968, 477);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Tickets by file target";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvFileTicketsTarget
            // 
            dgvFileTicketsTarget.AllowUserToAddRows = false;
            dgvFileTicketsTarget.AllowUserToDeleteRows = false;
            dgvFileTicketsTarget.AllowUserToResizeRows = false;
            dgvFileTicketsTarget.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFileTicketsTarget.Columns.AddRange(new DataGridViewColumn[] { targetFilename });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvFileTicketsTarget.DefaultCellStyle = dataGridViewCellStyle4;
            dgvFileTicketsTarget.Dock = DockStyle.Fill;
            dgvFileTicketsTarget.Location = new Point(0, 0);
            dgvFileTicketsTarget.Name = "dgvFileTicketsTarget";
            dgvFileTicketsTarget.ReadOnly = true;
            dgvFileTicketsTarget.RowHeadersVisible = false;
            dgvFileTicketsTarget.RowTemplate.Height = 25;
            dgvFileTicketsTarget.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFileTicketsTarget.Size = new Size(968, 477);
            dgvFileTicketsTarget.TabIndex = 0;
            dgvFileTicketsTarget.CellContentClick += dgv_CellContentClick;
            // 
            // targetFilename
            // 
            targetFilename.HeaderText = "File";
            targetFilename.Name = "targetFilename";
            targetFilename.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Reference :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Target :";
            // 
            // lbRefBranch
            // 
            lbRefBranch.AutoSize = true;
            lbRefBranch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbRefBranch.Location = new Point(83, 23);
            lbRefBranch.Name = "lbRefBranch";
            lbRefBranch.Size = new Size(107, 15);
            lbRefBranch.TabIndex = 2;
            lbRefBranch.Text = "Reference branch";
            // 
            // lbTargetBranch
            // 
            lbTargetBranch.AutoSize = true;
            lbTargetBranch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTargetBranch.Location = new Point(83, 48);
            lbTargetBranch.Name = "lbTargetBranch";
            lbTargetBranch.Size = new Size(84, 15);
            lbTargetBranch.TabIndex = 2;
            lbTargetBranch.Text = "Target branch";
            // 
            // Analysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(lbTargetBranch);
            Controls.Add(lbRefBranch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tabControl4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Analysis";
            Text = "Analysis dashboard";
            Load += Analysis_Load;
            tabControl4.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUniqueTicketsRef).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFileTicketsRef).EndInit();
            tabPage2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUniqueTicketsTarget).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFileTicketsTarget).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvUniqueTicketsRef;
        private TabPage tabPage3;
        private DataGridView dgvFileTicketsRef;
        private DataGridView dgvUniqueTicketsTarget;
        private TabPage tabPage4;
        private DataGridView dataGridView4;
        private DataGridViewLinkColumn refTicketsName;
        private DataGridViewTextBoxColumn refImpactedFiles;
        private DataGridViewTextBoxColumn refFilename;
        private DataGridViewLinkColumn targetTicketsName;
        private DataGridViewTextBoxColumn targetImpactedFiles;
        private DataGridViewTextBoxColumn targetFilename;
        private TabControl tabControl4;
        private DataGridView dgvFileTicketsTarget;
        private SplitContainer splitContainer1;
        private TreeView tvTicketsRef;
        private SplitContainer splitContainer2;
        private TreeView tvTicketsTarget;
        private Label label1;
        private Label label2;
        private Label lbRefBranch;
        private Label lbTargetBranch;
        private TabPage tabPage5;
        private Label label3;
        private Button button1;
        private TextBox tbJIRAFilterTarget;
        private Button button2;
        private TextBox tbJIRAFilterRef;
        private Label label4;
    }
}