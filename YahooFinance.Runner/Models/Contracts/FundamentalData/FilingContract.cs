using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class FilingContract
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("epochDate")]
        public int EpochDate { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("edgarUrl")]
        public string EdgarUrl { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}