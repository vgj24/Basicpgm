using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicPrograms
{
    internal class VowelConsonant
    {
        public static void VCmethod()
        {
            Console.WriteLine("Enter any alphabet");
            char alphabet= Convert.ToChar(Console.ReadLine());   
            if(alphabet == 'a' || alphabet == 'A' ||alphabet =='e' || alphabet=='E' || alphabet == 'i' || alphabet=='I' || alphabet=='o' || alphabet== 'O' || alphabet=='u'|| alphabet== 'U')
            {
                Console.WriteLine(alphabet + "  is vowel");
            }
            else 
            {
                Console.WriteLine(alphabet + "is constant");

            }
        }
        
    }
}
