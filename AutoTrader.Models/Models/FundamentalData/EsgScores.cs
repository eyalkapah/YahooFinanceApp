namespace AutoTrader.Models.Models.FundamentalData
{
    public class EsgScores
    {
        public int MaxAge { get; set; }

        public ShortenedValue TotalEsg { get; set; }

        public ShortenedValue EnvironmentScore { get; set; }

        public ShortenedValue SocialScore { get; set; }

        public ShortenedValue GovernanceScore { get; set; }

        public int RatingYear { get; set; }

        public int RatingMonth { get; set; }

        public object HighestControversy { get; set; }

        public int PeerCount { get; set; }

        public string EsgPerformance { get; set; }

        public string PeerGroup { get; set; }

        public string[] RelatedControversy { get; set; }

        public Value PeerEsgScorePerformance { get; set; }

        public Value PeerGovernancePerformance { get; set; }

        public Value PeerSocialPerformance { get; set; }

        public Value PeerEnvironmentPerformance { get; set; }

        public Value PeerHighestControversyPerformance { get; set; }

        public ShortenedValue Percentile { get; set; }

        public object EnvironmentPercentile { get; set; }

        public object SocialPercentile { get; set; }

        public object GovernancePercentile { get; set; }

        public bool Adult { get; set; }

        public bool Alcoholic { get; set; }

        public bool AnimalTesting { get; set; }

        public bool Catholic { get; set; }

        public bool ControversialWeapons { get; set; }

        public bool SmallArms { get; set; }

        public bool FurLeather { get; set; }

        public bool Gambling { get; set; }

        public bool Gmo { get; set; }

        public bool MilitaryContract { get; set; }

        public bool Nuclear { get; set; }

        public bool Pesticides { get; set; }

        public bool PalmOil { get; set; }

        public bool Coal { get; set; }

        public bool Tobacco { get; set; }
    }
}
