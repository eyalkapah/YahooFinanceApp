using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class BalanceSheetHistory
    {
        public IEnumerable<BalanceSheetStatement> BalanceSheetStatements { get; set; }

        public int MaxAge { get; set; }
    }
}
