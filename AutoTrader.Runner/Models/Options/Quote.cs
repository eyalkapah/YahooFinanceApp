namespace YahooFinance.Runner.Models.Options
{
    public class Quote
    {
        public string Language { get; set; }

        public string Region { get; set; }

        public string QuoteType { get; set; }

        public string QuoteSourceName { get; set; }

        public bool Triggerable { get; set; }

        public string Currency { get; set; }

        public long FirstTradeDateMilliseconds { get; set; }

        public int PriceHint { get; set; }

        public string MarketState { get; set; }

        public string Exchange { get; set; }

        public string ShortName { get; set; }

        public string LongName { get; set; }

        public string MessageBoardId { get; set; }

        public string ExchangeTimezoneName { get; set; }

        public string ExchangeTimezoneShortName { get; set; }

        public int GmtOffSetMilliseconds { get; set; }

        public string Market { get; set; }

        public bool EsgPopulated { get; set; }

        public float TwoHundredDayAverage { get; set; }

        public float TwoHundredDayAverageChange { get; set; }

        public float TwoHundredDayAverageChangePercent { get; set; }

        public float ForwardPE { get; set; }

        public float RegularMarketDayLow { get; set; }

        public int RegularMarketVolume { get; set; }

        public float RegularMarketPreviousClose { get; set; }

        public float Bid { get; set; }

        public float Ask { get; set; }

        public int BidSize { get; set; }

        public int AskSize { get; set; }

        public string FullExchangeName { get; set; }

        public string FinancialCurrency { get; set; }

        public float RegularMarketOpen { get; set; }

        public int AverageDailyVolume3Month { get; set; }

        public int AverageDailyVolume10Day { get; set; }

        public float FiftyTwoWeekLowChange { get; set; }

        public float FiftyTwoWeekLowChangePercent { get; set; }

        public string FiftyTwoWeekRange { get; set; }

        public float FiftyTwoWeekHighChange { get; set; }

        public float FiftyTwoWeekHighChangePercent { get; set; }

        public float FiftyTwoWeekLow { get; set; }

        public float FiftyTwoWeekHigh { get; set; }

        public int DividendDate { get; set; }

        public int EarningsTimestamp { get; set; }

        public int EarningsTimestampStart { get; set; }

        public int EarningsTimestampEnd { get; set; }

        public float TrailingAnnualDividendRate { get; set; }

        public float TrailingPE { get; set; }

        public float TrailingAnnualDividendYield { get; set; }

        public float EpsTrailingTwelveMonths { get; set; }

        public float EpsForward { get; set; }

        public float EpsCurrentYear { get; set; }

        public float PriceEpsCurrentYear { get; set; }

        public float FiftyDayAverageChange { get; set; }

        public float FiftyDayAverageChangePercent { get; set; }

        public long MarketCap { get; set; }

        public long SharesOutstanding { get; set; }

        public float BookValue { get; set; }

        public float FiftyDayAverage { get; set; }

        public float PriceToBook { get; set; }

        public int SourceInterval { get; set; }

        public int ExchangeDataDelayedBy { get; set; }

        public bool Tradeable { get; set; }

        public float PostMarketChangePercent { get; set; }

        public int PostMarketTime { get; set; }

        public float PostMarketPrice { get; set; }

        public float PostMarketChange { get; set; }

        public float RegularMarketChange { get; set; }

        public float RegularMarketChangePercent { get; set; }

        public int RegularMarketTime { get; set; }

        public float RegularMarketPrice { get; set; }

        public float RegularMarketDayHigh { get; set; }

        public string RegularMarketDayRange { get; set; }

        public string DisplayName { get; set; }

        public string Symbol { get; set; }
    }
}