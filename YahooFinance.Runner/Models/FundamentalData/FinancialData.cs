namespace YahooFinance.Runner.Models.FundamentalData
{
    public class FinancialData
    {
        public int MaxAge { get; set; }

        public ShortenedValue CurrentPrice { get; set; }

        public ShortenedValue TargetHighPrice { get; set; }

        public ShortenedValue TargetLowPrice { get; set; }

        public ShortenedValue TargetMeanPrice { get; set; }

        public ShortenedValue TargetMedianPrice { get; set; }

        public ShortenedValue RecommendationMean { get; set; }

        public string RecommendationKey { get; set; }

        public Value NumberOfAnalystOpinions { get; set; }

        public Value TotalCash { get; set; }

        public ShortenedValue TotalCashPerShare { get; set; }

        public Value Ebitda { get; set; }

        public Value TotalDebt { get; set; }

        public Value TotalRevenue { get; set; }
        
        public ShortenedValue QuickRatio { get; set; }

        public ShortenedValue CurrentRatio { get; set; }

        public ShortenedValue DebtToEquity { get; set; }

        public ShortenedValue RevenuePerShare { get; set; }

        public ShortenedValue ReturnOnAssets { get; set; }

        public ShortenedValue ReturnOnEquity { get; set; }

        public Value GrossProfits { get; set; }

        public Value FreeCashflow { get; set; }

        public Value OperatingCashflow { get; set; }

        public ShortenedValue EarningsGrowth { get; set; }

        public ShortenedValue RevenueGrowth { get; set; }

        public ShortenedValue GrossMargins { get; set; }

        public ShortenedValue EbitdaMargins { get; set; }

        public ShortenedValue OperatingMargins { get; set; }

        public ShortenedValue ProfitMargins { get; set; }

        public string FinancialCurrency { get; set; }
    }
}
