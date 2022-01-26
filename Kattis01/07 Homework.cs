using System;

public class _07_Homework
{
    public static void Main07()
    {
        string Eingabe = Console.ReadLine();
        string[] Eingabeliste = Eingabe.Split(new char[] { ';' });
        int Pruefungen = 0;

        foreach (var Element in Eingabeliste) {

            // Feststellen, on Element eine Zahl ist
            int number;
            bool success = int.TryParse(Element, out number);

            if (success) {

                Pruefungen++;

            } else {

                string[] VonBis = Element.Split(new char[] { '-' });
                int PruefungsAnz = int.Parse(VonBis[1]) - int.Parse(VonBis[0]);
                Pruefungen += PruefungsAnz+1;

            }
        }
        
        Console.Write(Pruefungen);

    }
}

