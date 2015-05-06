using System;
using System.Linq;

namespace DHBW.EinstiegDotNet.Beispiele.Linq.Manifestierung
{
    public class Beispiel
    {
        public void Test()
        {
            var personen = Personenliste.ErzeugeListe();

            var abfrage = personen.Where(person => person.Alter > 30).ToList();

            personen.Clear();

            foreach (var person in abfrage)
            {
                Console.WriteLine(person.Nachname);
            }
        }
    }
}
