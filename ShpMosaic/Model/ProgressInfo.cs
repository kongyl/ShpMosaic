namespace ShpMosaic.Model
{
    class ProgressInfo
    {
        public int SubComplete { get; set; }
        public string SubTitle { get; set; }
        public string SubInfo { get; set; }
        public string Info { get; set; }

        public ProgressInfo() { }

        public ProgressInfo(int subComplete, string subTitle, string subInfo, string info)
        {
            SubComplete = subComplete;
            SubTitle = subTitle;
            SubInfo = subInfo;
            Info = info;
        }
    }
}
