namespace YahooFinance.Runner.Models.FundamentalData
{
    public class Earnings1
    {
        public int MaxAge { get; set; }

        public EarningsChart EarningsChart { get; set; }

        public FinancialsChart FinancialsChart { get; set; }

        public string FinancialCurrency { get; set; }
    }
}
