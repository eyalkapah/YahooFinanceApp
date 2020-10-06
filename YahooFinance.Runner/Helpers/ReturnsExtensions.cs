using System;
using System.Collections.Generic;
using System.Linq;
using YahooFinance.Runner.Models;

namespace YahooFinance.Runner.Helpers
{
    public static class ReturnsExtensions
    {
        public static IEnumerable<Returns> Sort(this IEnumerable<Returns> returns, bool ascending = true)
        {
            return !@ascending
                ? returns.OrderByDescending(c => c.ReturnPercentage)
                : returns.OrderBy(c => c.ReturnPercentage);
        }

        public static double Average(this IEnumerable<Returns> returns)
        {
            var enumerable = returns as Returns[] ?? returns.ToArray();

            if (!enumerable.Any())
                return 0;

            return Math.Round(enumerable.Sum(c => c.ReturnPercentage) /
                enumerable.Count(),2);
        }


    }
}
