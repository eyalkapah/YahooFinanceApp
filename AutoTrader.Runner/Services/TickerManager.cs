using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Runner.Enums;
using YahooFinance.Runner.Models;
using YahooFinance.Runner.Models.HistoricalData;
using YahooFinance.Runner.Services.API;

namespace YahooFinance.Runner.Services
{
    public class TickerManager
    {
        private readonly YahooService _service;

        public TickerManager(YahooService service)
        {
            _service = service;
        }

        public async Task<IEnumerable<Price>> GetHistoricalDataAsync(Ticker ticker, int numOfDays)
        {
            var symbol = ticker.Symbol;

            var result = await _service.GetHistoricalDataAsyncYahoo(Interval.OneDay,
                DateTime.Now.AddDays(-2 * numOfDays),
                DateTime.Now, symbol, true);

            return result.Prices.TakeLast(numOfDays).OrderBy(c => c.StartTime);
        }
    }
}
