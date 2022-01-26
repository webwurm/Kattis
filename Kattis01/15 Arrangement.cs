using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis01
{
    public class _15_Arrangement
    {
        public static void Main15()
        {
            int intRooms = int.Parse(Console.ReadLine());
            int intTeams = int.Parse(Console.ReadLine());

            int[] Rooms = new int[intRooms];
            int TeamsAlreadyInRooms = 0;

            for (int i = 0; i < intRooms; i++)
            {
                Rooms[i] = Convert.ToInt32((intTeams-TeamsAlreadyInRooms) / (intRooms-i));
                TeamsAlreadyInRooms += Rooms[i];

                for (int j = 0; j < Rooms[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
