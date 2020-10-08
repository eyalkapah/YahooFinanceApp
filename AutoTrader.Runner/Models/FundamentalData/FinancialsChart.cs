using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class FinancialsChart
    {
        public IEnumerable<Yearly> Yearly { get; set; }

        public IEnumerable<Quarterly1> Quarterly { get; set; }
    }
}
