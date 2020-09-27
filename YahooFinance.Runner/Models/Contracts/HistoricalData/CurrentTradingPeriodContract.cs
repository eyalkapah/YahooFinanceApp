using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.HistoricalData
{
    public class CurrentTradingPeriodContract
    {
        [JsonPropertyName("pre")]
        public TradingPeriodContract Pre { get; set; }

        [JsonPropertyName("regular")]
        public TradingPeriodContract Regular { get; set; }

        [JsonPropertyName("post")]
        public TradingPeriodContract Post { get; set; }
    }
}