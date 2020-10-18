using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoTrader.Models.Helpers;
using AutoTrader.Models.Interfaces;
using AutoTrader.Models.Models;
using AutoTrader.Models.Models.HistoricalData;
using AutoTrader.Runner.Services;
using AutoTrader.Yahoo.API;
using System.Linq;
using AutoTrader.Models.Enums;

namespace AutoTrader.Runner
{
    class Program
    {

        static async Task Main(string[] args)
        {
            IStockDataService yahooService = new YahooService();

            var priceManager = new PriceManager(yahooService);

            var tickerManager = new TickerManager(yahooService, priceManager);

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

            
            var offsetPercent = 0.5;

            var supportPoints = priceManager.CalculateExtremePoints(prices, ExtremaType.Minimum, offsetPercent);
            var rejectPoints = priceManager.CalculateExtremePoints(prices, ExtremaType.Maximum, offsetPercent);

        }
    }

    
}
