namespace YahooFinance.Runner.Models.FundamentalData
{
    public class OwnershipList1
    {
        public int MaxAge { get; set; }

        public ShortenedValue ReportDate { get; set; }

        public string Organization { get; set; }

        public ShortenedValue PctHeld { get; set; }

        public Value Position { get; set; }

        public Value Value { get; set; }
    }
}
