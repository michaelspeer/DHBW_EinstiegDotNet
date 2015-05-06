using System;

namespace DHBW.EinstiegDotNet.Beispiele.AnonymeMethoden.AnonymeMethodenMitParametern
{
    public class Beispiel
    {
        public void Test()
        {
            Action<string> WertAnzeigen = (parameter) =>
            {
                var neuerWert = parameter + "...";
                Console.WriteLine(neuerWert);
            };

            WertAnzeigen("mein Wert");
        }

        public void Test2()
        {
            Action<string, int> WertAnzeigen = (wert, anzahl) =>
            {
                var neuerWert = wert + "...";
                for (int i = 0; i <= anzahl; i++)
                {
                    Console.WriteLine(neuerWert);
                }
            };

            WertAnzeigen("mein Wert", 12);
        }
    }
}
