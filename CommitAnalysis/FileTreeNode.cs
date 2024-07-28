namespace CommitAnalysis
{
    internal class FileTreeNode : TreeNode
    {
        private string _fileHash;
        private string _filePath;
        private bool _isFolder;

        public string FileHash { get { return _fileHash; } set { _fileHash = value; } }
        public string FilePath { get { return _filePath; } set { _filePath = value; } }
        public bool IsFolder { get { return _isFolder; } set { _isFolder = value; } }

        public FileTreeNode()
        {
            _fileHash = string.Empty;
            _filePath = string.Empty;
            _isFolder = false;
        }

        public FileTreeNode(string nodeName)
        {
            this.Text = nodeName;
            _fileHash = string.Empty;
            _filePath = string.Empty;
            _isFolder = false;
        }
    }
}
