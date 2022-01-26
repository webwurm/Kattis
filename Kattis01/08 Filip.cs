using System;

public class _08_Filip
{
    public static void Main08()
    {

        //Eingabe einlesen und umkehren
        string strEingabe = Console.ReadLine();
        char[] arrEingabe = strEingabe.ToCharArray();
        Array.Reverse(arrEingabe);
        string strAusgabe = new string(arrEingabe);

        //In Integer umwandeln
        int leerzeichen = strAusgabe.IndexOf(' ');
        int[] Nummern = new int[2];
        Nummern[0] = int.Parse(strAusgabe.Substring(0, leerzeichen));
        Nummern[1] = int.Parse(strAusgabe.Substring(leerzeichen+1));

        Console.WriteLine(Nummern[0] > Nummern[1] ? Nummern[0] : Nummern[1]);
    }
}

