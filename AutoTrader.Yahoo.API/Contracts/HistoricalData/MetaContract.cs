using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.HistoricalData
{
    public class MetaContract
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("exchangeName")]
        public string ExchangeName { get; set; }

        [JsonPropertyName("instrumentType")]
        public string InstrumentType { get; set; }

        [JsonPropertyName("firstTradeDate")]
        public int FirstTradeDate { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public int RegularMarketTime { get; set; }

        [JsonPropertyName("gmtoffset")]
        public int Gmtoffset { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string ExchangeTimezoneName { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public float RegularMarketPrice { get; set; }

        [JsonPropertyName("chartPreviousClose")]
        public float ChartPreviousClose { get; set; }

        [JsonPropertyName("priceHint")]
        public int PriceHint { get; set; }

        [JsonPropertyName("currentTradingPeriod")]
        public CurrentTradingPeriodContract CurrentTradingPeriod { get; set; }

        [JsonPropertyName("dataGranularity")]
        public string DataGranularity { get; set; }

        [JsonPropertyName("range")]
        public string Range { get; set; }

        [JsonPropertyName("validRanges")]
        public IEnumerable<string> ValidRanges { get; set; }
    }
}