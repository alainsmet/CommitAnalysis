namespace CommitAnalysis
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            btnClose = new Button();
            label1 = new Label();
            llRepoLink = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(467, 185);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 1;
            label1.Text = "Commit Analysis";
            // 
            // llRepoLink
            // 
            llRepoLink.AutoSize = true;
            llRepoLink.Location = new Point(209, 136);
            llRepoLink.Name = "llRepoLink";
            llRepoLink.Size = new Size(115, 20);
            llRepoLink.TabIndex = 2;
            llRepoLink.TabStop = true;
            llRepoLink.Text = "CommitAnalysis";
            llRepoLink.LinkClicked += llRepoLink_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 136);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 3;
            label2.Text = "Link to GitHub Repository:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 54);
            label3.Name = "label3";
            label3.Size = new Size(444, 20);
            label3.TabIndex = 3;
            label3.Text = "Small program to compare branches and commits. By Alain Smet.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 107);
            label4.Name = "label4";
            label4.Size = new Size(387, 20);
            label4.TabIndex = 3;
            label4.Text = "Currently in pre-alpha, your help or feedback is welcome!";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 235);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(llRepoLink);
            Controls.Add(label1);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutForm";
            Text = "About Commit Analysis ...";
            Load += AboutForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private LinkLabel llRepoLink;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}