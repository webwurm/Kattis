using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kattis01
{
    public class _18_Stuck_In_A_Time_Loop
    {
        public static void Main18()
        {
            int Anzahl = int.Parse(Console.ReadLine());

            for (int i = 0; i < Anzahl; i++)
            {
                Console.WriteLine(i+1 + " Abracadabra");
            }
        }
    }
}
