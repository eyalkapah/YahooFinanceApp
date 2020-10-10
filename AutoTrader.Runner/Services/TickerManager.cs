using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoTrader.Models.Enums;
using AutoTrader.Models.Helpers;
using AutoTrader.Models.Interfaces;
using AutoTrader.Models.Models;
using AutoTrader.Models.Models.HistoricalData;

namespace AutoTrader.Runner.Services
{
    public class TickerManager
    {
        private readonly IStockDataService _service;

        public TickerManager(IStockDataService service)
        {
            _service = service;
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

        public Ticker GetTickerBySymbol(IEnumerable<Ticker> tickers, string symbol) => tickers.GetBySymbol(symbol);
    }
}
