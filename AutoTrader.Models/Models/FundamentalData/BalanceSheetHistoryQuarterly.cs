using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class BalanceSheetHistoryQuarterly
    {
        public IEnumerable<BalanceSheetStatement> BalanceSheetStatements { get; set; }

        public int MaxAge { get; set; }
    }
}
