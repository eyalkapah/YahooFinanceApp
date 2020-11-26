﻿using System;
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

        static async Task Main(string[] args)
        {
            IStockDataService yahooService = new YahooService();

            var data = await yahooService.GetFundamentalDataAsync("SPOT", assetProfile:true);

            var r = data.QuoteSummary.Result;

            foreach (var result in r)
            {
            }

            var priceManager = new PriceManager(yahooService);

            var tickerManager = new TickerManager(yahooService, priceManager);

            

            while (true)
            {
                await Task.Delay(1000);
                var pricesMSFT = await priceManager.GetPricesAsync(new Ticker("MSFT"), DateTime.Now.AddDays(-1),
                    DateTime.Now, Interval.OneDay, false);

                Console.WriteLine(pricesMSFT.Last().Close);
            }

            var tickers = CsvExtensions.ReadConstituentsAsync("Data\\constituents.csv", new Dictionary<string, string>
            {
                {"Symbol", "Symbol"},
                {"Name", "Name"},
                {"Sector", "Sector"},
            }).Result;



            var msftTicker = tickerManager.GetTickerBySymbol(tickers, "MSFT");

            var prices = await priceManager.GetPricesAsync(
                msftTicker,
                new DateTime(2020, 4, 13),
                DateTime.MaxValue,
                Interval.OneDay,
                false);

            var stochasticService = new StochasticService();
            var vals = stochasticService.Run(prices);


            var plt = new ScottPlot.Plot(600, 400);

            plt.PlotSignal(vals.Select(c => c.Value).ToArray());

            plt.Title("Signal Plot Quickstart (5 million points)");
            plt.YLabel("Vertical Units");
            plt.XLabel("Horizontal Units");

            plt.SaveFig("Quickstart_Quickstart_Signal_5MillionPoints.png");

            return;

            var offsetPercent = 0.5;

            var supportPoints = priceManager.GetSupportExtremaGroups(prices, ExtremaType.Minimum, offsetPercent);

            var rejectPoints = priceManager.GetRejectExtremaGroups(prices, offsetPercent);
            //var rejectPoints = priceManager.GetSupportExtremaGroups(prices, ExtremaType.Maximum, offsetPercent);

            var p = prices.Last();
            Console.WriteLine($"Curret value: {p.Close}");

            Console.WriteLine("Support Points");
            supportPoints.Print(ExtremaType.Minimum);
            Console.WriteLine();

            Console.WriteLine("Reject Points");
            rejectPoints.Print(ExtremaType.Maximum);

            var daysMomentum = priceManager.GetDaysMomentum(prices);
            daysMomentum.Print();
        }
    }


}
