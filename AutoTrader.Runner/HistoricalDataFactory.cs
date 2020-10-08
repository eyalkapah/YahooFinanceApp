using System.Collections.Generic;
using System.Linq;
using AutoTrader.Yahoo.API.Contracts.HistoricalData;
using YahooFinance.Runner.Helpers;
using YahooFinance.Runner.Models;
using YahooFinance.Runner.Models.HistoricalData;

namespace YahooFinance.Runner
{
    public static class HistoricalDataFactory
    {
        public static HistoricalData GetHistoricalData(this HistoricalDataContract contract)
        {
            var historicalData = contract.Chart.Result.First();
            return new HistoricalData
            {
                Meta = GetMeta(historicalData.Meta),
                Prices = GetPrices(historicalData)
            };
        }

        private static IEnumerable<Price> GetPrices(ResultContract result)
        {
            var quote = result.Indicators.Quote.First();

            var enumerable = result.Timestamp as long[] ?? result.Timestamp.ToArray();

            //var adjClose = GetAdjClose(result.Indicators.Adjclose.First()).ToArray();

            for (var i = 0; i < enumerable.Count(); i++)
            {
                var timestamp = enumerable.ElementAt(i);

                DividendContract dividend = null;
                SplitContract split = null;

                result.Events.Dividends?.TryGetValue(timestamp.ToString(), out dividend);
                result.Events.Splits?.TryGetValue(timestamp.ToString(), out split);

                yield return new Price
                {
                    StartTime = DateTimeExtensions.FromUnixTimeSeconds(timestamp + result.Meta.Gmtoffset),
                    Symbol = result.Meta.Symbol,
                    Open = quote.Open.ElementAt(i),
                    Close = quote.Close.ElementAt(i),
                    High = quote.High.ElementAt(i),
                    Low = quote.Low.ElementAt(i),
                    Volume = quote.Volume.ElementAt(i),
                    //AdjClose = adjClose.ElementAt(i),
                    Dividends = dividend?.Amount ?? 0,
                    StockSplits = split?.Numerator ?? 0
                };
            }
        }

     
        private static IEnumerable<float> GetAdjClose(AdjcloseContract contract) => contract.Adjclose;

        private static Meta GetMeta(MetaContract contract)
        {
            return new Meta
            {
                Currency = contract.Currency,
                Symbol = contract.Symbol,
                ExchangeName = contract.ExchangeName,
                InstrumentType = contract.InstrumentType,
                FirstTradeDate = DateTimeExtensions.FromUnixTimeSeconds(contract.FirstTradeDate + contract.Gmtoffset),
                RegularMarketTime = DateTimeExtensions.FromUnixTimeSeconds(contract.RegularMarketTime + contract.Gmtoffset),
                //Gmtoffset = contract.Gmtoffset,
                //Timezone = contract.Timezone,
                ExchangeTimezoneName = contract.ExchangeTimezoneName,
                RegularMarketPrice = contract.RegularMarketPrice,
                PriceHint = contract.PriceHint,
                DataGranularity = contract.DataGranularity,
                CurrentTradingPeriod = GetCurrentTradingPeriod(contract.CurrentTradingPeriod)
            };

        }

        private static CurrentTradingPeriod GetCurrentTradingPeriod(CurrentTradingPeriodContract contract)
        {
            return new CurrentTradingPeriod
            {
                Pre = new TradingPeriod
                {
                    //Timezone = contract.Pre.Timezone,
                    //Gmtoffset = contract.Pre.Gmtoffset,
                    Start = DateTimeExtensions.FromUnixTimeSeconds(contract.Pre.Start + contract.Pre.Gmtoffset),
                    End = DateTimeExtensions.FromUnixTimeSeconds(contract.Pre.End + contract.Pre.Gmtoffset)
                },
                Post = new TradingPeriod
                {
                    //Timezone = contract.Post.Timezone,
                    //Gmtoffset = contract.Post.Gmtoffset,
                    Start = DateTimeExtensions.FromUnixTimeSeconds(contract.Post.Start + contract.Post.Gmtoffset),
                    End = DateTimeExtensions.FromUnixTimeSeconds(contract.Post.End + contract.Post.Gmtoffset)
                },
                Regular = new TradingPeriod
                {
                    //Timezone = contract.Regular.Timezone,
                    //Gmtoffset = contract.Regular.Gmtoffset,
                    Start = DateTimeExtensions.FromUnixTimeSeconds(contract.Regular.Start + contract.Regular.Gmtoffset),
                    End = DateTimeExtensions.FromUnixTimeSeconds(contract.Regular.End + contract.Regular.Gmtoffset)
                }
            };
        }
    }
}
