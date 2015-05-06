using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHBW.EinstiegDotNet.Beispiele.Linq.Methodenschreibweise
{
    public class Beispiel
    {
        public void Test()
        {
            var personen = Personenliste.ErzeugeListe();
            var ergebnis = personen.Where(person => person.Nachname.StartsWith("H"));
            var alter = ergebnis.Select(x => x.Alter).Distinct().Max();


        }
    }
}
