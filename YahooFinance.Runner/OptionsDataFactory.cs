using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Runner.Models.Contracts.Options;
using YahooFinance.Runner.Models.Options;

namespace YahooFinance.Runner
{
    public static class OptionsDataFactory
    {
        public static Options GetOptions(this OptionsContract optionsContract)
        {
            return new Options
            {
                OptionChain = GetOptionChain(optionsContract.OptionChain)
            };
        }

        private static OptionChain GetOptionChain(OptionChainContract contract)
        {
            return new OptionChain
            {
                Error = contract.Error,
                Result = GetResult(contract.Result)
            };
        }

        private static IEnumerable<Result> GetResult(ResultContract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new Result
                {
                    HasMiniOptions = c.HasMiniOptions,
                    UnderlyingSymbol = c.UnderlyingSymbol,
                    ExpirationDates = c.ExpirationDates,
                    Strikes = c.Strikes,
                    Quote = GetQuote(c.Quote),
                    Options = GetOption(c.Options)
                };
            }
        }

        private static IEnumerable<Option> GetOption(OptionContract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new Option
                {
                    HasMiniOptions = c.HasMiniOptions,
                    ExpirationDate = c.ExpirationDate,
                    Calls = GetCalls(c.Calls),
                    Puts = GetPuts(c.Puts)
                };
            }
        }

        private static IEnumerable<Put> GetPuts(PutContract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new Put
                {
                    Bid = c.Bid,
                    Ask = c.Ask,
                    Currency = c.Currency,
                    Volume = c.Volume,
                    OpenInterest = c.OpenInterest,
                    ContractSize = c.ContractSize,
                    Change = c.Change,
                    ContractSymbol = c.ContractSymbol,
                    Expiration = c.Expiration,
                    ImpliedVolatility = c.ImpliedVolatility,
                    InTheMoney = c.InTheMoney,
                    LastPrice = c.LastPrice,
                    LastTradeDate = c.LastTradeDate,
                    PercentChange = c.PercentChange,
                    Strike = c.Strike
                };
            }
        }

        private static IEnumerable<Call> GetCalls(CallContract[] contract)
        {
            foreach (var c in contract)
            {
                yield return new Call
                {
                    Currency = c.Currency,
                    Bid = c.Bid,
                    Ask = c.Ask,
                    Volume = c.Volume,
                    OpenInterest = c.OpenInterest,
                    Change = c.Change,
                    ContractSize = c.ContractSize,
                    ContractSymbol = c.ContractSymbol,
                    Expiration = c.Expiration,
                    ImpliedVolatility = c.ImpliedVolatility,
                    InTheMoney = c.InTheMoney,
                    LastPrice = c.LastPrice,
                    LastTradeDate = c.LastTradeDate,
                    PercentChange = c.PercentChange,
                    Strike = c.Strike
                };
            }
        }

        private static Quote GetQuote(QuoteContract c)
        {
            return new Quote
            {
                AverageDailyVolume10Day = c.AverageDailyVolume10Day,
                PriceHint = c.PriceHint,
                Symbol = c.Symbol,
                Currency = c.Currency,
                TwoHundredDayAverage = c.TwoHundredDayAverage,
                RegularMarketDayLow = c.RegularMarketDayLow,
                RegularMarketVolume = c.RegularMarketVolume,
                RegularMarketPreviousClose = c.RegularMarketPreviousClose,
                RegularMarketOpen = c.RegularMarketOpen,
                TrailingAnnualDividendRate = c.TrailingAnnualDividendRate,
                TrailingAnnualDividendYield = c.TrailingAnnualDividendYield,
                MarketCap = c.MarketCap,
                Tradeable = c.Tradeable,
                RegularMarketDayHigh = c.RegularMarketDayHigh,
                Bid = c.Bid,
                Ask = c.Ask,
                BidSize = c.BidSize,
                AskSize = c.AskSize,
                FiftyTwoWeekLow = c.FiftyTwoWeekLow,
                FiftyTwoWeekHigh = c.FiftyTwoWeekHigh,
                DividendDate = c.DividendDate,
                SharesOutstanding = c.SharesOutstanding,
                BookValue = c.BookValue,
                FiftyDayAverage = c.FiftyDayAverage,
                PriceToBook = c.PriceToBook,
                AverageDailyVolume3Month = c.AverageDailyVolume3Month,
                DisplayName = c.DisplayName,
                EarningsTimestamp = c.EarningsTimestamp,
                EarningsTimestampEnd = c.EarningsTimestampEnd,
                EarningsTimestampStart = c.EarningsTimestampStart,
                EpsCurrentYear = c.EpsCurrentYear,
                EpsForward = c.EpsForward,
                EpsTrailingTwelveMonths = c.EpsTrailingTwelveMonths,
                EsgPopulated = c.EsgPopulated,
                Exchange = c.Exchange,
                ExchangeDataDelayedBy = c.ExchangeDataDelayedBy,
                ExchangeTimezoneName = c.ExchangeTimezoneName,
                ExchangeTimezoneShortName = c.ExchangeTimezoneShortName,
                FiftyDayAverageChange = c.FiftyDayAverageChange,
                FiftyDayAverageChangePercent = c.FiftyDayAverageChangePercent,
                FiftyTwoWeekHighChange = c.FiftyTwoWeekHighChange,
                FiftyTwoWeekHighChangePercent = c.FiftyTwoWeekHighChangePercent,
                FiftyTwoWeekLowChange = c.FiftyTwoWeekLowChange,
                FiftyTwoWeekLowChangePercent = c.FiftyTwoWeekLowChangePercent,
                FiftyTwoWeekRange = c.FiftyTwoWeekRange,
                FinancialCurrency = c.FinancialCurrency,
                FirstTradeDateMilliseconds = c.FirstTradeDateMilliseconds,
                ForwardPE = c.ForwardPE,
                FullExchangeName = c.FullExchangeName,
                GmtOffSetMilliseconds = c.GmtOffSetMilliseconds,
                Language = c.Language,
                LongName = c.LongName,
                Market = c.Market,
                MarketState = c.MarketState,
                MessageBoardId = c.MessageBoardId,
                PostMarketChange = c.PostMarketChange,
                PostMarketChangePercent = c.PostMarketChangePercent,
                PostMarketPrice = c.PostMarketPrice,
                PostMarketTime = c.PostMarketTime,
                PriceEpsCurrentYear = c.PriceEpsCurrentYear,
                QuoteSourceName = c.QuoteSourceName,
                QuoteType = c.QuoteType,
                Region = c.Region,
                RegularMarketChange = c.RegularMarketChange,
                RegularMarketChangePercent = c.RegularMarketChangePercent,
                RegularMarketDayRange = c.RegularMarketDayRange,
                RegularMarketPrice = c.RegularMarketPrice,
                RegularMarketTime = c.RegularMarketTime,
                ShortName = c.ShortName,
                SourceInterval = c.SourceInterval,
                TrailingPE = c.TrailingPE,
                Triggerable = c.Triggerable,
                TwoHundredDayAverageChange = c.TwoHundredDayAverageChange,
                TwoHundredDayAverageChangePercent = c.TwoHundredDayAverageChangePercent
            };
        }
    }
}
