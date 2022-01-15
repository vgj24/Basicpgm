using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicPrograms
{
    internal class HamonyNumber
    {
        public static void harmony()
        {
            int i;
            double var=0.0;
            Console.WriteLine("Number to get harmonic number");
            int number=Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=number;i++)
            {
                Console.Write("1/{0} +",i);
                var += 1/(float)i;

                //var+=1/(float)i;
            }
            Console.WriteLine("\n sum of series upto number {0} terms is : {1} \n",number,var);
        }
    }
}
