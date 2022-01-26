using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis01
{
    public class Person
    {
        public string FirstName { get; set; }
        public int Punkte { get; set; }
        public string Datum { get; set; }

        public string AlleDaten()
        {
            return FirstName + " " + Punkte + " " + Datum;
        }
    }

    public class _13_Birthday_Memorization
    {
        public static void Main13()
        {
            int Anzahl = int.Parse(Console.ReadLine());
            List<Person> PersonenListe = new List<Person>();

            for (int i = 0; i < Anzahl; i++)
            {
            
                string[] personenDaten = Console.ReadLine().Split(' ');

                // Ergänze neue Person in Liste
                PersonenListe.Add(new Person() { FirstName = personenDaten[0], Punkte = int.Parse(personenDaten[1]), Datum = personenDaten[2] });
            
            }

            List<Person> PersonenListeNeu = new List<Person>();
            //PersonenListeNeu = PersonenListe.GroupBy(x => x.Datum).Select(x => x.First()).ToList();
            PersonenListeNeu = PersonenListe.GroupBy(x => x.Datum, (key, g) => g.OrderBy(e => e.Punkte).Last()).ToList();
            List<Person> PersonenAusgabe = PersonenListeNeu.OrderBy(x => x.FirstName).ToList();

            // Ausgabe
            Console.WriteLine(PersonenAusgabe.Count);
            foreach (Person personen in PersonenAusgabe)
            {
                Console.WriteLine(personen.FirstName);
            }

        }
    }
}
