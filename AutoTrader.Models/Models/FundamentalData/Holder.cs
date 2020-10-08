namespace AutoTrader.Models.Models.FundamentalData
{
    public class Holder
    {
        public int MaxAge { get; set; }

        public string Name { get; set; }

        public string Relation { get; set; }

        public string Url { get; set; }

        public string TransactionDescription { get; set; }

        public ShortenedValue LatestTransDate { get; set; }

        public Value PositionDirect { get; set; }

        public ShortenedValue PositionDirectDate { get; set; }
    }
}
