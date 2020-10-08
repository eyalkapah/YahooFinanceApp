using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class SecFilingsContract
    {
        [JsonPropertyName("filings")]
        public FilingContract[] Filings { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}