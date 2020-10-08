using System.Text.Json.Serialization;
using AutoTrader.Yahoo.API.Contracts.FundamentalData.StubClasses;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class IndustryTrendContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("peRatio")]
        public PeRatio1Contract PeRatio { get; set; }

        [JsonPropertyName("pegRatio")]
        public PegRatio2Contract PegRatio { get; set; }

        [JsonPropertyName("estimates")]
        public object[] Estimates { get; set; }
    }
}