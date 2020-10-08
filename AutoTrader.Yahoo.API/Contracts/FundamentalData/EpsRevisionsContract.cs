using System.Text.Json.Serialization;
using AutoTrader.Yahoo.API.Contracts.FundamentalData.StubClasses;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
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