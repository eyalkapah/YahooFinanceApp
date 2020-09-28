using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class SecFilingsContract
    {
        [JsonPropertyName("filings")]
        public FilingContract[] Filings { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}