using System;

namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    public class AnonymeTypen
    {
        public object Verwendung_eines_anonymen_Types()
        {
            var neuerType = new { Strasse = "Hauptstrasse", Hausnummer = 12 };

            Console.WriteLine(neuerType.Strasse);
            Console.WriteLine(neuerType.Hausnummer);

            return neuerType;
        }

    }
}
