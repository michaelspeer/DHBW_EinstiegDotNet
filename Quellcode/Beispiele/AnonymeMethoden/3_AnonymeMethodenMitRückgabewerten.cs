using System;

namespace DHBW.EinstiegDotNet.Beispiele.AnonymeMethoden.AnonymeMethodenMitRückgabewerten
{
    public class Beispiel
    {
        public void Test()
        {
            Func<int, int, double> Dividieren = (wert1, wert2) =>
            {
                return wert1 / wert2;
            };

            var ergebnis = Dividieren(12, 4);
        }
    }
}
