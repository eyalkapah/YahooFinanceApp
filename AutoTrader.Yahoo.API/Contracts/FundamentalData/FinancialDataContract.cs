using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class FinancialDataContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("currentPrice")]
        public ShortenedValueContract CurrentPrice { get; set; }

        [JsonPropertyName("targetHighPrice")]
        public ShortenedValueContract TargetHighPrice { get; set; }

        [JsonPropertyName("targetLowPrice")]
        public ShortenedValueContract TargetLowPrice { get; set; }

        [JsonPropertyName("targetMeanPrice")]
        public ShortenedValueContract TargetMeanPrice { get; set; }

        [JsonPropertyName("targetMedianPrice")]
        public ShortenedValueContract TargetMedianPrice { get; set; }

        [JsonPropertyName("recommendationMean")]
        public ShortenedValueContract RecommendationMean { get; set; }

        [JsonPropertyName("recommendationKey")]
        public string RecommendationKey { get; set; }

        [JsonPropertyName("numberOfAnalystOpinions")]
        public ValueContract NumberOfAnalystOpinions { get; set; }

        [JsonPropertyName("totalCash")]
        public ValueContract TotalCash { get; set; }

        [JsonPropertyName("totalCashPerShare")]
        public ShortenedValueContract TotalCashPerShare { get; set; }

        [JsonPropertyName("ebitda")]
        public ValueContract Ebitda { get; set; }

        [JsonPropertyName("totalDebt")]
        public ValueContract TotalDebt { get; set; }

        [JsonPropertyName("quickRatio")]
        public ShortenedValueContract QuickRatio { get; set; }

        [JsonPropertyName("currentRatio")]
        public ShortenedValueContract CurrentRatio { get; set; }

        [JsonPropertyName("totalRevenue")]
        public ValueContract TotalRevenue { get; set; }

        [JsonPropertyName("debtToEquity")]
        public ShortenedValueContract DebtToEquity { get; set; }

        [JsonPropertyName("revenuePerShare")]
        public ShortenedValueContract RevenuePerShare { get; set; }

        [JsonPropertyName("returnOnAssets")]
        public ShortenedValueContract ReturnOnAssets { get; set; }

        [JsonPropertyName("returnOnEquity")]
        public ShortenedValueContract ReturnOnEquity { get; set; }

        [JsonPropertyName("grossProfits")]
        public ValueContract GrossProfits { get; set; }

        [JsonPropertyName("freeCashflow")]
        public ValueContract FreeCashflow { get; set; }

        [JsonPropertyName("operatingCashflow")]
        public ValueContract OperatingCashflow { get; set; }

        [JsonPropertyName("earningsGrowth")]
        public ShortenedValueContract EarningsGrowth { get; set; }

        [JsonPropertyName("revenueGrowth")]
        public ShortenedValueContract RevenueGrowth { get; set; }

        [JsonPropertyName("grossMargins")]
        public ShortenedValueContract GrossMargins { get; set; }

        [JsonPropertyName("ebitdaMargins")]
        public ShortenedValueContract EbitdaMargins { get; set; }

        [JsonPropertyName("operatingMargins")]
        public ShortenedValueContract OperatingMargins { get; set; }

        [JsonPropertyName("profitMargins")]
        public ShortenedValueContract ProfitMargins { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string FinancialCurrency { get; set; }
    }
}