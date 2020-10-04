namespace YahooFinance.Runner.Models.FundamentalData
{
    public class Transaction
    {
        public int MaxAge { get; set; }

        public Value Shares { get; set; }

        public Value Value { get; set; }

        public string FilerUrl { get; set; }

        public string TransactionText { get; set; }

        public string FilerName { get; set; }

        public string FilerRelation { get; set; }

        public string MoneyText { get; set; }

        public ShortenedValue StartDate { get; set; }

        public string Ownership { get; set; }
    }
}
