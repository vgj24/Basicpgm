using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicPrograms
{
    internal class QuotientRemainder
    {
        public static void Quotientremainder()
        {
            int number1 = 5, number2 = 2;
            Console.WriteLine("Divisor=" + number1);
            Console.WriteLine("Divider=" + number2);
            int quotient = number1 / number2;
            double remainder =number1 % number2;
            Console.WriteLine("quotient=" + quotient);
            Console.WriteLine("remainder=" + remainder);



        }
    }
}
