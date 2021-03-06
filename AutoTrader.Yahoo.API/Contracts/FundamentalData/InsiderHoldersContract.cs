﻿using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.FundamentalData
{
    public class InsiderHoldersContract
    {
        [JsonPropertyName("holders")]
        public HolderContract[] Holders { get; set; }

        [JsonPropertyName("maxAge")]
        public int MaxAge { get; set; }
    }
}