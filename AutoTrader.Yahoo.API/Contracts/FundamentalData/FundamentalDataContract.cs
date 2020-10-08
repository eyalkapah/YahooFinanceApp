using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class FundamentalDataContract
    {
        [JsonPropertyName("quoteSummary")]
        public QuoteSummaryContract QuoteSummary { get; set; }
    }
}