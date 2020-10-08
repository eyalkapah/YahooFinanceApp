using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class MajorDirectHoldersContract
    {
        [JsonPropertyName("holders")]
        public object[] Holders { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}