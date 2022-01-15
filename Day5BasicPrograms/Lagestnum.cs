using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicPrograms
{
    internal class Lagestnum
    {
        public static void lagenumber()
       {
            int number1, number2, number3,max;
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            number3 = int.Parse(Console.ReadLine());

            if (number1>number2)
            {
                max = number1;
            }
            else
            {
                max = number2;
            }
            if (max>number3)
            {
                Console.WriteLine(max + "is largest number");
            }
            else
            {
                Console.WriteLine(number3 + "is largest number");
            }
        }

    }

}

