namespace AutoTrader.Models.Models.FundamentalData
{
    public class MajorHoldersBreakdown
    {
        public int MaxAge { get; set; }

        public ShortenedValue InsidersPercentHeld { get; set; }

        public ShortenedValue InstitutionsPercentHeld { get; set; }

        public ShortenedValue InstitutionsFloatPercentHeld { get; set; }

        public Value InstitutionsCount { get; set; }
    }
}
