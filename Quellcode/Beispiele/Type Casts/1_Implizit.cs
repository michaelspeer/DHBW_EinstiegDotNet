using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHBW.EinstiegDotNet.Beispiele.Type_Casts.Implizit
{
    public class Beispiel
    {
        public void EineMethode(double zahl)
        {
            
        }

        public void ZweiteMethode(object wert)
        {
            
        }

        public void Test()
        {
            int zahl = 12;
            EineMethode(zahl); // impliziter Cast zu double


            ZweiteMethode("Hallo Welt"); // impliziter Cast zu object
        }
    }
}
