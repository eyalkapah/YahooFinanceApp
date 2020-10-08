namespace YahooFinance.Runner.Models.FundamentalData
{
    public class Trend1
    {
        public int MaxAge { get; set; }

        public string Period { get; set; }

        public string EndDate { get; set; }

        public ShortenedValue Growth { get; set; }

        public EarningsEstimate EarningsEstimate { get; set; }

        public RevenueEstimate RevenueEstimate { get; set; }

        public EpsTrend EpsTrend { get; set; }

        public EpsRevisions EpsRevisions { get; set; }
    }
}
