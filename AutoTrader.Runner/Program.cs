using System.Threading.Tasks;
using AutoTrader.Models.Interfaces;
using AutoTrader.Models.Models;
using AutoTrader.Runner.Services;
using AutoTrader.Yahoo.API;

namespace AutoTrader.Runner
{
    class Program
    {

        static async Task Main(string[] args)
        {
            IStockDataService yahooService = new YahooService();

            var ticker = new Ticker("MSFT");

            var tickerManager = new TickerManager(yahooService);

            var history = await tickerManager.GetHistoricalDataAsync(ticker, 30);



        }
    }
}
