using System;
using System.Collections.Generic;

namespace Kattis01
{
    public class _10_Sibice
    {
        public static void Main10()
        {
            // Der ultimative Weg, einen mit Leerzeichen geteilten String in ein int-Array umzuwandeln
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] streichholz = new int[nums[0]];
            int a = nums[1];
            int b = nums[2];

            // max Länge berechnen
            //double maxlang = Math.Sqrt(a * a - 2 * a * b * Math.Cos(90) + b * b);
            double maxlang = Math.Sqrt(a * a + b * b);

            // Jetzt die übrigen Zeilen einlesen
            for (int i = 0; i < nums[0]; i++)
            {
                streichholz[i] = int.Parse(Console.ReadLine());
            }

            // Jetzt die Ausgabe
            foreach (int e in streichholz)
            {
                Console.WriteLine(e <= maxlang ? "DA" : "NE");
            }

        }
    }
}
