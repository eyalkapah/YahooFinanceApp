using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YahooFinance.Runner.Models.Contracts.HistoricalData
{
    public class TradingPeriodContract
    {
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("end")]
        public int End { get; set; }

        [JsonPropertyName("gmtoffset")]
        public int Gmtoffset { get; set; }
    }
}
