using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.HistoricalData
{
    public class DividendContract
    {
        [JsonPropertyName("amount")]
        public float Amount { get; set; }

        [JsonPropertyName("date")]
        public long Date { get; set; }
    }
}
