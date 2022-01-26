using System;
public class _04_Electrical_Outlets
{
    public static void Main04(string[] args)
    {
        int cases = int.Parse(Console.ReadLine());
        int casewhile = cases;
        int[] summe = new int[cases];
        
        //Jede Zeile 1 Szenario
        while (casewhile-- > 0)
        {
            //Zeile einlesen
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);

            // Die erste Stelle gibt die Anzahl der Power Strips
            int strips = int.Parse(split[0]);

            // Die übrigen zusammenzählen, jeweils -1
            for (int i = 1; i <= strips; i++)
            {
                summe[casewhile]+=int.Parse(split[i])-1;
            }
            
        }

        //Ausgeben
        while (cases-- > 0)
        {
            Console.WriteLine(summe[cases]+1);
        }

    }
}
