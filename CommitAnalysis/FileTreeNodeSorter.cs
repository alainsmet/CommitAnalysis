namespace CommitAnalysis
{
    internal class FileTreeNodeSorter : System.Collections.IComparer
    {
        public FileTreeNodeSorter() { }

        public int Compare(Object? x, Object? y)
        {

            if (x == null || y == null) return 0;

            FileTreeNode nodeX = x as FileTreeNode;
            FileTreeNode nodeY = y as FileTreeNode;

            if ((nodeX.IsFolder == true && nodeY.IsFolder == true) || (nodeX.IsFolder == false && nodeY.IsFolder == false))
            {
                return string.Compare(nodeX.Text, nodeY.Text);
            }
            if (nodeX.IsFolder == true && nodeY.IsFolder == false)
            {
                return -1;
            }
            if (nodeX.IsFolder == false && nodeY.IsFolder == true)
            {
                return 1;
            }

            return 0;
        }
    }
}
