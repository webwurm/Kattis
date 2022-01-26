using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis01
{
    public class _11_Pet
    {
        public static void Main11()
        {
            int[] arrTeilnehmer = new int[5];

            for (int i = 0; i < arrTeilnehmer.Length; i++)
            {

                arrTeilnehmer[i] = (Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse)).Sum();

            }

            // Finde den höchsten Wert
            int maxValue = arrTeilnehmer.Max();
            int maxIndex = Array.IndexOf(arrTeilnehmer, maxValue);

            Console.Write((maxIndex + 1) + " " + maxValue);
        }
    }
}
