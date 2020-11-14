using System.Collections.Generic;
using System.Linq;
using AutoTrader.Models.Models;
using AutoTrader.Models.Models.HistoricalData;

namespace AutoTrader.Runner.Oscillators
{
    public class StochasticService
    {
        public List<Stochastic> Run(IEnumerable<Price> prices)
        {
            var list = new List<Stochastic>();

            var enumerable = prices as Price[] ?? prices.ToArray();

            if (!enumerable.Any() || enumerable.Count() <= 14)
                return null;

            for (int i = 14; i < enumerable.Count(); i++)
            {
                var lowest = enumerable.TakeLast(14).Min(c => c.Low);
                var highest = enumerable.TakeLast(14).Max(c => c.High);
                var recentClose = enumerable[i].Close;

                var val = ((recentClose - lowest) / (highest - lowest)) * 100;

                list.Add(new Stochastic
                {
                    Price = enumerable[i],
                    Value = val
                });
            }

            return list;
        }
    }
}
