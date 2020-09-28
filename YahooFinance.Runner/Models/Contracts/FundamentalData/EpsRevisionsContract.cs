using System.Text.Json.Serialization;
using YahooFinance.Runner.Models.Contracts.FundamentalData.StubClasses;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class EpsRevisionsContract
    {
        [JsonPropertyName("upLast7days")]
        public ValueContract UpLast7days { get; set; }

        [JsonPropertyName("upLast30days")]
        public ValueContract UpLast30days { get; set; }

        [JsonPropertyName("downLast30days")]
        public ValueContract DownLast30days { get; set; }

        [JsonPropertyName("downLast90days")]
        public DownLast90daysContract DownLast90days { get; set; }
    }
}