namespace AutoTrader.Models.Models.FundamentalData
{
    public class RevenueEstimate
    {
        public Value Avg { get; set; }

        public Value Low { get; set; }

        public Value High { get; set; }

        public Value NumberOfAnalysts { get; set; }

        public Value YearAgoRevenue { get; set; }

        public ShortenedValue Growth { get; set; }
    }
}
