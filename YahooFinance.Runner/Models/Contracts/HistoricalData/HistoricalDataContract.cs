using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.HistoricalData
{
    public class HistoricalDataContract
    {
        [JsonPropertyName("chart")] 
        public ChartContract Chart { get; set; }
    }
}
