using System.Text.Json.Serialization;
using YahooFinance.Runner.Models.Contracts.FundamentalData.StubClasses;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class SummaryDetailContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("priceHint")]
        public ValueContract PriceHint { get; set; }

        [JsonPropertyName("previousClose")]
        public ShortenedValueContract PreviousClose { get; set; }

        [JsonPropertyName("open")]
        public ShortenedValueContract Open { get; set; }

        [JsonPropertyName("dayLow")]
        public ShortenedValueContract DayLow { get; set; }

        [JsonPropertyName("dayHigh")]
        public ShortenedValueContract DayHigh { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public ShortenedValueContract RegularMarketPreviousClose { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public ShortenedValueContract RegularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public ShortenedValueContract RegularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public ShortenedValueContract RegularMarketDayHigh { get; set; }

        [JsonPropertyName("dividendRate")]
        public ShortenedValueContract DividendRate { get; set; }

        [JsonPropertyName("dividendYield")]
        public ShortenedValueContract DividendYield { get; set; }

        [JsonPropertyName("exDividendDate")]
        public ShortenedValueContract ExDividendDate { get; set; }

        [JsonPropertyName("payoutRatio")]
        public ShortenedValueContract PayoutRatio { get; set; }

        [JsonPropertyName("fiveYearAvgDividendYield")]
        public ShortenedValueContract FiveYearAvgDividendYield { get; set; }

        [JsonPropertyName("beta")]
        public ShortenedValueContract Beta { get; set; }

        [JsonPropertyName("trailingPE")]
        public ShortenedValueContract TrailingPe { get; set; }

        [JsonPropertyName("forwardPE")]
        public ShortenedValueContract ForwardPe { get; set; }

        [JsonPropertyName("volume")]
        public ValueContract Volume { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public ValueContract RegularMarketVolume { get; set; }

        [JsonPropertyName("averageVolume")]
        public ValueContract AverageVolume { get; set; }

        [JsonPropertyName("averageVolume10days")]
        public ValueContract AverageVolume10days { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public ValueContract AverageDailyVolume10Day { get; set; }

        [JsonPropertyName("bid")]
        public ShortenedValueContract Bid { get; set; }

        [JsonPropertyName("ask")]
        public ShortenedValueContract Ask { get; set; }

        [JsonPropertyName("bidSize")]
        public ValueContract BidSize { get; set; }

        [JsonPropertyName("askSize")]
        public ValueContract AskSize { get; set; }

        [JsonPropertyName("marketCap")]
        public ValueContract MarketCap { get; set; }

        [JsonPropertyName("yield")]
        public Yield1Contract Yield { get; set; }

        [JsonPropertyName("ytdReturn")]
        public YtdReturn1Contract YtdReturn { get; set; }

        [JsonPropertyName("totalAssets")]
        public TotalAssets1Contract TotalAssets { get; set; }

        [JsonPropertyName("expireDate")]
        public ExpireDateContract ExpireDate { get; set; }

        [JsonPropertyName("strikePrice")]
        public StrikePriceContract StrikePrice { get; set; }

        [JsonPropertyName("openInterest")]
        public OpenInterestContract OpenInterest { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public ShortenedValueContract FiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public ShortenedValueContract FiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("priceToSalesTrailing12Months")]
        public ShortenedValueContract PriceToSalesTrailing12Months { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public ShortenedValueContract FiftyDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public ShortenedValueContract TwoHundredDayAverage { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public ShortenedValueContract TrailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public ShortenedValueContract TrailingAnnualDividendYield { get; set; }

        [JsonPropertyName("navPrice")]
        public NavPriceContract NavPrice { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("fromCurrency")]
        public object FromCurrency { get; set; }

        [JsonPropertyName("toCurrency")]
        public object ToCurrency { get; set; }

        [JsonPropertyName("lastMarket")]
        public object LastMarket { get; set; }

        [JsonPropertyName("volume24Hr")]
        public Volume24HrContract Volume24Hr { get; set; }

        [JsonPropertyName("volumeAllCurrencies")]
        public VolumeAllCurrenciesContract VolumeAllCurrencies { get; set; }

        [JsonPropertyName("circulatingSupply")]
        public CirculatingSupplyContract CirculatingSupply { get; set; }

        [JsonPropertyName("algorithm")]
        public object Algorithm { get; set; }

        [JsonPropertyName("maxSupply")]
        public MaxSupplyContract MaxSupply { get; set; }

        [JsonPropertyName("startDate")]
        public StartDateContract StartDate { get; set; }

        [JsonPropertyName("tradeable")]
        public bool Tradeable { get; set; }
    }
}