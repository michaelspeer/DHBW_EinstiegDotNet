using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHBW.EinstiegDotNet.Beispiele.Delegaten.Ereignisse
{

    public class Konto
    {
        public int Kontostand { get; set; }

        public delegate void KontoÜberzogenDelegate();

        public event KontoÜberzogenDelegate KontoÜberzogen;

        public void Abheben(int betrag)
        {
            this.Kontostand -= betrag;

            if (this.Kontostand < 0)
            {
                KontoÜberzogen();
            }
        }

        public void Einzahlen(int betrag)
        {
            this.Kontostand += betrag;

            if (this.Kontostand < 0)
            {
                KontoÜberzogen();
            }
        }
    }
    public class Beispiel
    {
        public void Test()
        {
            var konto = new Konto() { Kontostand = 100 };
            konto.KontoÜberzogen += KontoWurdeÜberzogen;

            konto.Abheben(500);

            Console.WriteLine("jetzt");
        }

        private void KontoWurdeÜberzogen()
        {
            // ....
            Console.WriteLine("oder jetzt?");

        }
    }
}
