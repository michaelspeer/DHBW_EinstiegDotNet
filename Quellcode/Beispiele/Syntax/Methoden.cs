using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    public class Methoden
    {
        public void Methode()
        {
            // ...
        }

        public void Methode_mit_Parametern(string Wert1, int Wert2)
        {
            // ...
        }

        public void Methode_mit_RückgabeParameter(out int Wert)
        {
            Wert = 0;
        }

        public void Methode_mit_ReferenzParameter(ref int Alter)
        {
            Alter = 20;
        }

        public int Funktion()
        {
            return 20;
        }

        public void Methode_mit_optionalem_Parameter(int Alter = 20)
        {
            
        }

        public void Methode_mit_Parameterliste(params string[] namen)
        {
            foreach (var name in namen)
            {
                // ...
            }
        }

        public void Aufruf_einer_Methode_mit_Parameterliste()
        {
            // 1. Möglichkeit
            var floats = new[] {1.0, 2};
            var werte = new[] { "Wert1", "Wert2", "Wert3", "Wert4", "Wert5", "Wert6" };
            Methode_mit_Parameterliste(werte);


            // 2. Möglichkeit
            Methode_mit_Parameterliste("Wert1","Wert2","Wert3","Wert4","Wert5","Wert6");
        }
    }
}
