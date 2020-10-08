using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoTrader.Models.Enums;
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
            var symbol = ticker.Symbol;

            var result = await _service.GetHistoricalDataAsync(Interval.OneDay,
                DateTime.Now.AddDays(-2 * numOfDays),
                DateTime.Now, symbol, true);

            return result.Prices.TakeLast(numOfDays).OrderBy(c => c.StartTime);
        }
    }
}
