using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoTrader.Models.Models;
using AutoTrader.Models.Models.HistoricalData;

namespace AutoTrader.Models.Helpers
{
    public static class CsvExtensions
    {
        public static void WriteCsv(this IEnumerable<Price> prices, string filePath)
        {
            var csv = new StringBuilder();

            csv.AppendLine("Date,Symbol,Open,High,Low,Close,Volume,Dividends,Stock Splits");

            foreach (var p in prices)
            {
                csv.AppendLine($"{p.StartTime:yyyy-MM-dd},{p.Symbol},{p.Open},{p.High},{p.Low},{p.Close},{p.Volume},{p.Dividends},{p.StockSplits}");
            }

            File.WriteAllText(filePath, csv.ToString());
        }

        public static List<Ticker> ReadConstituents(string filePath, Dictionary<string, string> map)
        {
            var lines = File.ReadAllLines(filePath);

            var headers = lines[0].Split(',');

            var tickers = new List<Ticker>();

            foreach (var line in lines.Skip(1))
            {
                var lineSplit = line.Split(',');

                var symbol = string.Empty;
                var name = string.Empty;
                var sector = string.Empty;

                for (var i = 0; i < lineSplit.Length; i++)
                {

                    if (headers.Length < i)
                        continue;

                    var header = headers[i];

                    map.TryGetValue(header, out var key);

                    if (string.IsNullOrEmpty(key))
                        continue;


                    if (key.Equals("Symbol"))
                        symbol = lineSplit[i];
                    else if (key.Equals("Name"))
                        name = lineSplit[i];
                    else if (key.Equals("Sector"))
                        sector = lineSplit[i];
                }

                if (!string.IsNullOrEmpty(symbol))
                {
                    tickers.Add(new Ticker(symbol)
                    {
                        Name = name,
                        Sector = sector
                    });
                }
            }

            return tickers;
        }

        public static List<Price> ReadCsv(string filePath, Dictionary<string, string> map, string ticker = null)
        {
            var lines = File.ReadAllLines(filePath);

            var headers = lines[0].Split(',');

            var prices = new List<Price>();

            foreach (var line in lines.Skip(1))
            {
                var lineSplit = line.Split(',');

                DateTime date = default;
                var symbol = !string.IsNullOrEmpty(ticker) ? ticker : string.Empty;
                string open = default;
                string high = default;
                string low = default;
                string close = default;
                string volume = default;
                string dividends = default;
                string splits = default;

                for (var i = 0; i < lineSplit.Length; i++)
                {
                    if (headers.Length < i)
                        continue;

                    var header = headers[i];

                    map.TryGetValue(header, out var key);

                    if (string.IsNullOrEmpty(key))
                        continue;

                    if (key.Equals("StartTime"))
                        DateTime.TryParse(lineSplit[i], out date);
                    else if (key.Equals("Symbol"))
                        symbol = lineSplit[i];
                    else if (key.Equals("Open"))
                        open = lineSplit[i];
                    else if (key.Equals("High"))
                        high = lineSplit[i];
                    else if (key.Equals("Low"))
                        low = lineSplit[i];
                    else if (key.Equals("Close"))
                        close = lineSplit[i];
                    else if (key.Equals("Volume"))
                        volume = lineSplit[i];
                    else if (key.Equals("Dividends"))
                        dividends = lineSplit[i];
                    else if (key.Equals("StockSplits"))
                        splits = lineSplit[i];
                }

                prices.AddPrice(date, symbol, open, high, low, close, volume, dividends, splits);
            }

            return prices;
        }

        public static List<Price> ReadCsv(string filePath)
        {
            var prices = new List<Price>();

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines.Skip(1))
            {
                var lineSplit = line.Split(',');

                DateTime.TryParse(lineSplit[0], out var date);
                var symbol = lineSplit[1];
                var open = lineSplit[2];
                var high = lineSplit[3];
                var low = lineSplit[4];
                var close = lineSplit[5];
                var volume = lineSplit[6];

                var dividends = "0";
                if (lineSplit.Length >= 8)
                    dividends = lineSplit[7];

                var splits = "0";
                if (lineSplit.Length >= 9)
                    splits = lineSplit[8];

                prices.AddPrice(date, symbol, open, high, low, close, volume, dividends, splits);
            }

            return prices;
        }


    }
}
