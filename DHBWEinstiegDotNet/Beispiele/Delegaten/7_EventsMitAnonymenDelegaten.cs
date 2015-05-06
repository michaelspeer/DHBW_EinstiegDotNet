using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHBW.EinstiegDotNet.Beispiele.Delegaten.EventsMitAnonymenDelegaten
{
    public class Konto
    {
        public int Kontostand { get; set; }

        public event Action KontoÜberzogen;

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
}
