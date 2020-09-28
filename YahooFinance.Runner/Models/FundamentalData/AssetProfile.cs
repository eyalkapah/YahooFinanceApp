using System.Collections.Generic;

namespace YahooFinance.Runner.Models.FundamentalData
{
    public class AssetProfile
    {
        public string Address1 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }

        public string Industry { get; set; }

        public string Sector { get; set; }

        public string LongBusinessSummary { get; set; }

        public int FullTimeEmployees { get; set; }

        public IEnumerable<CompanyOfficer> CompanyOfficers { get; set; }

        public int AuditRisk { get; set; }

        public int BoardRisk { get; set; }

        public int CompensationRisk { get; set; }

        public int ShareHolderRightsRisk { get; set; }
        
        public int OverallRisk { get; set; }

        public int GovernanceEpochDate { get; set; }

        public int CompensationAsOfEpochDate { get; set; }

        public int MaxAge { get; set; }
    }
}
