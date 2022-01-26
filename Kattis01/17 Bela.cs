using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis01

{
    public class Karte {

        public char Number { get; set; }

        public int Dominant { get; set; }

        public int NotDominant { get; set; }

    }
    public class _17_Bela
    {
        public static void Main17()
        {
            // Karten anlegen
            List<Karte> list = new List<Karte>();
            list.Add(new Karte() { Number = 'A', Dominant = 11, NotDominant = 11 });
            list.Add(new Karte() { Number = 'K', Dominant = 4, NotDominant = 4 });
            list.Add(new Karte() { Number = 'Q', Dominant = 3, NotDominant = 3 });
            list.Add(new Karte() { Number = 'J', Dominant = 20, NotDominant = 2 });
            list.Add(new Karte() { Number = 'T', Dominant = 10, NotDominant = 10 });
            list.Add(new Karte() { Number = '9', Dominant = 14, NotDominant = 0 });
            list.Add(new Karte() { Number = '8', Dominant = 0, NotDominant = 0 });
            list.Add(new Karte() { Number = '7', Dominant = 0, NotDominant = 0 });

            // 1. Zeile einlesen
            string[] Eingabe = Console.ReadLine().Split(' ');
            int hands = int.Parse(Eingabe[0]);
            char suit = Eingabe[1].First();
            string[] KartendeckEingabe = new string[hands * 4];
            int[] punkte = new int[hands * 4];

            for (int i = 0; i < hands*4;)
            {
                //Console.Write(i + ": ");
                KartendeckEingabe[i] = Console.ReadLine();

                Karte result = list.Find(x => x.Number == KartendeckEingabe[i][0]);

                if (KartendeckEingabe[i].Last() == suit)
                {
                    punkte[i] = result.Dominant;
                } else {
                    punkte[i] = result.NotDominant;
                }

                i++;
            }

            Console.WriteLine(punkte.Sum());
        }
    }
}
