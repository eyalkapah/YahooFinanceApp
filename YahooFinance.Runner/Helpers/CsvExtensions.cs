﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Runner.Models;
using YahooFinance.Runner.Models.HistoricalData;

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

        public static async Task ReadCsvAsync(this List<Price> prices, string filePath)
        {
            //var json = await File.ReadAllTextAsync(filePath);

            var lines = await File.ReadAllLinesAsync(filePath);

            foreach (var line in lines.Skip(1))
            {
                var lineSplit = line.Split(',');

                DateTime.TryParse(lineSplit[0], out var date);
                var open = lineSplit[1];
                var high = lineSplit[2];
                var low = lineSplit[3];
                var close = lineSplit[4];
                var volume = lineSplit[5];
                var dividends = lineSplit[6];
                var splits = lineSplit[7];

                prices.Add(new Price
                {
                    StartTime = date,
                    Open = Convert.ToSingle(open),
                    High = Convert.ToSingle(high),
                    Low = Convert.ToSingle(low),
                    Close = Convert.ToSingle(close),
                    Volume = Convert.ToDouble(volume),
                    Dividends = Convert.ToSingle(dividends),
                    StockSplits = Convert.ToInt32(splits)
                });
            }
        }
    }
}