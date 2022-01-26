using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis01
{
    public class _27_Tarifa
    {
        public static void Main27()
        {
            int megabyte = int.Parse(Console.ReadLine());   
            int months = int.Parse(Console.ReadLine());
            int frei = megabyte;

            for (int i = 0; i < months; i++)
            {
                frei += megabyte - int.Parse(Console.ReadLine());

            }

            Console.WriteLine(frei);

        }
    }
}
