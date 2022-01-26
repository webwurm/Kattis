using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis01
{
    public class _26_R2
    {
        public static void Main26()
        {
            int[] Eingabe = Array.ConvertAll((Console.ReadLine().Split(" ")),int.Parse);
            Console.WriteLine(Eingabe[0]+(Eingabe[1]-Eingabe[0])*2);
        }
    }
}
