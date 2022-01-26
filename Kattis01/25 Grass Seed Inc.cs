using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis01
{
    public class _25_Grass_Seed_Inc
    {
        public static void Main25()
        {
            double cost = double.Parse(Console.ReadLine());
            int anzLawns = int.Parse(Console.ReadLine());
            double Summe = 0;

            for (int i = 0; i < anzLawns; i++)
            {
                double[] Lawn = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
                Summe += Lawn[0] * Lawn[1] * cost;
            }

            Console.WriteLine(String.Format("{0:0.0000000}", Summe));
        }
    }
}
