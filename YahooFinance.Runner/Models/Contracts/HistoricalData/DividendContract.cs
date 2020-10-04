using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.HistoricalData
{
    public class DividendContract
    {
        [JsonPropertyName("amount")]
        public float Amount { get; set; }

        [JsonPropertyName("date")]
        public long Date { get; set; }
    }
}
