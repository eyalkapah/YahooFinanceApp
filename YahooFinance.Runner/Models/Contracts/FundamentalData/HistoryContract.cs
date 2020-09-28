using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class HistoryContract
    {
        [JsonPropertyName("epochGradeDate")]
        public int EpochGradeDate { get; set; }

        [JsonPropertyName("firm")]
        public string Firm { get; set; }

        [JsonPropertyName("toGrade")]
        public string ToGrade { get; set; }

        [JsonPropertyName("fromGrade")]
        public string FromGrade { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; }
    }
}