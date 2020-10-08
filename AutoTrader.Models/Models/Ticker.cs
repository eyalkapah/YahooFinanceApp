namespace AutoTrader.Models.Models
{
    public class Ticker
    {
        public string Symbol { get; }
        public string Name { get; set; }
        public string Sector { get; set; }

        public Ticker(string symbol)
        {
            Symbol = symbol;
        }
    }
}
