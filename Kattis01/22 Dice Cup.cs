using System;
using System.Collections.Generic;

namespace Kattis01
{
    public class _22_Dice_Cup
    {
        public static int Max(int[] zahl)
        // Hilfsfunktion zum Berechnen der größten Zahl
        {
            int Ergebnis = zahl[0];

            foreach (int i in zahl)
            {
                if (i > Ergebnis)
                {
                    Ergebnis = i;
                }
            }

            return Ergebnis;

        }
        public static void Main22()
        {
            // Eingabe sind die Anz. Seiten von 2 Würfeln
            int[] Eingabe = Array.ConvertAll((Console.ReadLine().Split(" ")),int.Parse);

            // Ergebnis-Array erstellen
            int[] Ergebnis = new int[Eingabe[0]+Eingabe[1]+1];

            // Würfeln
            for (int i = 1; i <= Eingabe[0]; i++)
            {
                for (int j = 1; j <= Eingabe[1]; j++)
                {
                    Ergebnis[i+j]++;
                }
            }

            //Ausgabe
            int maxWert = Max(Ergebnis);

            for (int i = 2; i < Eingabe[0]+Eingabe[1]; i++)
            {
                
                if (Ergebnis[i] == maxWert)
                {
                    Console.WriteLine(i);
                }
            }

            

        }
    }
}
