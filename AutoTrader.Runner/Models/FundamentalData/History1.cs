namespace YahooFinance.Runner.Models.FundamentalData
{
    public class History1
    {
        public int MaxAge { get; set; }

        public ShortenedValue EpsActual { get; set; }

        public ShortenedValue EpsEstimate { get; set; }

        public ShortenedValue EpsDifference { get; set; }

        public ShortenedValue SurprisePercent { get; set; }

        public ShortenedValue Quarter { get; set; }

        public string Period { get; set; }
    }
}
