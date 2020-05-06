using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    class Methods
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //  The user will enter 
                //      Y, M, or D to get the Year, Month or Day of the current date
                //      h, m, or s to get the hour, minute, or second of the current time
                string part = Utils.GetInput("What part of the date are you interested in: ");

                //  this method will take the part of the date requested and from the current date return the units for that date part or time part
                int timeUnit = GetDatePart(part);
                if (timeUnit == -1)
                    break;
                Console.WriteLine($"The time part represented by {part} is {timeUnit}");

            }
        }

        private static int GetDatePart(string today)
        {
            int num;
            var now = DateTime.Now;
            switch (today)
            {
                case "Y":
                    num = now.Year;
                    break;
                case "M":
                    num = now.Month;
                    break;
                case "D":
                    num = now.Day;
                    break;
                case "h":
                    num = now.Hour;
                    break;
                case "m":
                    num = now.Minute;
                    break;
                case "s":
                    num = now.Second;
                    break;
                default:
                    num = -1;
                    break;
            }
            return num;
        }
    }
}
