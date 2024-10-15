namespace MyApp.Extensions
{
    public static class DateTimeExtensions
    {
        public static long MillisecondsTimestamp(this DateTime date)
        {
            DateTime baseDate = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return (long)(date.ToUniversalTime()-baseDate).TotalMilliseconds;
        }

        public static long MillisecondsTimestampSubtract(this DateTime date, DateTimeExtensions baseDate)
        {
            return (long)(date.ToUniversalTime()-baseDate).TotalMilliseconds;
        }
    }
}