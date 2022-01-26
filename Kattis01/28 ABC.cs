using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis01
{
    public class _28_ABC
    {
        public static void Main28()
        {
            int[] Eingabe = Array.ConvertAll((Console.ReadLine().Split(" ")), int.Parse);
            Array.Sort(Eingabe);
            string Buchstaben = Console.ReadLine();

            // 1. Stelle
            if (Buchstaben[0] == 'A')
            {
                Console.Write(Eingabe[0]);
            } else if (Buchstaben[0] == 'B')
            {
                Console.Write(Eingabe[1]);
            } else
            {
                Console.Write(Eingabe[2]);
            }

            Console.Write(" ");

            // 2. Stelle
            if (Buchstaben[1] == 'A')
            {
                Console.Write(Eingabe[0]);
            }
            else if (Buchstaben[1] == 'B')
            {
                Console.Write(Eingabe[1]);
            }
            else
            {
                Console.Write(Eingabe[2]);
            }

            Console.Write(" ");

            // 3. Stelle
            if (Buchstaben[2] == 'A')
            {
                Console.Write(Eingabe[0]);
            }
            else if (Buchstaben[2] == 'B')
            {
                Console.Write(Eingabe[1]);
            }
            else
            {
                Console.Write(Eingabe[2]);
            }

        }
    }
}
