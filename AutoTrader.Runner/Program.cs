using System.Collections.Generic;
using System.Threading.Tasks;
using AutoTrader.Models.Helpers;
using AutoTrader.Models.Interfaces;
using AutoTrader.Models.Models;
using AutoTrader.Models.Models.HistoricalData;
using AutoTrader.Runner.Services;
using AutoTrader.Yahoo.API;
using System.Linq;

namespace AutoTrader.Runner
{
    class Program
    {

        static async Task Main(string[] args)
        {
            IStockDataService yahooService = new YahooService();

            var tickerManager = new TickerManager(yahooService);

            var tickers = CsvExtensions.ReadConstituentsAsync("Data\\constituents.csv", new Dictionary<string, string>
            {
                {"Symbol", "Symbol"},
                {"Name", "Name"},
                {"Sector", "Sector"},
            }).Result;

            var history = new List<Price>();

            foreach (var ticker in tickers)
            {
                var result = await tickerManager.GetHistoricalDataAsync(ticker, 30);

                if (result != null)
                    history.AddRange(result);
            }

            var priceManager = new PriceManager();

            var profits = priceManager.CalculateProfits(history);

            var orderedProfits = profits.OrderBy(c => c.Symbol);
            var buyStocks = profits.GetTopProfitableStocks(50);

            var aap = history.Where(c => c.Symbol.Equals("AAP"));
        }
    }
}
