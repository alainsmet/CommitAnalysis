namespace CommitAnalysis
{
    public partial class Analysis : Form
    {
        public Analysis()
        {
            InitializeComponent();
        }

        public void PopulateBranchesNames(string refBranch, string targetBranch)
        {
            lbRefBranch.Text = refBranch;
            lbTargetBranch.Text = targetBranch;
        }

        public void PopulateJIRAFilters(Dictionary<string, List<string>> refTickets, Dictionary<string, List<string>> targetTickets)
        {
            tbJIRAFilterRef.Text = Helper.GenerateJIRAFilter(refTickets);
            tbJIRAFilterTarget.Text = Helper.GenerateJIRAFilter(targetTickets);
        }

        public void PopulateAnalysisDataGridViews(Dictionary<string, List<string>> refTickets, Dictionary<string, List<string>> targetTickets, Dictionary<string, List<string>> refFilesTickets, Dictionary<string, List<string>> targetFilesTickets)
        {
            foreach (var ticket in refTickets)
            {
                int currentRowIndex = dgvUniqueTicketsRef.Rows.Add(ticket.Key, ticket.Value.Count());
                dgvUniqueTicketsRef.Rows[currentRowIndex].Cells["refTicketsName"].ToolTipText = Properties.Settings.Default.JIRABaseAddress.ToString() + ticket.Key;
                AddFileTreeNode(tvTicketsRef, ticket);
            }

            int currentNumberOfColumns = 0;

            foreach (var file in refFilesTickets)
            {
                int currentRowIndex = dgvFileTicketsRef.Rows.Add();
                dgvFileTicketsRef.Rows[currentRowIndex].Cells["refFilename"].Value = file.Key;
                List<string> tickets = file.Value;

                if (tickets.Count > currentNumberOfColumns)
                {
                    for (int i = 0; i < (tickets.Count - currentNumberOfColumns); i++)
                    {
                        DataGridViewLinkColumn column = new DataGridViewLinkColumn();
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                        dgvFileTicketsRef.Columns.Add(column);
                    }

                    currentNumberOfColumns = tickets.Count;
                }

                for (int i = 0; i < tickets.Count; i++)
                {
                    dgvFileTicketsRef.Rows[currentRowIndex].Cells[i + 1].Value = tickets[i];
                    dgvFileTicketsRef.Rows[currentRowIndex].Cells[i + 1].ToolTipText = Properties.Settings.Default.JIRABaseAddress.ToString() + tickets[i];
                }
            }

            foreach (var ticket in targetTickets)
            {
                int currentRowIndex = dgvUniqueTicketsTarget.Rows.Add(ticket.Key, ticket.Value.Count());
                dgvUniqueTicketsTarget.Rows[currentRowIndex].Cells["targetTicketsName"].ToolTipText = Properties.Settings.Default.JIRABaseAddress.ToString() + ticket.Key;
                AddFileTreeNode(tvTicketsTarget, ticket);
            }

            currentNumberOfColumns = 0;

            foreach (var file in targetFilesTickets)
            {
                int currentRowIndex = dgvFileTicketsTarget.Rows.Add();
                dgvFileTicketsTarget.Rows[currentRowIndex].Cells["targetFilename"].Value = file.Key;
                List<string> tickets = file.Value;

                if (tickets.Count > currentNumberOfColumns)
                {
                    for (int i = 0; i < (tickets.Count - currentNumberOfColumns); i++)
                    {
                        DataGridViewLinkColumn column = new DataGridViewLinkColumn();
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                        dgvFileTicketsTarget.Columns.Add(column);
                    }

                    currentNumberOfColumns = tickets.Count;
                }

                for (int i = 0; i < tickets.Count; i++)
                {
                    dgvFileTicketsTarget.Rows[currentRowIndex].Cells[i + 1].Value = tickets[i];
                    dgvFileTicketsTarget.Rows[currentRowIndex].Cells[i + 1].ToolTipText = Properties.Settings.Default.JIRABaseAddress.ToString() + tickets[i];
                }
            }
        }

        private void AddFileTreeNode(TreeView targetTreeview, KeyValuePair<string, List<string>> ticket)
        {
            TreeNode mainTicket = new TreeNode(ticket.Key + " (" + ticket.Value.Count() + ")");
            mainTicket.Tag = ticket;

            foreach (string file in ticket.Value)
            {
                TreeNode fileNode = new TreeNode(file);
                fileNode.Tag = file;
                mainTicket.Nodes.Add(fileNode);
            }
            targetTreeview.Nodes.Add(mainTicket);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }
            DataGridView targetDgv = sender as DataGridView;
            if (targetDgv == null) { return; }
            if (targetDgv[e.ColumnIndex, e.RowIndex] is not DataGridViewLinkCell linkCell) { return; }

            string url = linkCell.ToolTipText.ToString();
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
