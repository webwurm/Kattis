using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis01
{
    public class _14_Bijele
    {
        public static void Main14()
        {
            int[] arrIst = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] arrSoll = { 1, 1, 2, 2, 2, 8 };
            string strAusgabe = "";

            for (int i = 0; i < arrIst.Length; i++)
            {
                strAusgabe += arrSoll[i] - arrIst[i] + " ";
            }

            Console.WriteLine(strAusgabe.Trim());
        }
    }
}
