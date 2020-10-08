using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class InsiderHolders
    {
        public IEnumerable<Holder> Holders { get; set; }

        public int MaxAge { get; set; }
    }
}
