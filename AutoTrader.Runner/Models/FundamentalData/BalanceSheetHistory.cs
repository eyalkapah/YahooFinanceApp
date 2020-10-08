using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class BalanceSheetHistory
    {
        public IEnumerable<BalanceSheetStatement> BalanceSheetStatements { get; set; }

        public int MaxAge { get; set; }
    }
}
