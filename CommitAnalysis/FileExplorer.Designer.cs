namespace CommitAnalysis
{
    partial class FileExplorer
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
            lbRepositoryPath = new Label();
            label2 = new Label();
            label1 = new Label();
            cbBranchesList = new ComboBox();
            SuspendLayout();
            // 
            // lbRepositoryPath
            // 
            lbRepositoryPath.AutoSize = true;
            lbRepositoryPath.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbRepositoryPath.Location = new Point(84, 10);
            lbRepositoryPath.Name = "lbRepositoryPath";
            lbRepositoryPath.Size = new Size(95, 15);
            lbRepositoryPath.TabIndex = 8;
            lbRepositoryPath.Text = "Repository path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 10);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 7;
            label2.Text = "Repository :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 39);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 6;
            label1.Text = "Branch :";
            // 
            // cbBranchesList
            // 
            cbBranchesList.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBranchesList.FormattingEnabled = true;
            cbBranchesList.Location = new Point(65, 36);
            cbBranchesList.Name = "cbBranchesList";
            cbBranchesList.Size = new Size(603, 23);
            cbBranchesList.TabIndex = 5;
            // 
            // FileExplorer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 482);
            Controls.Add(lbRepositoryPath);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbBranchesList);
            Name = "FileExplorer";
            Text = "Commit file explorer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbRepositoryPath;
        private Label label2;
        private Label label1;
        private ComboBox cbBranchesList;
    }
}