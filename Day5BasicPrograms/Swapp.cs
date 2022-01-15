using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicPrograms
{
    internal class Swapp
    {
        public static void swapnumbers()
        {
            int number1 ,number2, swapnum;
            String str1=Console.ReadLine();
            String str2 = Console.ReadLine();
            number1 = Convert.ToInt32(str1);
            number2 = Convert.ToInt32(str2);
            Console.WriteLine("number1={0} number2={1}",number1,number2);
            swapnum = number1;
            number1 = number2;
            number2 = swapnum;
            Console.WriteLine("After Swapping ");
            Console.WriteLine("number1={0} number2={1}", number1, number2);
        }
    }
}
