using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class EarningsTrendContract
    {
        [JsonPropertyName("trend")]
        public Trend1Contract[] Trend { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}