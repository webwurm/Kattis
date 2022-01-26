using System;


public class _06_Odd_Echo
{
    public static void Main06()
    {
        int Anzahl = int.Parse(Console.ReadLine());
        string[] Wortliste = new string[Anzahl];

        for (int i = 0; i < Wortliste.Length; i++)
        {
            Wortliste[i] = Console.ReadLine();
        }

        int Zaehler = 0;

        foreach (string Wort in Wortliste)
        {
            if (Zaehler%2 == 0)
            {
                Console.WriteLine(Wort);
            }

            Zaehler++;
        }

    }
}

