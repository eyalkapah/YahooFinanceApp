using AutoTrader.Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace AutoTrader.Models.Helpers
{
    public static class SectorProfitsExtensions
    {
        public static SectorProfit GetSector(this IEnumerable<SectorProfit> sectorProfits, string sector)
            => sectorProfits.First(c => c.Sector.Equals(sector));
    }
}
