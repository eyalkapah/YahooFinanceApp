using System;
using System.Threading.Tasks;
using YahooFinance.Runner.Enums;
using YahooFinance.Runner.Services;

namespace YahooFinance.Runner
{
    class Program
    {

        static async Task Main(string[] args)
        {
           var yfService = new YahooService();

           //var result = await yfService.GetHistoricalDataAsync(Frequency.OneDay
           //    , new DateTime(2020, 9, 1, 12, 0, 0)
           //    , new DateTime(2020, 9, 25, 12, 0, 0)
           //    , "MSFT");

           var result = await yfService.GetHistoricalDataAsyncYahoo(Interval.OneDay
               , new DateTime(2020, 9, 1, 12, 0, 0)
               , new DateTime(2020, 9, 25, 12, 0, 0)
               , "MSFT", true);

            Console.ReadLine();
        }

     
    }
}
