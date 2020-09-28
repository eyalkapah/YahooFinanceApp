using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class FundamentalDataContract
    {
        [JsonPropertyName("quoteSummary")]
        public QuoteSummaryContract QuoteSummary { get; set; }
    }
}