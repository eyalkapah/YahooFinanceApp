using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class NetSharePurchaseActivityContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonPropertyName("buyInfoCount")]
        public ValueContract BuyInfoCount { get; set; }

        [JsonPropertyName("buyInfoShares")]
        public ValueContract BuyInfoShares { get; set; }

        [JsonPropertyName("buyPercentInsiderShares")]
        public ShortenedValueContract BuyPercentInsiderShares { get; set; }

        [JsonPropertyName("sellInfoCount")]
        public ValueContract SellInfoCount { get; set; }

        [JsonPropertyName("sellInfoShares")]
        public ValueContract SellInfoShares { get; set; }

        [JsonPropertyName("sellPercentInsiderShares")]
        public ShortenedValueContract SellPercentInsiderShares { get; set; }

        [JsonPropertyName("netInfoCount")]
        public ValueContract NetInfoCount { get; set; }

        [JsonPropertyName("netInfoShares")]
        public ValueContract NetInfoShares { get; set; }

        [JsonPropertyName("netPercentInsiderShares")]
        public ShortenedValueContract NetPercentInsiderShares { get; set; }

        [JsonPropertyName("totalInsiderShares")]
        public ValueContract TotalInsiderShares { get; set; }
    }
}