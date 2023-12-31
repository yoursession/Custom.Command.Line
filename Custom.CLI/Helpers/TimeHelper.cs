﻿namespace Custom.Cli.Helpers
{
    internal class TimeHelper
    {
        private static readonly DateTime _unixTime = new(1970, 1, 1, 0, 0, 0);

        public static long CurrentTimestamp()
        {
            return (long)(DateTime.UtcNow - _unixTime).TotalSeconds;
        }

        public static long ToTimestamp(DateTime time)
        {
            if (time.Kind != DateTimeKind.Utc)
            {
                time = time.ToUniversalTime();
            }
            return (long)(time - _unixTime).TotalSeconds;
        }

        public static DateTime ToTime(long ts)
        {
            return _unixTime.AddSeconds(ts).ToLocalTime();
        }
    }
}