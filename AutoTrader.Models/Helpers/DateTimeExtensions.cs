using System;

namespace AutoTrader.Models.Helpers
{
    public static class DateTimeExtensions
    {
        public static decimal ToUnixTimeSeconds(this DateTime dateTime)
        {
            var dto = new DateTimeOffset(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute,
                dateTime.Second, TimeSpan.Zero);

            return dto.ToUnixTimeSeconds();
        }

        public static DateTime FromUnixTimeSeconds(long seconds)
        {
            var dto = DateTimeOffset.FromUnixTimeSeconds(seconds);
            return dto.DateTime;
        }
    }
}
