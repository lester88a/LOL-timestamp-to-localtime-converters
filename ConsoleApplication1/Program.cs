using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            long timestamp = 1465702102000;
            string localTime =  ConvertToLocalTime(timestamp);
            Console.WriteLine(localTime);
            Console.WriteLine();
        }
        
        public static string ConvertToLocalTime(long timestamp)
        {
            var posixTime = DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc);
            var time = posixTime.AddMilliseconds(timestamp);
            TimeZone localZone = TimeZone.CurrentTimeZone;
            var localTime = localZone.ToLocalTime(time);

            return localTime.ToString();
        }
    }
}
