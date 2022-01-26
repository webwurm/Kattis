using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis01
{
    public class _20_Zamka
    {
        private static int ZSum(int zahl)
        {
            int ergebnis = 0;
            int i = zahl;

            while (i > 0)
            {
                ergebnis += i % 10;
                i /= 10;
            }

            return ergebnis;
        }
        public static void Main20()
        {
            int l = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            for (int i = l; i <= d; i++)
            {
                if (x == ZSum(i))
                {
                    Console.WriteLine(i);
                    break;
                } 
            }

            for (int i = d; i >= l; i--)
            {
                if (x == ZSum(i))
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}
