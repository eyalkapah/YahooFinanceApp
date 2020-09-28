using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class PriceContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("preMarketChange")]
        public PreMarketChangeContract PreMarketChange { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public PreMarketPriceContract PreMarketPrice { get; set; }

        [JsonPropertyName("preMarketSource")]
        public string PreMarketSource { get; set; }

        [JsonPropertyName("postMarketChangePercent")]
        public ShortenedValueContract PostMarketChangePercent { get; set; }

        [JsonPropertyName("postMarketChange")]
        public ShortenedValueContract PostMarketChange { get; set; }

        [JsonPropertyName("postMarketTime")]
        public int PostMarketTime { get; set; }

        [JsonPropertyName("postMarketPrice")]
        public ShortenedValueContract PostMarketPrice { get; set; }

        [JsonPropertyName("postMarketSource")]
        public string PostMarketSource { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public ShortenedValueContract RegularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public ShortenedValueContract RegularMarketChange { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public int RegularMarketTime { get; set; }

        [JsonPropertyName("priceHint")]
        public ValueContract PriceHint { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public ShortenedValueContract RegularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public ShortenedValueContract RegularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public ShortenedValueContract RegularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public ValueContract RegularMarketVolume { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public ValueContract AverageDailyVolume10Day { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public ValueContract AverageDailyVolume3Month { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public ShortenedValueContract RegularMarketPreviousClose { get; set; }

        [JsonPropertyName("regularMarketSource")]
        public string RegularMarketSource { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public ShortenedValueContract RegularMarketOpen { get; set; }

        [JsonPropertyName("strikePrice")]
        public StrikePrice1Contract StrikePrice { get; set; }

        [JsonPropertyName("openInterest")]
        public OpenInterest1Contract OpenInterest { get; set; }

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("exchangeName")]
        public string ExchangeName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public int ExchangeDataDelayedBy { get; set; }

        [JsonPropertyName("marketState")]
        public string MarketState { get; set; }

        [JsonPropertyName("quoteType")]
        public string QuoteType { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("underlyingSymbol")]
        public object UnderlyingSymbol { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("longName")]
        public string LongName { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string QuoteSourceName { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("fromCurrency")]
        public object FromCurrency { get; set; }

        [JsonPropertyName("toCurrency")]
        public object ToCurrency { get; set; }

        [JsonPropertyName("lastMarket")]
        public object LastMarket { get; set; }

        [JsonPropertyName("volume24Hr")]
        public Volume24Hr1Contract Volume24Hr { get; set; }

        [JsonPropertyName("volumeAllCurrencies")]
        public VolumeAllCurrencies1Contract VolumeAllCurrencies { get; set; }

        [JsonPropertyName("circulatingSupply")]
        public CirculatingSupply1Contract CirculatingSupply { get; set; }

        [JsonPropertyName("marketCap")]
        public ValueContract MarketCap { get; set; }
    }
}