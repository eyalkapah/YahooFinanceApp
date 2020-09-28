using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class InsiderHoldersContract
    {
        [JsonPropertyName("holders")]
        public HolderContract[] Holders { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}