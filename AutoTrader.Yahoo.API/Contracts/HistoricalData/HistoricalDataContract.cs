using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.HistoricalData
{
    public class HistoricalDataContract
    {
        [JsonPropertyName("chart")]
        public ChartContract Chart { get; set; }
    }


}
