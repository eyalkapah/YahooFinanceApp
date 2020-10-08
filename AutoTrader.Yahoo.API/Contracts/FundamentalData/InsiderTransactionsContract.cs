using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class InsiderTransactionsContract
    {
        [JsonPropertyName("transactions")]
        public TransactionContract[] Transactions { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}