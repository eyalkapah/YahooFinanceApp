using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class EsgScoresContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("totalEsg")]
        public ShortenedValueContract TotalEsg { get; set; }

        [JsonPropertyName("environmentScore")]
        public ShortenedValueContract EnvironmentScore { get; set; }

        [JsonPropertyName("socialScore")]
        public ShortenedValueContract SocialScore { get; set; }

        [JsonPropertyName("governanceScore")]
        public ShortenedValueContract GovernanceScore { get; set; }

        [JsonPropertyName("ratingYear")]
        public int RatingYear { get; set; }

        [JsonPropertyName("ratingMonth")]
        public int RatingMonth { get; set; }

        [JsonPropertyName("highestControversy")]
        public object HighestControversy { get; set; }

        [JsonPropertyName("peerCount")]
        public int PeerCount { get; set; }

        [JsonPropertyName("esgPerformance")]
        public string EsgPerformance { get; set; }

        [JsonPropertyName("peerGroup")]
        public string PeerGroup { get; set; }

        [JsonPropertyName("relatedControversy")]
        public string[] RelatedControversy { get; set; }

        [JsonPropertyName("peerEsgScorePerformance")]
        public ValueContract PeerEsgScorePerformance { get; set; }

        [JsonPropertyName("peerGovernancePerformance")]
        public ValueContract PeerGovernancePerformance { get; set; }

        [JsonPropertyName("peerSocialPerformance")]
        public ValueContract PeerSocialPerformance { get; set; }

        [JsonPropertyName("peerEnvironmentPerformance")]
        public ValueContract PeerEnvironmentPerformance { get; set; }

        [JsonPropertyName("peerHighestControversyPerformance")]
        public ValueContract PeerHighestControversyPerformance { get; set; }

        [JsonPropertyName("percentile")]
        public ShortenedValueContract Percentile { get; set; }

        [JsonPropertyName("environmentPercentile")]
        public object EnvironmentPercentile { get; set; }

        [JsonPropertyName("socialPercentile")]
        public object SocialPercentile { get; set; }

        [JsonPropertyName("governancePercentile")]
        public object GovernancePercentile { get; set; }

        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("alcoholic")]
        public bool Alcoholic { get; set; }

        [JsonPropertyName("animalTesting")]
        public bool AnimalTesting { get; set; }

        [JsonPropertyName("catholic")]
        public bool Catholic { get; set; }

        [JsonPropertyName("controversialWeapons")]
        public bool ControversialWeapons { get; set; }

        [JsonPropertyName("smallArms")]
        public bool SmallArms { get; set; }

        [JsonPropertyName("furLeather")]
        public bool FurLeather { get; set; }

        [JsonPropertyName("gambling")]
        public bool Gambling { get; set; }

        [JsonPropertyName("gmo")]
        public bool Gmo { get; set; }

        [JsonPropertyName("militaryContract")]
        public bool MilitaryContract { get; set; }

        [JsonPropertyName("nuclear")]
        public bool Nuclear { get; set; }

        [JsonPropertyName("pesticides")]
        public bool Pesticides { get; set; }

        [JsonPropertyName("palmOil")]
        public bool PalmOil { get; set; }

        [JsonPropertyName("coal")]
        public bool Coal { get; set; }

        [JsonPropertyName("tobacco")]
        public bool Tobacco { get; set; }
    }
}