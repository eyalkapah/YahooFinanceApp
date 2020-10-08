using System.Collections.Generic;

namespace YahooFinance.Runner.Models.HistoricalData
{
    public class HistoricalData
    {
        public Meta Meta { get; set; }

        public IEnumerable<Price> Prices { get; set; }
    }
}
