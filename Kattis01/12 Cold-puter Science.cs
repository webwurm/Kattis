using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis01
{
    public  class _12_Cold_puter_Science
    {
        public static void Main12()
        {
            int Tage = int.Parse(Console.ReadLine());
            int[] Temperaturen = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int unterNull = 0;

            foreach (int t in Temperaturen)
            {
                if (t < 0)
                {
                    unterNull++;
                }

            }

            Console.WriteLine(unterNull);
        }
    }
}
