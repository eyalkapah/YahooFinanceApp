﻿namespace YahooFinance.Runner.Models.Contracts.Options
{

    public class OptionsContract
    {
        public OptionChainContract optionChain { get; set; }
    }

    public class OptionChainContract
    {
        public Result[] result { get; set; }
        public object error { get; set; }
    }

    public class Result
    {
        public string underlyingSymbol { get; set; }
        public int[] expirationDates { get; set; }
        public float[] strikes { get; set; }
        public bool hasMiniOptions { get; set; }
        public Quote quote { get; set; }
        public Option[] options { get; set; }
    }

    public class Quote
    {
        public string language { get; set; }
        public string region { get; set; }
        public string quoteType { get; set; }
        public string quoteSourceName { get; set; }
        public bool triggerable { get; set; }
        public string currency { get; set; }
        public long firstTradeDateMilliseconds { get; set; }
        public int priceHint { get; set; }
        public string marketState { get; set; }
        public string exchange { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
        public string messageBoardId { get; set; }
        public string exchangeTimezoneName { get; set; }
        public string exchangeTimezoneShortName { get; set; }
        public int gmtOffSetMilliseconds { get; set; }
        public string market { get; set; }
        public bool esgPopulated { get; set; }
        public float twoHundredDayAverage { get; set; }
        public float twoHundredDayAverageChange { get; set; }
        public float twoHundredDayAverageChangePercent { get; set; }
        public float forwardPE { get; set; }
        public float regularMarketDayLow { get; set; }
        public int regularMarketVolume { get; set; }
        public float regularMarketPreviousClose { get; set; }
        public float bid { get; set; }
        public float ask { get; set; }
        public int bidSize { get; set; }
        public int askSize { get; set; }
        public string fullExchangeName { get; set; }
        public string financialCurrency { get; set; }
        public float regularMarketOpen { get; set; }
        public int averageDailyVolume3Month { get; set; }
        public int averageDailyVolume10Day { get; set; }
        public float fiftyTwoWeekLowChange { get; set; }
        public float fiftyTwoWeekLowChangePercent { get; set; }
        public string fiftyTwoWeekRange { get; set; }
        public float fiftyTwoWeekHighChange { get; set; }
        public float fiftyTwoWeekHighChangePercent { get; set; }
        public float fiftyTwoWeekLow { get; set; }
        public float fiftyTwoWeekHigh { get; set; }
        public int dividendDate { get; set; }
        public int earningsTimestamp { get; set; }
        public int earningsTimestampStart { get; set; }
        public int earningsTimestampEnd { get; set; }
        public float trailingAnnualDividendRate { get; set; }
        public float trailingPE { get; set; }
        public float trailingAnnualDividendYield { get; set; }
        public float epsTrailingTwelveMonths { get; set; }
        public float epsForward { get; set; }
        public float epsCurrentYear { get; set; }
        public float priceEpsCurrentYear { get; set; }
        public float fiftyDayAverageChange { get; set; }
        public float fiftyDayAverageChangePercent { get; set; }
        public long marketCap { get; set; }
        public long sharesOutstanding { get; set; }
        public float bookValue { get; set; }
        public float fiftyDayAverage { get; set; }
        public float priceToBook { get; set; }
        public int sourceInterval { get; set; }
        public int exchangeDataDelayedBy { get; set; }
        public bool tradeable { get; set; }
        public float postMarketChangePercent { get; set; }
        public int postMarketTime { get; set; }
        public float postMarketPrice { get; set; }
        public float postMarketChange { get; set; }
        public float regularMarketChange { get; set; }
        public float regularMarketChangePercent { get; set; }
        public int regularMarketTime { get; set; }
        public float regularMarketPrice { get; set; }
        public float regularMarketDayHigh { get; set; }
        public string regularMarketDayRange { get; set; }
        public string displayName { get; set; }
        public string symbol { get; set; }
    }

    public class Option
    {
        public int expirationDate { get; set; }
        public bool hasMiniOptions { get; set; }
        public Call[] calls { get; set; }
        public Put[] puts { get; set; }
    }

    public class Call
    {
        public string contractSymbol { get; set; }
        public float strike { get; set; }
        public string currency { get; set; }
        public float lastPrice { get; set; }
        public float change { get; set; }
        public float percentChange { get; set; }
        public int volume { get; set; }
        public int openInterest { get; set; }
        public float bid { get; set; }
        public float ask { get; set; }
        public string contractSize { get; set; }
        public int expiration { get; set; }
        public int lastTradeDate { get; set; }
        public float impliedVolatility { get; set; }
        public bool inTheMoney { get; set; }
    }

    public class Put
    {
        public string contractSymbol { get; set; }
        public float strike { get; set; }
        public string currency { get; set; }
        public float lastPrice { get; set; }
        public float change { get; set; }
        public float percentChange { get; set; }
        public int volume { get; set; }
        public int openInterest { get; set; }
        public float bid { get; set; }
        public float ask { get; set; }
        public string contractSize { get; set; }
        public int expiration { get; set; }
        public int lastTradeDate { get; set; }
        public float impliedVolatility { get; set; }
        public bool inTheMoney { get; set; }
    }

}
