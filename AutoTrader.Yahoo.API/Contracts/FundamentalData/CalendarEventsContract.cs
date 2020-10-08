using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class CalendarEventsContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("earnings")]
        public EarningsContract Earnings { get; set; }

        [JsonPropertyName("exDividendDate")]
        public ShortenedValueContract ExDividendDate { get; set; }

        [JsonPropertyName("dividendDate")]
        public ShortenedValueContract DividendDate { get; set; }
    }
}