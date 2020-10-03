namespace YahooFinance.Runner.Models.FundamentalData
{
    public class EpsTrend
    {
        public ShortenedValue Current { get; set; }

        public ShortenedValue _7daysAgo { get; set; }

        public ShortenedValue _30daysAgo { get; set; }

        public ShortenedValue _60daysAgo { get; set; }

        public ShortenedValue _90daysAgo { get; set; }
    }
}
