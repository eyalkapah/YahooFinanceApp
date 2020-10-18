namespace AutoTrader.Models.Helpers
{
    public static class MathExtensions
    {
        public static bool IsMinima(this float number, float before, float after)
        => before > number && number < after;

        public static bool IsMaxima(this float number, float before, float after)
            => number > before && number > after;

        public static bool IsBetween(this float number, double min, double max)
            => number > min && number < max;
    }
}
