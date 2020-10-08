using YahooFinance.Runner.Models.FundamentalData.Stubs;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class SummaryDetail
    {
        public int MaxAge { get; set; }

        public Value PriceHint { get; set; }

        public ShortenedValue PreviousClose { get; set; }

        public ShortenedValue Open { get; set; }

        public ShortenedValue DayLow { get; set; }

        public ShortenedValue DayHigh { get; set; }

        public ShortenedValue RegularMarketPreviousClose { get; set; }

        public ShortenedValue RegularMarketOpen { get; set; }

        public ShortenedValue RegularMarketDayLow { get; set; }

        public ShortenedValue RegularMarketDayHigh { get; set; }

        public ShortenedValue DividendRate { get; set; }

        public ShortenedValue DividendYield { get; set; }

        public ShortenedValue ExDividendDate { get; set; }

        public ShortenedValue PayoutRatio { get; set; }

        public ShortenedValue FiveYearAvgDividendYield { get; set; }

        public ShortenedValue Beta { get; set; }

        public ShortenedValue TrailingPe { get; set; }

        public ShortenedValue ForwardPe { get; set; }

        public Value Volume { get; set; }

        public Value RegularMarketVolume { get; set; }

        public Value AverageVolume { get; set; }

        public Value AverageVolume10days { get; set; }

        public Value AverageDailyVolume10Day { get; set; }

        public ShortenedValue Bid { get; set; }

        public ShortenedValue Ask { get; set; }

        public Value BidSize { get; set; }

        public Value AskSize { get; set; }

        public Value MarketCap { get; set; }

        public Yield1Stub Yield { get; set; }

        public YtdReturn1Stub YtdReturn { get; set; }

        public TotalAssets1Stub TotalAssets { get; set; }

        public ExpireDateStub ExpireDate { get; set; }

        public StrikePriceStub StrikePrice { get; set; }

        public OpenInterestStub OpenInterest { get; set; }

        public ShortenedValue FiftyTwoWeekLow { get; set; }

        public ShortenedValue FiftyTwoWeekHigh { get; set; }

        public ShortenedValue PriceToSalesTrailing12Months { get; set; }

        public ShortenedValue FiftyDayAverage { get; set; }

        public ShortenedValue TwoHundredDayAverage { get; set; }

        public ShortenedValue TrailingAnnualDividendRate { get; set; }

        public ShortenedValue TrailingAnnualDividendYield { get; set; }

        public NavPriceStub NavPrice { get; set; }

        public string Currency { get; set; }

        public object FromCurrency { get; set; }

        public object ToCurrency { get; set; }

        public object LastMarket { get; set; }

        public Volume24HrStub Volume24Hr { get; set; }

        public VolumeAllCurrenciesStub VolumeAllCurrencies { get; set; }

        public CirculatingSupplyStub CirculatingSupply { get; set; }

        public object Algorithm { get; set; }

        public MaxSupplyStub MaxSupply { get; set; }

        public StartDateStub StartDate { get; set; }

        public bool Tradeable { get; set; }
    }
}
