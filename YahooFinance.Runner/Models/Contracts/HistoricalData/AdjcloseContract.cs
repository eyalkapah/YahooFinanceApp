using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.HistoricalData
{
    public class AdjcloseContract
    {
        [JsonPropertyName("adjclose")]
        public IEnumerable<float> Adjclose { get; set; }
    }
}