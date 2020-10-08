namespace AutoTrader.Models.Models
{
    public class Ticker
    {
        public string Symbol { get; }

        public Ticker(string symbol)
        {
            Symbol = symbol;
        }
    }
}
