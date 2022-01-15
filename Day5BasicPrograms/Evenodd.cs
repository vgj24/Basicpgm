using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicPrograms
{
    internal class Evenodd
    {
        
        public static void evenodd()
        {
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);

            if (num%2==0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }

    }
}
