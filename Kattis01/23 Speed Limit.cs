using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis01
{
    public class _23_Speed_Limit
    {
        public static void Main23()
        {
            int Fahrten = 0;
            List<int> Ergebnisse = new List<int>();

            while (true)
            {
                int anzWerte = int.Parse(Console.ReadLine());
                if (anzWerte == -1) break;
                Fahrten++;
                int MinSumme = 0;
                int KMSumme = 0;

                for (int i = 0; i < anzWerte; i++)
                {
                    int[] Eingabe = Array.ConvertAll((Console.ReadLine().Split(" ")),int.Parse);
                    KMSumme = KMSumme + Eingabe[0] * (Eingabe[1]-MinSumme);
                    //Console.WriteLine(Eingabe[0] + " " + Eingabe[1] + ": " + KMSumme);
                    MinSumme = Eingabe[1];
                }

                Ergebnisse.Add(KMSumme);

            }

            foreach (int i in Ergebnisse)
            {
                Console.WriteLine(i + " miles");
            }

        }
    }
}
