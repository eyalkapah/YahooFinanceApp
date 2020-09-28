using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class Earnings1Contract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("earningsChart")]
        public EarningsChartContract EarningsChart { get; set; }

        [JsonPropertyName("financialsChart")]
        public FinancialsChartContract FinancialsChart { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string FinancialCurrency { get; set; }
    }
}