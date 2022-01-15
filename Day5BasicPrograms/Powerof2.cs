using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicPrograms
{
    internal class Powerof2
    {
        public static void powerof2()
        {
            Console.WriteLine("Enter the n number");
            int num = int.Parse(Console.ReadLine());
            int two = 2;
            int power = 1;
            int table=1;
            for (int counter = 1; counter <= num; counter++)
            {
                power = (two * power);
                table = power;
            }
            Console.WriteLine("power to 2 to the power " +table);
        }


    }
}
