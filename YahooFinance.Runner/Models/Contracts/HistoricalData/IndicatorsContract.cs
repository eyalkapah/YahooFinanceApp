using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.HistoricalData
{
    public class IndicatorsContract
    {
        [JsonPropertyName("quote")]
        public IEnumerable<QuoteContract> Quote { get; set; }

        [JsonPropertyName("adjclose")]
        public IEnumerable<AdjcloseContract> Adjclose { get; set; }
    }
}