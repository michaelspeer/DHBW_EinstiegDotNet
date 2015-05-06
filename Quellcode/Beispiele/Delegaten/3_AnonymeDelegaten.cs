using System;

namespace DHBW.EinstiegDotNet.Beispiele.Delegaten.AnonymeDelegaten
{
    public class Beispiel
    {
        public Action delegat;
        public Action<string> delegat2;
        public Action<string, double, double> delegat3;

        public Func<bool> delegate4;
        public Func<string, bool> delegate5;

        public void Test()
        {
            delegat();
            delegat2("ein Wert");
            delegat3("ein Wert", 12.2, 0.5);

            bool ergebnis4 = delegate4();
            bool ergebnis5 = delegate5("wert");
        }
    }
}
