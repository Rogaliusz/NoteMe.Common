using System;

namespace NoteMe.Common.Extensions
{
    public static class DateTimeExtensions
    {
        public static long ToTimestamp(this DateTime value)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var time = value.Subtract(new TimeSpan(epoch.Ticks));

            return time.Ticks / 10000;
        }
    }
}
