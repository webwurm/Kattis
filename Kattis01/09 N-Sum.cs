using System;
public class _09_N_Sum
{
    public static void Main09()
    {
        // 1. Zeile gibt Anzahl an
        int Anzahl = int.Parse(Console.ReadLine());

        // 2. Zeile sind die Zahlen, durch Leerzeichen getrennt
        string Eingabe = Console.ReadLine();
        string[] strListe = Eingabe.Split(" ");
        int summe = 0;

        foreach (string str in strListe)
        {
            summe += int.Parse(str);
        }

        Console.WriteLine(summe);
    }
}
