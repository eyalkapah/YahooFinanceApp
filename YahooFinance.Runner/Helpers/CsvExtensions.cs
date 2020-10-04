using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Runner.Models;

namespace YahooFinance.Runner.Helpers
{
    public static class CsvExtensions
    {
        public static async Task WriteCsvAsync(this IEnumerable<Price> prices, string filePath)
        {
            var csv = new StringBuilder();

            csv.AppendLine("Date,Open,High,Low,Close,Volume,Dividends,Stock Splits");

            foreach (var p in prices)
            {
                csv.AppendLine($"{p.StartTime:yyyy-MM-dd},{p.Open},{p.High},{p.Low},{p.Close},{p.Volume},{p.Dividends},{p.StockSplits}");
            }

            await File.WriteAllTextAsync(filePath, csv.ToString());
        }
    }
}
