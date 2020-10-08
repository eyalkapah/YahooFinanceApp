using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class AssetProfileContract
    {
        [JsonPropertyName("address1")]
        public string Address1 { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("zip")]
        public string Zip { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("website")]
        public string Website { get; set; }

        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        [JsonPropertyName("sector")]
        public string Sector { get; set; }

        [JsonPropertyName("longBusinessSummary")]
        public string LongBusinessSummary { get; set; }

        [JsonPropertyName("fullTimeEmployees")]
        public int FullTimeEmployees { get; set; }

        [JsonPropertyName("companyOfficers")]
        public CompanyOfficerContract[] CompanyOfficers { get; set; }

        [JsonPropertyName("auditRisk")]
        public int AuditRisk { get; set; }

        [JsonPropertyName("boardRisk")]
        public int BoardRisk { get; set; }

        [JsonPropertyName("compensationRisk")]
        public int CompensationRisk { get; set; }

        [JsonPropertyName("shareHolderRightsRisk")]
        public int ShareHolderRightsRisk { get; set; }

        [JsonPropertyName("overallRisk")]
        public int OverallRisk { get; set; }

        [JsonPropertyName("governanceEpochDate")]
        public int GovernanceEpochDate { get; set; }

        [JsonPropertyName("compensationAsOfEpochDate")]
        public int CompensationAsOfEpochDate { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}