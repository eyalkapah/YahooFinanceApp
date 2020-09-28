using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class MajorDirectHoldersContract
    {
        [JsonPropertyName("holders")]
        public object[] Holders { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}