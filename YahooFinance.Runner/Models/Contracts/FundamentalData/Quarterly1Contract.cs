using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class Quarterly1Contract
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("revenue")]
        public ValueContract Revenue { get; set; }

        [JsonPropertyName("earnings")]
        public ValueContract Earnings { get; set; }
    }
}