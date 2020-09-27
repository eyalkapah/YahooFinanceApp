using System.Collections.Generic;

namespace YahooFinance.Runner.Models
{
    public class HistoricalData
    {
        public Meta Meta { get; set; }

        public IEnumerable<Price> Prices { get; set; }
    }
}
