﻿using System.Text.Json.Serialization;

namespace YahooFinance.Runner.Models.Contracts.FundamentalData
{
    public class EarningshistoryContract
    {
        [JsonPropertyName("history")]
        public History1Contract[] History { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}