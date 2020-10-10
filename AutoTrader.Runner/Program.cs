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
    partial class Program
    {
        static async Task Main(string[] args)
        {
            IStockDataService yahooService = new YahooService();
            var priceManager = new PriceManager();

            var tickerManager = new TickerManager(yahooService, priceManager);

            

            var tickers = CsvExtensions.ReadConstituentsAsync("Data\\constituents.csv", new Dictionary<string, string>
            {
                {"Symbol", "Symbol"},
                {"Name", "Name"},
                {"Sector", "Sector"},
            }).Result;

            var profits = await tickerManager.GetProfitBySectorAsync(tickers, Interval.OneDay, new DateTime(2019, 1, 1), false);
        }
    }
}
