namespace ShpMosaic.Model
{
    class ProgressInfo
    {
        public int SubComplete { get; set; }
        public string SubInfo { get; set; }
        public string Info { get; set; }

        public ProgressInfo() { }

        public ProgressInfo(int subComplete, string subInfo, string info)
        {
            SubComplete = subComplete;
            SubInfo = subInfo;
            Info = info;
        }
    }
}
