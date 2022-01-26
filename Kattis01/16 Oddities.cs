using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis01
{
    public class _16_Oddities
    {
        public static void Main16()
        {
            int testCases = int.Parse(Console.ReadLine());  
            int[] tests = new int[testCases];

            for (int i = 0; i < testCases; i++)
            {
                tests[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < testCases; i++)
            {
                Console.WriteLine((tests[i] % 2 == 0 ? tests[i] + " is even" : tests[i] + " is odd"));
            }
        }
    }
}
