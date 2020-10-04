using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.Options
{
    public class PutContract
    {
        [JsonPropertyName("contractSymbol")]
        public string ContractSymbol { get; set; }

        [JsonPropertyName("strike")]
        public float Strike { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("lastPrice")]
        public float LastPrice { get; set; }

        [JsonPropertyName("change")]
        public float Change { get; set; }

        [JsonPropertyName("percentChange")]
        public float PercentChange { get; set; }

        [JsonPropertyName("volume")]
        public int Volume { get; set; }

        [JsonPropertyName("openInterest")]
        public int OpenInterest { get; set; }

        [JsonPropertyName("bid")]
        public float Bid { get; set; }

        [JsonPropertyName("ask")]
        public float Ask { get; set; }

        [JsonPropertyName("contractSize")]
        public string ContractSize { get; set; }

        [JsonPropertyName("expiration")]
        public int Expiration { get; set; }

        [JsonPropertyName("lastTradeDate")]
        public int LastTradeDate { get; set; }

        [JsonPropertyName("impliedVolatility")]
        public float ImpliedVolatility { get; set; }

        [JsonPropertyName("inTheMoney")]
        public bool InTheMoney { get; set; }
    }
}