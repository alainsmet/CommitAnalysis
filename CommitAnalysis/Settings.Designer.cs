namespace CommitAnalysis
{
    partial class Settings
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
            label1 = new Label();
            btnSave = new Button();
            tbJIRATicketRegex = new TextBox();
            tbPRRegex = new TextBox();
            label2 = new Label();
            tbJIRABaseAddress = new TextBox();
            label3 = new Label();
            tbGitHubBaseAddress = new TextBox();
            label4 = new Label();
            cbJIRALink = new CheckBox();
            cbGitHubLink = new CheckBox();
            cbShowBranchLine = new CheckBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 49);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "JIRA Ticket Regex :";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(812, 418);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbJIRATicketRegex
            // 
            tbJIRATicketRegex.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbJIRATicketRegex.Location = new Point(130, 46);
            tbJIRATicketRegex.Name = "tbJIRATicketRegex";
            tbJIRATicketRegex.Size = new Size(757, 23);
            tbJIRATicketRegex.TabIndex = 2;
            // 
            // tbPRRegex
            // 
            tbPRRegex.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPRRegex.Location = new Point(130, 155);
            tbPRRegex.Name = "tbPRRegex";
            tbPRRegex.Size = new Size(757, 23);
            tbPRRegex.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 158);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 3;
            label2.Text = "Pull Request Regex :";
            // 
            // tbJIRABaseAddress
            // 
            tbJIRABaseAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbJIRABaseAddress.Location = new Point(130, 75);
            tbJIRABaseAddress.Name = "tbJIRABaseAddress";
            tbJIRABaseAddress.Size = new Size(757, 23);
            tbJIRABaseAddress.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 78);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 5;
            label3.Text = "JIRA Address :";
            // 
            // tbGitHubBaseAddress
            // 
            tbGitHubBaseAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbGitHubBaseAddress.Location = new Point(130, 184);
            tbGitHubBaseAddress.Name = "tbGitHubBaseAddress";
            tbGitHubBaseAddress.Size = new Size(757, 23);
            tbGitHubBaseAddress.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 187);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 7;
            label4.Text = "GitHub Address :";
            // 
            // cbJIRALink
            // 
            cbJIRALink.AutoSize = true;
            cbJIRALink.Location = new Point(12, 12);
            cbJIRALink.Name = "cbJIRALink";
            cbJIRALink.Size = new Size(142, 19);
            cbJIRALink.TabIndex = 9;
            cbJIRALink.Text = "Activate link with JIRA";
            cbJIRALink.UseVisualStyleBackColor = true;
            // 
            // cbGitHubLink
            // 
            cbGitHubLink.AutoSize = true;
            cbGitHubLink.Location = new Point(12, 125);
            cbGitHubLink.Name = "cbGitHubLink";
            cbGitHubLink.Size = new Size(158, 19);
            cbGitHubLink.TabIndex = 9;
            cbGitHubLink.Text = "Activate link with GitHub";
            cbGitHubLink.UseVisualStyleBackColor = true;
            // 
            // cbShowBranchLine
            // 
            cbShowBranchLine.AutoSize = true;
            cbShowBranchLine.Location = new Point(11, 237);
            cbShowBranchLine.Name = "cbShowBranchLine";
            cbShowBranchLine.Size = new Size(122, 19);
            cbShowBranchLine.TabIndex = 9;
            cbShowBranchLine.Text = "Show branch lines";
            cbShowBranchLine.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(224, 237);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(663, 175);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(655, 147);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 453);
            Controls.Add(tabControl1);
            Controls.Add(cbGitHubLink);
            Controls.Add(cbShowBranchLine);
            Controls.Add(cbJIRALink);
            Controls.Add(tbGitHubBaseAddress);
            Controls.Add(label4);
            Controls.Add(tbJIRABaseAddress);
            Controls.Add(label3);
            Controls.Add(tbPRRegex);
            Controls.Add(label2);
            Controls.Add(tbJIRATicketRegex);
            Controls.Add(btnSave);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private TextBox tbJIRATicketRegex;
        private TextBox tbPRRegex;
        private Label label2;
        private TextBox tbJIRABaseAddress;
        private Label label3;
        private TextBox tbGitHubBaseAddress;
        private Label label4;
        private CheckBox cbJIRALink;
        private CheckBox cbGitHubLink;
        private CheckBox cbShowBranchLine;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}