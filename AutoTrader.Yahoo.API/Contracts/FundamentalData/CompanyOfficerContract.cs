using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class CompanyOfficerContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("yearBorn")]
        public int YearBorn { get; set; }

        [JsonPropertyName("fiscalYear")]
        public int FiscalYear { get; set; }

        [JsonPropertyName("totalPay")]
        public ValueContract TotalPay { get; set; }

        [JsonPropertyName("exercisedValue")]
        public ValueContract ExercisedValue { get; set; }

        [JsonPropertyName("unexercisedValue")]
        public ValueContract UnexercisedValue { get; set; }
    }
}