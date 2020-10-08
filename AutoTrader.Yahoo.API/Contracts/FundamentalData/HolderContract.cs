using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class HolderContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("relation")]
        public string Relation { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("transactionDescription")]
        public string TransactionDescription { get; set; }

        [JsonPropertyName("latestTransDate")]
        public ShortenedValueContract LatestTransDate { get; set; }

        [JsonPropertyName("positionDirect")]
        public ValueContract PositionDirect { get; set; }

        [JsonPropertyName("positionDirectDate")]
        public ShortenedValueContract PositionDirectDate { get; set; }
    }
}