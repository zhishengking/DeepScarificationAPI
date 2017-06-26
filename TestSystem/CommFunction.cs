using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Configuration;

namespace TestSystem
{
    public static class CommFunction
    {
        public static string GetBaseAddress()
        {

            return ConfigurationManager.AppSettings["ApiUrl"];
        }
        public static string ConvertTimeToTimeStr(string timeStr)
        {
            if (string.IsNullOrEmpty(timeStr))
            {
                return null;
            }
            else
            {
                Regex reg = new Regex(@"[0-9][0-9,.]*");
                MatchCollection mc = reg.Matches(timeStr);
                Console.WriteLine(mc);
                string temp = "";
                foreach (Match m in mc)
                {
                    temp += m.Value;
                }
                var milliTime = Convert.ToInt64(temp);
                long timeTricks = new DateTime(1970, 1, 1).Ticks + milliTime * 10000 + TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).Hours * 3600 * (long)10000000;
                var time = new DateTime(timeTricks);
                return Convert.ToString(time);
            }
        }
    }
}