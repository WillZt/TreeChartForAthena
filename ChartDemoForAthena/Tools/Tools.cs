using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChartDemoForAthena.Tools
{
    public class Tools
    {
        public static string ConvertTime(double d)
        {
            System.DateTime time = System.DateTime.MinValue;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            time = startTime.AddMilliseconds(d * 1000);
            return time.ToString("yyyy-MM-dd hh:mm:ss");
        }

        public static string SplitString(string origin, int len = 18)
        {
            if (origin.Length > 18)
            {
                origin = origin.Substring(0, 18) + "...";
            }
            return origin;
        }
    }
}