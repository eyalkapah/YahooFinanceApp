using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.HistoricalData
{
    public class AdjcloseContract
    {
        [JsonPropertyName("adjclose")]
        public IEnumerable<float> Adjclose { get; set; }
    }
}