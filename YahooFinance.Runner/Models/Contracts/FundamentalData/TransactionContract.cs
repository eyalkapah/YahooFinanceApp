using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class TransactionContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("shares")]
        public ValueContract Shares { get; set; }

        [JsonPropertyName("value")]
        public ValueContract Value { get; set; }

        [JsonPropertyName("filerUrl")]
        public string FilerUrl { get; set; }

        [JsonPropertyName("transactionText")]
        public string TransactionText { get; set; }

        [JsonPropertyName("filerName")]
        public string FilerName { get; set; }

        [JsonPropertyName("filerRelation")]
        public string FilerRelation { get; set; }

        [JsonPropertyName("moneyText")]
        public string MoneyText { get; set; }

        [JsonPropertyName("startDate")]
        public ShortenedValueContract StartDate { get; set; }

        [JsonPropertyName("ownership")]
        public string Ownership { get; set; }
    }
}