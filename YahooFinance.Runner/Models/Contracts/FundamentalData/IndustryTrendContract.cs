﻿using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class IndustryTrendContract
    {
        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }

        [JsonPropertyName("symbol")]
        public object Symbol { get; set; }

        [JsonPropertyName("peRatio")]
        public PeRatio1Contract PeRatio { get; set; }

        [JsonPropertyName("pegRatio")]
        public PegRatio2Contract PegRatio { get; set; }

        [JsonPropertyName("estimates")]
        public object[] Estimates { get; set; }
    }
}