using System;
using System.Collections.Generic;
using System.Text;

namespace Extension
{
   public static class Extensions
    {
        public static int WordCount(string myString)
        {
            int wordNumber = myString.Split(' ').Length;
            return wordNumber;
        }

        public static int WordCountExtension(this string myString)
        {
            int wordNumber = myString.Split(' ').Length;
            return wordNumber;
        }

        public static DateTime RoundToHalfHour(this DateTime input)
        {
            DateTime dt = new DateTime(input.Year, input.Month, input.Day, input.Hour, input.Minute, 0);
            if (input.Minute == 0)
            {
                return input;
            }
            if (input.Minute >= 1 && input.Minute <= 30)
            {
                var result = dt.AddMinutes(30 - input.Minute);
                return result;
            }
            else
            {
                var result = dt.AddMinutes(60 - input.Minute);
                return result;
            }
        }
    }
}
