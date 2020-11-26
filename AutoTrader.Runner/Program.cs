using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoTrader.Models.Enums;
using AutoTrader.Models.Helpers;
using AutoTrader.Models.Interfaces;
using AutoTrader.Models.Models;
using AutoTrader.Runner.Oscillators;
using AutoTrader.Runner.Services;
using AutoTrader.Yahoo.API;
using ScottPlot;

namespace AutoTrader.Runner
{
    class Program
    {
        private static PriceManager _priceManager;

        static async Task Main(string[] args)
        {
            IStockDataService yahooService = new YahooService();

            var data = await yahooService.GetFundamentalDataAsync("SPOT", assetProfile:true);

            var r = data.QuoteSummary.Result;

            foreach (var result in r)
            {
            }

            _priceManager = new PriceManager(yahooService);
            
            await TargilAsync();

            var tickerManager = new TickerManager(yahooService, _priceManager);

            var tickers = CsvExtensions.ReadConstituentsAsync("Data\\constituents.csv", new Dictionary<string, string>
            {
                {"Symbol", "Symbol"},
                {"Name", "Name"},
                {"Sector", "Sector"},
            }).Result;



            var msftTicker = tickerManager.GetTickerBySymbol(tickers, "MSFT");

            var prices = await _priceManager.GetPricesAsync(
                msftTicker,
                new DateTime(2020, 4, 13),
                new DateTime(2020, 6, 26),
                Interval.OneDay,
                false);


            var offsetPercent = 1;
            var stochasticService = new StochasticService();
            var vals = stochasticService.Run(prices);


            var plt = new ScottPlot.Plot(600, 400);

            plt.PlotSignal(vals.Select(c => c.Value).ToArray());

            plt.Title("Signal Plot Quickstart (5 million points)");
            plt.YLabel("Vertical Units");
            plt.XLabel("Horizontal Units");

            plt.SaveFig("Quickstart_Quickstart_Signal_5MillionPoints.png");

            return;

            //var offsetPercent = 0.5;

            //var supportPoints = _priceManager.GetSupportExtremaGroups(prices, ExtremaType.Minimum, offsetPercent);

            //var p = prices.Last();
            //Console.WriteLine($"Curret value: {p.Close}");

            //Console.WriteLine("Support Points");
            //supportPoints.Print(ExtremaType.Minimum);
            //Console.WriteLine();

            //Console.WriteLine("Reject Points");
            //rejectPoints.Print(ExtremaType.Maximum);


            var daysMomentum = _priceManager.GetDaysMomentum(prices);
            daysMomentum.Print();
        }

