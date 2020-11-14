using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoTrader.Models.Models;

namespace AutoTrader.Models.Helpers
{
    public static class DaysMomentumExtensions
    {
        public static void Print(this Dictionary<DayOfWeek, MomentumCount> momentumDays)
        {
            foreach (var keyValue in momentumDays)
            {
                var val = keyValue.Value;

                Console.WriteLine(keyValue.Key);

                Console.WriteLine($"Up: {val.UpCount} ({val.UpCountPercent}%)");
                Console.WriteLine($"Dn: {val.DownCount} ({val.DownCountPercent}%)");
                Console.WriteLine($"Revenue: {Math.Round(val.TotalRevenue, 2)}%");
                Console.WriteLine();
            }
        }
    }
}
