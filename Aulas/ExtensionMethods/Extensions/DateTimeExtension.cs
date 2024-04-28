using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions
{
    internal static class DateTimeExtension
    {
        public static String ElapsedTime(this DateTime thisobj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisobj); 

            if (duration.TotalHours < 24.0) {
            
                return duration.TotalHours.ToString("F1" + "Hours");

            }
            else
            {
                return duration.TotalDays.ToString("F1" + "Days");
            }
        }
    }
}
