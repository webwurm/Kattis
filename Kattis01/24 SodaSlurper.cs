using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis01
{
    public class _24_SodaSlurper
    {
        public static void Main24()
        {
            int[] Eingabe = Array.ConvertAll((Console.ReadLine().Split(" ")),int.Parse);
            int leereFlaschen = Eingabe[0] + Eingabe[1];
            int volleFlaschen = 0;
            int wechselKurs = Eingabe[2];
            int getrunken = 0;

            while (true)
            {
                volleFlaschen = leereFlaschen / wechselKurs; // ganzzahlige Division
                leereFlaschen = leereFlaschen % wechselKurs; // Rest der ganzzahligen Division

                getrunken += volleFlaschen;
                leereFlaschen += volleFlaschen;

                if (leereFlaschen < wechselKurs)
                {
                    break;
                }

            }

            Console.WriteLine(getrunken);
        }
    }
}
