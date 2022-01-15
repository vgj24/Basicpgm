using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicPrograms
{
    internal class PrimeFactor
    {
        public static void primefactor()
        {
            string str = Console.ReadLine();
            int number =Convert.ToInt32(str);
         
            Console.WriteLine("prime factors of " +number);
            Console.WriteLine("are : ");
            for (int i = 2; i <=number; i++)
            {
                if((number%i) == 0)
                {
                    int count = 0;
                    while((number%i) == 0)
                    {
                        number = number / i;
                        Console.Write(" " + i);
                        count++;
                    }
                }
            }

        }
    }
}
