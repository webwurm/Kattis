using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis01
{
    public class _21_Jack_O_Lantern_Juxtaposition
    {
        public static void Main21()
        {
            int[] Eingabe = Array.ConvertAll((Console.ReadLine().Split(" ")),int.Parse);
            Console.WriteLine(Eingabe[0] * Eingabe[1] * Eingabe[2]);
        }
    }
}
