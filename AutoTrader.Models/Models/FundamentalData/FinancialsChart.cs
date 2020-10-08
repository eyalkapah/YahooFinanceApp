using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class FinancialsChart
    {
        public IEnumerable<Yearly> Yearly { get; set; }

        public IEnumerable<Quarterly1> Quarterly { get; set; }
    }
}
