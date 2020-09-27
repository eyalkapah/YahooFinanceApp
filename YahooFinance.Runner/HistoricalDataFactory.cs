using System.Collections.Generic;
using System.Linq;
using YahooFinance.Runner.Helpers;
using YahooFinance.Runner.Models;
using YahooFinance.Runner.Models.Contracts.HistoricalData;

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
                Prices = GetPrices(historicalData.Timestamp, historicalData.Meta.Gmtoffset, historicalData.Indicators)
            };
        }

        private static IEnumerable<Price> GetPrices(IEnumerable<int> timestamps,
            int gmtoffset, IndicatorsContract indicators)
        {
            var quote = indicators.Quote.First();

            var enumerable = timestamps as int[] ?? timestamps.ToArray();

            var adjClose = GetAdjClose(indicators.Adjclose.First()).ToArray();

            for (var i = 0; i < enumerable.Count(); i++)
            {

                yield return new Price
                {
                    StartTime = DateTimeExtensions.FromUnixTimeSeconds(enumerable.ElementAt(i) + gmtoffset),
                    Open = quote.Open.ElementAt(i),
                    Close = quote.Close.ElementAt(i),
                    High = quote.High.ElementAt(i),
                    Low = quote.Low.ElementAt(i),
                    Volume = quote.Volume.ElementAt(i),
                    AdjClose = adjClose.ElementAt(i)
                };
            }
        }

        private static IEnumerable<float> GetAdjClose(AdjcloseContract contract)
        {
            foreach (var adjcloseContract in contract.Adjclose)
            {
                yield return adjcloseContract;
            }
        }

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
        //public static HistoricalData GetHistoricalData(this HistoricalDataContract contract)
        //{
        //    return new HistoricalData
        //    {
        //        Id = contract.Id,
        //        Prices = GetPrices(contract.Prices),
        //        EventsData = contract.EventsData,
        //        FirstTradeDate = contract.FirstTradeDate,
        //        IsPending = contract.IsPending,
        //        TimeZone = GetTimeZone(contract.TimeZone)
        //    };
        //}

        //private static Timezone GetTimeZone(TimezoneContract contractTimeZone)
        //{
        //    return new Timezone
        //    {
        //        GmtOffset = contractTimeZone.GmtOffset
        //    };
        //}

        //private static IEnumerable<Price> GetPrices(PriceContract[] contractPrices)
        //{
        //    foreach (var contractPrice in contractPrices)
        //    {
        //        yield return new Price
        //        {
        //            Adjclose = contractPrice.Adjclose,
        //            Close = contractPrice.Close,
        //            Date = DateTimeExtensions.FromUnixTimeSeconds(contractPrice.Date),
        //            High = contractPrice.High,
        //            Low = contractPrice.Low,
        //            Open = contractPrice.Open,
        //            Volume = contractPrice.Volume
        //        };
        //    }
        //}
    }
}
