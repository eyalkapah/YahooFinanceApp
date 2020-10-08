namespace AutoTrader.Models.Models.FundamentalData
{
    public class EarningsEstimate
    {
        public ShortenedValue Avg { get; set; }

        public ShortenedValue Low { get; set; }

        public ShortenedValue High { get; set; }

        public ShortenedValue YearAgoEps { get; set; }

        public Value NumberOfAnalysts { get; set; }

        public ShortenedValue Growth { get; set; }
    }
}
