using AutoTrader.Models.Models.HistoricalData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoTrader.Runner.Oscillators
{
    public class StochasticService
    {
        public List<StochasticPrice> Run(List<Price> prices)
        {
            if (!prices.Any() || prices.Count() < 13)
                return null;

            var list = new List<StochasticPrice>();

            for (int i = 13, j = 0; i < prices.Count(); i++, j++)
            {
                var activeData = prices.Skip(j).Take(14).ToList();

                var sPrice = new StochasticPrice
                {
                    High = activeData.Max(c => c.High),
                    Low = activeData.Min(c => c.Low),
                    Close = prices[i].Close,
                    StartTime = prices[i].StartTime,
                    Price = prices[i]
                };

                list.Add(sPrice);
            }

            return list;
        }
    }
}
