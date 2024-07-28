namespace CommitAnalysis
{
    public class CommitItem
    {
        public string Hash { get; set; }
        public string Description { get; set; }
        public DateTimeOffset DateTimeOffset { get; set; }

        public CommitItem()
        {
            Hash = string.Empty;
            Description = string.Empty;
            DateTimeOffset = DateTimeOffset.MinValue;
        }

        public CommitItem(string hash, string description, DateTimeOffset dateTimeOffset)
        {
            Hash = hash;
            Description = description;
            DateTimeOffset = dateTimeOffset;
        }
    }
}
