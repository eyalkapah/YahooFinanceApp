using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class BalanceSheetHistoryQuarterly
    {
        public IEnumerable<BalanceSheetStatement> BalanceSheetStatements { get; set; }

        public int MaxAge { get; set; }
    }
}
