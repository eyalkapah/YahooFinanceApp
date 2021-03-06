﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AutoTrader.Yahoo.API.Contracts.HistoricalData
{
    public class EventsContract
    {
        [JsonPropertyName("dividends")]
        public Dictionary<string, DividendContract> Dividends { get; set; }

        [JsonPropertyName("splits")]
        public Dictionary<string, SplitContract> Splits { get; set; }

    }
}