        private static async Task TargilAsync()
        {
            // NEED TO FIX THIS METHOD IT BROKEN SOMEWHERE IN MERGE
            var prices = await CsvExtensions.ReadCsvAsync(
                @"C:\Users\eykapah\Downloads\AMZN_09_07_2020-10_07_2020_1sec - Copy.csv",
                new Dictionary<string, string>
                {
                    {"Date_time", "StartTime"},
                    {"Open", "Open"},
                    {"Close", "Close"},
                    {"High", "High"},
                    {"Low", "Low"},
                    {"Volume", "Volume"}
                });

            // 1
            var maxVolume = prices.Max(p => p.Volume);
            Console.WriteLine($"#1: {maxVolume}");

            // 2
            var maxDiff = float.MinValue;

            foreach (var price in prices)
            {
                maxDiff = Math.Max(Math.Abs(price.High) - Math.Abs(price.Low), maxDiff);
            }

            Console.WriteLine($"#2: {maxDiff}");

            // 3
            var sortedPrices = prices.OrderBy(c => c.StartTime).ToList();

            var totalSeconds = (sortedPrices.Last().StartTime - sortedPrices.First().StartTime).TotalSeconds;

            Console.WriteLine($"#3: {totalSeconds}");

            // 4
            var groupedPrices = from p in prices
                                group new { p.StartTime, p.Volume }
                                by p.StartTime.ToString("g")
                                into newPrice
                                select newPrice;

            var max = double.MinValue;

            foreach (var groupedPrice in groupedPrices)
            {
                max = Math.Max(groupedPrice.Sum(c => c.Volume), max);
            }

            Console.WriteLine($"#4: Max volume for one minute: {max}");


            // 5
            var tenMinutesCandle = from p in prices
                                   let newCandle = p.StartTime.MakeCandleOf(10)
                                   group new { p.StartTime, p.High, p.Low}
                                   by newCandle
                                into newPrice
                                   select newPrice;

            var maxCloseOpenDiff = double.MinValue;

            foreach (var g in tenMinutesCandle)
            {
                var maxHigh = g.Max(c => c.High);
                var minLow = g.Min(c => c.Low);

                maxCloseOpenDiff = Math.Max(maxHigh - minLow, maxCloseOpenDiff);
            }

            Console.WriteLine($"#5: Max Close % Open diff for 10 minute candles: {maxCloseOpenDiff}");

            var fiveYearsPrices = await CsvExtensions.ReadCsvAsync(@"Data\\all_stocks_5yr.csv", new Dictionary<string, string>
            {
                {"date", "StartTime"},
                {"open", "Open"},
                {"high", "High"},
                {"low", "Low"},
                {"close", "Close"},
                {"volume", "Volume"},
                {"Name", "Symbol"}
            });

            // 6

            var fiveYearsGroup = from p in fiveYearsPrices
                     group p by new
                {
                    p.StartTime.Year,
                    p.StartTime.Month
                }
                into yearMonthPrice
                let year = yearMonthPrice.Key.Year
                let month = yearMonthPrice.Key.Month
                let priceList = yearMonthPrice.ToList()
                let profits = _priceManager.CalculateProfits(yearMonthPrice.ToList())
                select new
                {
                    Year = year,
                    Month = month,
                    Prices = priceList,
                    Profits = profits,
                    Avg = profits.Select(c => c.ProfitPercentage).Sum() / profits.Count
                };

            var minAvg = fiveYearsGroup.Min(c => c.Avg);

            var minRecord = fiveYearsGroup.First(c => c.Avg == minAvg);

            Console.WriteLine($"#6: Lowest average:  {minAvg}, Date: {minRecord.Year}-{minRecord.Month}");

            // 7
           var specificPrices = fiveYearsPrices.OrderBy(c => c.StartTime)
                .Where(c => c.StartTime.Year >= 2013 && c.StartTime.Year < 2015).ToList();

            var top100Stocks = _priceManager.CalculateProfits(specificPrices)
                .OrderByDescending(c => c.ProfitPercentage)
                .Take(100)
                .ToList();

            Console.WriteLine($"#7: Top 100 stocks for 2013-2015");

            top100Stocks.ForEach(c => Console.WriteLine($"{c.Symbol} ({c.ProfitPercentage})"));

            // 8
            var topStocks = top100Stocks.Select(c => c.Symbol).ToList();

            var januaryStocks = fiveYearsPrices
                .Where(c => c.StartTime.Month == 1 && c.StartTime.Year == 2015 && topStocks.Contains(c.Symbol)).ToList();

            var januaryProfitsTop100 = _priceManager.CalculateProfits(januaryStocks).Average();

            var januaryAllStocks = fiveYearsPrices
                .Where(c => c.StartTime.Month == 1 && c.StartTime.Year == 2015).ToList();

            var januaryProfitsAll = _priceManager.CalculateProfits(januaryAllStocks).Average();

            Console.WriteLine("#8: Profits in January 2015");
            Console.WriteLine($"Average top 100: {januaryProfitsTop100}");
            Console.WriteLine($"All stocks: {januaryProfitsAll}");

            // 9
            var year2015 = fiveYearsPrices
                .Where(c => c.StartTime.Year == 2015 && topStocks.Contains(c.Symbol)).ToList();

            var year2015ProfitAvg = _priceManager.CalculateProfits(year2015).Average();

            var year2015AllStocks = fiveYearsPrices.Where(c => c.StartTime.Year == 2015).ToList();

            var year2015AllProfitAvg = _priceManager.CalculateProfits(year2015AllStocks).Average();

            Console.WriteLine($"#9: Profits in 2015");
            Console.WriteLine($"Top 100 stocks: {year2015ProfitAvg}");
            Console.WriteLine($"All stocks: {year2015AllProfitAvg}");
        }


    }


}
