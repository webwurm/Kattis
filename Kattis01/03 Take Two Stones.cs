using System;

public class Take_Two_Stones
{
    public static void Main03(string[] args)
    {
        int stones = int.Parse(Console.ReadLine());

        //Modulator (Rest der Division) ist "%"
        if (stones%2 == 0) {
            Console.Write("Bob");
        } else {
            Console.Write("Alice");
        }

    }
}

