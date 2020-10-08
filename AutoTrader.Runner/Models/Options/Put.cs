namespace YahooFinance.Runner.Models.Options
{
    public class Put
    {
        public string ContractSymbol { get; set; }

        public float Strike { get; set; }

        public string Currency { get; set; }

        public float LastPrice { get; set; }

        public float Change { get; set; }

        public float PercentChange { get; set; }

        public int Volume { get; set; }

        public int OpenInterest { get; set; }

        public float Bid { get; set; }

        public float Ask { get; set; }

        public string ContractSize { get; set; }

        public int Expiration { get; set; }

        public int LastTradeDate { get; set; }

        public float ImpliedVolatility { get; set; }

        public bool InTheMoney { get; set; }
    }
}