using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class InsiderHolders
    {
        public IEnumerable<Holder> Holders { get; set; }

        public int MaxAge { get; set; }
    }
}
