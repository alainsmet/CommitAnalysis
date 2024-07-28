namespace CommitAnalysis
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            cbJIRALink.Checked = Properties.Settings.Default.JIRALink;
            cbGitHubLink.Checked = Properties.Settings.Default.GitHubLink;
            cbShowBranchLine.Checked = Properties.Settings.Default.ShowBranchLines;

            tbJIRATicketRegex.Text = Properties.Settings.Default.JIRATicketRegex;
            tbPRRegex.Text = Properties.Settings.Default.PRRegex;
            tbJIRABaseAddress.Text = Properties.Settings.Default.JIRABaseAddress;
            tbGitHubBaseAddress.Text = Properties.Settings.Default.GitHubBaseAddress;
            this.CenterToParent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.JIRATicketRegex = tbJIRATicketRegex.Text;
            Properties.Settings.Default.PRRegex = tbPRRegex.Text;
            Properties.Settings.Default.JIRABaseAddress = tbJIRABaseAddress.Text;
            Properties.Settings.Default.GitHubBaseAddress = tbGitHubBaseAddress.Text;

            Properties.Settings.Default.JIRALink = cbJIRALink.Checked;
            Properties.Settings.Default.GitHubLink = cbGitHubLink.Checked;
            Properties.Settings.Default.ShowBranchLines = cbShowBranchLine.Checked;

            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
