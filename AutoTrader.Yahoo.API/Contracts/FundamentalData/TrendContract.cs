using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class TrendContract
    {
        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonPropertyName("strongBuy")]
        public int StrongBuy { get; set; }

        [JsonPropertyName("buy")]
        public int Buy { get; set; }

        [JsonPropertyName("hold")]
        public int Hold { get; set; }

        [JsonPropertyName("sell")]
        public int Sell { get; set; }

        [JsonPropertyName("strongSell")]
        public int StrongSell { get; set; }
    }
}