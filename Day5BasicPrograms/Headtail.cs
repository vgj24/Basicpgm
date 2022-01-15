using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicPrograms
{
    internal class Headtail
    {
        public static void headtail()
        {
            int h = 1, t = 1, count=0;

            Random rand = new Random();
            int coinflip = rand.Next(0,1);
            while (count != 11)
            {
                if (coinflip == 1)
                {
                    Console.WriteLine("head");
                    h++;
                }
                else
                {
                    Console.WriteLine("tail");
                    t++;
                }
                count++;
            }
            Console.WriteLine("head count h" + h);
            Console.WriteLine("tail count t" + t);
            double percentage = (h / t) * 100;
            Console.WriteLine("percentage of head over tail is" + percentage);
        }
    }
}
