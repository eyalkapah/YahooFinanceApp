using System.Collections.Generic;

namespace AutoTrader.Models.Models
{
    public class SectorProfit
    {
        public double TotalProfit { get; set; }

        public double AverageProfit => TotalProfit / Symbols.Count;

        public List<string> Symbols { get; set; }

        public string Sector { get; set; }

        public SectorProfit(string sector)
        {
            Symbols = new List<string>();

            Sector = sector;
        }

    }
}