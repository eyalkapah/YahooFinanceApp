using AutoTrader.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoTrader.Models.Enums;

namespace AutoTrader.Models.Helpers
{
    public static class ExtremaGroupExtensions
    {
        public static void Print(this ExtremaGroup extremaGroup)
        {
            Console.WriteLine($"AVG: {extremaGroup.Average}, ({extremaGroup.MinValue}, {extremaGroup.MaxValue}), Rank: {extremaGroup.Count}");
        }

        public static void Print(this IEnumerable<ExtremaGroup> extremaGroups, ExtremaType extremaType)
        {
            var list = extremaType == ExtremaType.Minimum
                ? extremaGroups.OrderByDescending(c => c.Average)
                : extremaGroups.OrderBy(c => c.Average);

            foreach (var extremaGroup in list)
            {
                extremaGroup.Print();
            }
        }
    }
}
