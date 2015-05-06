using System;
using DHBW.EinstiegDotNet.Beispiele.Delegaten.Ereignisse;

namespace DHBW.EinstiegDotNet.Beispiele.Delegaten.EventHandler
{
    public class Beispiel
    {
        private Konto konto;
        public void Test()
        {
            this.konto = new Konto {Kontostand = 500};
            konto.KontoÜberzogen += KontoWurdeÜberzogen;
            konto.KontoÜberzogen += KontoAusgleichen;
        }

        private void KontoAusgleichen()
        {
            konto.Einzahlen(100);
        }

        private void KontoWurdeÜberzogen()
        {
            Console.WriteLine("Konto wurde überzogen");
        }
    }
}
