using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class InsiderTransactions
    {
        public IEnumerable<Transaction> Transactions { get; set; }

        public int MaxAge { get; set; }
    }
}
