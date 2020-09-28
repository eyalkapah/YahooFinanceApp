using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class YearlyContract
    {
        [JsonPropertyName("date")]
        public int Date { get; set; }

        [JsonPropertyName("revenue")]
        public ValueContract Revenue { get; set; }

        [JsonPropertyName("earnings")]
        public ValueContract Earnings { get; set; }
    }
}