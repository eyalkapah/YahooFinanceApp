using System.Collections.Generic;
using System.Linq;
using AutoTrader.Models.Models.HistoricalData;
using AutoTrader.Oscillators.Models;

namespace AutoTrader.Oscillators.Oscillators
{
    public class StochasticOsc
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

                if (list.Count >= 3)
                {
                    sPrice.SlowValue = list.TakeLast(3).Average(c => c.Value);
                }
            }

            return list;
        }
    }
}
