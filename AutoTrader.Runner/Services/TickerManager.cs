using AutoTrader.Models.Enums;
using AutoTrader.Models.Helpers;
using AutoTrader.Models.Interfaces;
using AutoTrader.Models.Models;
using AutoTrader.Models.Models.HistoricalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTrader.Runner.Services
{
    public class TickerManager
    {
        private readonly IStockDataService _service;
        private readonly PriceManager _priceManager;

        public TickerManager(IStockDataService service, PriceManager priceManager)
        {
            _service = service;
            _priceManager = priceManager;
        }

        public async Task<IEnumerable<Price>> GetHistoricalDataAsync(Ticker ticker, int numOfDays)
        {
            try
            {
                var result = await _service.GetHistoricalDataAsync(
                    ticker.Symbol,
                    DateTime.Now.AddDays(-2 * numOfDays),
                    DateTime.Now,
                    Interval.OneDay,
                    true);

                return result.Prices.TakeLast(numOfDays).OrderBy(c => c.StartTime);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to get historical data for {ticker.Symbol}.\r\n{e}");
                return null;
            }
        }

        public async Task<HistoricalData> GetHistoricalDataAsync(Ticker ticker, Interval frequency, DateTime startTime,
            bool includePrePost)
        {
            try
            {
                var symbol = ticker.Symbol;

                var result = await _service.GetHistoricalDataAsync(symbol, frequency, startTime, DateTime.MaxValue, includePrePost);

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to get historical data for {ticker.Symbol}.\r\n{e}");
                return null;
            }
        }

        public async Task<List<SectorProfit>> GetProfitBySectorAsync(List<Ticker> tickers, Interval frequency, DateTime startTime,
            bool includePrePost)
        {
            try
            {
                var sectorProfits = new Dictionary<string, SectorProfit>();

                var prices = new List<Price>();

                foreach (var ticker in tickers)
                {
                    var result = await GetHistoricalDataAsync(ticker, frequency, startTime, includePrePost);

                    if (result != null)
                        prices.AddRange(result.Prices);
                }

                var profits = _priceManager.CalculateProfits(prices);

                foreach (var p in profits)
                {
                    var sectorName = tickers.GetSector(p.Symbol);

                    sectorProfits.TryAdd(sectorName, new SectorProfit(sectorName));

                    sectorProfits[sectorName].TotalProfit += Math.Round(p.ProfitPercentage, 2);
                    sectorProfits[sectorName].Symbols.Add(p.Symbol);
                }

                return sectorProfits.Values.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        
    }
}
