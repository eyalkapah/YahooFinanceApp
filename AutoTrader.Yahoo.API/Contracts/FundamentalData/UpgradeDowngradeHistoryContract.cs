using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class UpgradeDowngradeHistoryContract
    {
        [JsonPropertyName("history")]
        public HistoryContract[] History { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}