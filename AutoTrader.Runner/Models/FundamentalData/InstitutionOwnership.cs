using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class InstitutionOwnership
    {
        public int MaxAge { get; set; }

        public IEnumerable<OwnershipList1> OwnershipList { get; set; }
    }
}
