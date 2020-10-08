using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class InsiderTransactions
    {
        public IEnumerable<Transaction> Transactions { get; set; }

        public int MaxAge { get; set; }
    }
}
