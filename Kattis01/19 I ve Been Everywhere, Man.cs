using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kattis01
{
    public class _19_I_ve_Been_Everywhere__Man
    {
        public static void Main19()
        {
            int reisen = int.Parse(Console.ReadLine());
            int[] ergebnis = new int[reisen];

            // Jede Reise
            for (int i = 0; i < reisen; i++)
            {
                int staedte = int.Parse(Console.ReadLine());

                // Stadtliste
                List<string> Stadt = new List<string>();
                List<string> StadtEinzigartig = new List<string>();

                for (int j = 0; j < staedte; j++)
                {
                    Stadt.Add(Console.ReadLine());
                }

                StadtEinzigartig = Stadt.Distinct().ToList();
                ergebnis[i] = StadtEinzigartig.Count();
            }

            // Ausgabe
            foreach (int i in ergebnis)
            {
                Console.WriteLine(i);
            }
        }
    }
}
