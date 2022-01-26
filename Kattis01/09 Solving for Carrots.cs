using System;
public class _09_Solving_for_Carrots
{
    public static void Main09()
    {
        string Zeile1 = Console.ReadLine();
        string[] arrZeile1 = Zeile1.Split(new string[] { " " }, StringSplitOptions.None);
        int Zeilen = int.Parse(arrZeile1[0]);
        int Ausgabe = int.Parse(arrZeile1[1]);

        for (int i = 0; i < Zeilen; i++)
        {
            Console.ReadLine();
        }

        Console.WriteLine(Ausgabe);
    }
}

