using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommitAnalysis
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void llRepoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helper.ExecuteUrl(Properties.Settings.Default.RepoUrl);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
