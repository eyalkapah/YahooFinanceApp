using System.Collections.Generic;

namespace AutoTrader.Models.Models.FundamentalData
{
    public class CashFlowStatementHistory
    {
        public IEnumerable<CashFlowStatement> CashFlowStatements { get; set; }

        public int MaxAge { get; set; }
    }
}
