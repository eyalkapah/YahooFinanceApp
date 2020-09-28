using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class UpgradeDowngradeHistoryContract
    {
        [JsonPropertyName("history")]
        public HistoryContract[] History { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}