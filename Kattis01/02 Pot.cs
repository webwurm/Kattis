using System;

public class PotClass
{
	public static void Main02(string[] args)

    {
        int sum = 0;

        // 1. Zahl (Anzahl) wird eingelesen
        int cases = int.Parse(Console.ReadLine());

        while(cases-- > 0) //cases gehen nach 0, solange sie größer 0 sind
        {
            string line=Console.ReadLine(); // Wir lesen die nächste Zahl ein

            //Wir berechnen
            int num = int.Parse(line.Substring (0, line.Length-1));
            int pow = int.Parse(line.Substring(line.Length - 1));

            sum += (int) Math.Pow(num, pow);
        }

        Console.Write(sum);
    }
}
