using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHBW.EinstiegDotNet.Beispiele.Signaturen.ÜberladeneMethoden
{
    public class Beispiel
    {
        public void EineMethode(string wert)
        {
            
        }

        public void EineMethode(int wert)
        {
            
        }

        public void EineMethode(object wert)
        {

        }
    }

    public static class Aufruf
    {
        public static void Test()
        {
            var beispiel = new Beispiel();

            string wert = "Hallo Welt";
            int zahl = 12;
            object irgendwas = 12;
            double meineZahl = 12.4;
            beispiel.EineMethode(wert);
            beispiel.EineMethode(zahl);
            beispiel.EineMethode(zahl.ToString());
            beispiel.EineMethode(irgendwas);
            beispiel.EineMethode((int) irgendwas);
            beispiel.EineMethode((object)zahl);
            beispiel.EineMethode(meineZahl);
        }
    }
}
