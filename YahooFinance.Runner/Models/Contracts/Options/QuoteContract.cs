using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.Options
{
    public class QuoteContract
    {
        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("quoteType")]
        public string QuoteType { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string QuoteSourceName { get; set; }

        [JsonPropertyName("triggerable")]
        public bool Triggerable { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("firstTradeDateMilliseconds")]
        public long FirstTradeDateMilliseconds { get; set; }

        [JsonPropertyName("priceHint")]
        public int PriceHint { get; set; }

        [JsonPropertyName("marketState")]
        public string MarketState { get; set; }

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("longName")]
        public string LongName { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string MessageBoardId { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string ExchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string ExchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public int GmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("market")]
        public string Market { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool EsgPopulated { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public float TwoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public float TwoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public float TwoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("forwardPE")]
        public float ForwardPE { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public float RegularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public int RegularMarketVolume { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public float RegularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public float Bid { get; set; }

        [JsonPropertyName("ask")]
        public float Ask { get; set; }

        [JsonPropertyName("bidSize")]
        public int BidSize { get; set; }

        [JsonPropertyName("askSize")]
        public int AskSize { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string FullExchangeName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string FinancialCurrency { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public float RegularMarketOpen { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public int AverageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public int AverageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public float FiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public float FiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string FiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public float FiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public float FiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public float FiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public float FiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public int DividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public int EarningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public int EarningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public int EarningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public float TrailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public float TrailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public float TrailingAnnualDividendYield { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public float EpsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public float EpsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public float EpsCurrentYear { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public float PriceEpsCurrentYear { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public float FiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public float FiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long MarketCap { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public long SharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public float BookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public float FiftyDayAverage { get; set; }

        [JsonPropertyName("priceToBook")]
        public float PriceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public int SourceInterval { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public int ExchangeDataDelayedBy { get; set; }

        [JsonPropertyName("tradeable")]
        public bool Tradeable { get; set; }

        [JsonPropertyName("postMarketChangePercent")]
        public float PostMarketChangePercent { get; set; }

        [JsonPropertyName("postMarketTime")]
        public int PostMarketTime { get; set; }

        [JsonPropertyName("postMarketPrice")]
        public float PostMarketPrice { get; set; }

        [JsonPropertyName("postMarketChange")]
        public float PostMarketChange { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public float RegularMarketChange { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public float RegularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public int RegularMarketTime { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public float RegularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public float RegularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string RegularMarketDayRange { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
    }
}