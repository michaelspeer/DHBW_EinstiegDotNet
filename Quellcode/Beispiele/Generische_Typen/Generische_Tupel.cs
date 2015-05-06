using System;

namespace DHBW.EinstiegDotNet.Beispiele.Generische_Typen
{
    public class Generische_Tupel
    {
        public void Verwendung_von_Tuple()
        {
            var daten = new Tuple<string, int, int>("Name", 12, 5);

            Console.WriteLine(daten.Item1);
            Console.WriteLine(daten.Item2);
            Console.WriteLine(daten.Item3);
        }
    }
}
