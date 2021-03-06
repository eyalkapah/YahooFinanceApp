﻿using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.Options
{

    public class OptionsContract
    {
        [JsonPropertyName("optionChain")]
        public OptionChainContract OptionChain { get; set; }
    }
}
