namespace YahooFinance.Runner.Models.FundamentalData
{
    public class EpsRevisions
    {
        public Value UpLast7days { get; set; }

        public Value UpLast30days { get; set; }

        public Value DownLast30days { get; set; }

        public DownLast90days DownLast90days { get; set; }
    }
}
