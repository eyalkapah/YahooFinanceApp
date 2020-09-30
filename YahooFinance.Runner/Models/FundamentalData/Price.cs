using YahooFinance.Runner.Models.FundamentalData.Stubs;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class Price
    {
        public int MaxAge { get; set; }

        public PreMarketChangeStub PreMarketChange { get; set; }

        public PreMarketPriceStub PreMarketPrice { get; set; }

        public string PreMarketSource { get; set; }

        public ShortenedValue PostMarketChangePercent { get; set; }

        public ShortenedValue PostMarketChange { get; set; }

        public int PostMarketTime { get; set; }

        public ShortenedValue PostMarketPrice { get; set; }

        public string PostMarketSource { get; set; }

        public ShortenedValue RegularMarketChangePercent { get; set; }

        public ShortenedValue RegularMarketChange { get; set; }

        public int RegularMarketTime { get; set; }

        public Value PriceHint { get; set; }

        public ShortenedValue RegularMarketPrice { get; set; }

        public ShortenedValue RegularMarketDayHigh { get; set; }

        public ShortenedValue RegularMarketDayLow { get; set; }

        public Value RegularMarketVolume { get; set; }

        public Value AverageDailyVolume10Day { get; set; }

        public Value AverageDailyVolume3Month { get; set; }

        public ShortenedValue RegularMarketPreviousClose { get; set; }

        public string RegularMarketSource { get; set; }

        public ShortenedValue RegularMarketOpen { get; set; }

        public StrikePrice1Stub StrikePrice { get; set; }

        public OpenInterest1Stub OpenInterest { get; set; }

        public string Exchange { get; set; }

        public string ExchangeName { get; set; }

        public int ExchangeDataDelayedBy { get; set; }

        public string MarketState { get; set; }

        public string QuoteType { get; set; }

        public string Symbol { get; set; }

        public object UnderlyingSymbol { get; set; }

        public string ShortName { get; set; }

        public string LongName { get; set; }

        public string Currency { get; set; }

        public string QuoteSourceName { get; set; }

        public string CurrencySymbol { get; set; }

        public object FromCurrency { get; set; }

        public object ToCurrency { get; set; }

        public object LastMarket { get; set; }

        public Volume24Hr1Stub Volume24Hr { get; set; }

        public VolumeAllCurrencies1Stub VolumeAllCurrencies { get; set; }

        public CirculatingSupply1Stub CirculatingSupply { get; set; }

        public Value MarketCap { get; set; }
    }
}
