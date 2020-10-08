using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class EarningsHistoryContract
    {
        [JsonPropertyName("history")]
        public History1Contract[] History { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}