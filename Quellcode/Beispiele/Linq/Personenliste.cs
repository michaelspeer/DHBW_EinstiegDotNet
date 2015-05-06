using System.Collections.Generic;

namespace DHBW.EinstiegDotNet.Beispiele.Linq
{
    public static class Personenliste
    {
        public static List<Person> ErzeugeListe()
        {
            return new List<Person>
            {
                new Person() {Alter = 36, Nachname = "Müller", Vorname = "Hans"},
                new Person() {Alter = 12, Nachname = "Müller", Vorname = "Sara"},
                new Person() {Alter = 2, Nachname = "Müller", Vorname = "Max"},
                new Person() {Alter = 31, Nachname = "Müller-Schmidt", Vorname = "Lieselotte"},
                new Person() {Alter = 75, Nachname = "Halsbrecher", Vorname = "Eduard"},
                new Person() {Alter = 78, Nachname = "Halsbrecher", Vorname = "Regina"},
            };
        }
    }
}
