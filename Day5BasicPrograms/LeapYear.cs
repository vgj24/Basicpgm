using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicPrograms
{
    internal class LeapYear
    {
        public static void leapyr()
        {
            Console.WriteLine("Enter year (YYYY): ");
            String str = Console.ReadLine();
            int year = Convert.ToInt32(str);

            int a = year % 4;
            int b = year % 100;
            int c = year % 400;
            if ( a == 0)
            {
                if (b != 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine(year +" is leap year");
                    }
                    else
                    {
                        Console.WriteLine(year +" is not a leap year");
                    }
                    Console.WriteLine(year + " is not a leap year");
                }
                Console.WriteLine(year + " is not a leap year");
            }
            Console.WriteLine(year + " is not a leap year");

        }
    }
}

        