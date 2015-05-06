using System;
using System.Collections.Generic;
using System.Linq;

namespace DHBW.EinstiegDotNet.Beispiele.Linq.Syntax
{
    public class Beispiel
    {
        public void Test()
        {
            var personen = Personenliste.ErzeugeListe();
            var ergebnis = from person in personen where person.Nachname.StartsWith("H") select person;


            var ergebnis2 = personen.Where(person => person.Nachname.StartsWith("H"));


            foreach (var x in ergebnis2)
            {
                
            }
        }

        public void Test2()
        {
            var personen = Personenliste.ErzeugeListe();

            var ergebnis = new List<Person>();

            foreach (var person in personen)
            {
                if (person.Nachname.StartsWith("H"))
                {
                    ergebnis.Add(person);
                }
            }
        }
    }
}
