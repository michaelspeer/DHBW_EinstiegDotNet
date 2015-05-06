using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHBW.EinstiegDotNet.Beispiele.Delegaten.Beispiel
{
    public class MeineKlasse
    {
        public delegate void EineMethodeDelegate();

        public delegate void EineMethodeMitStringParameterDelegate(string parameter);


        public void Test()
        {
            EineMethodeDelegate delegat1 = new EineMethodeDelegate(IrgendeineMethode);
            EineMethodeMitStringParameterDelegate delegat2 = new EineMethodeMitStringParameterDelegate(IrgendeineMethodeMitParameter);
        }

        public void IrgendeineMethode()
        {
            
        }

        public void IrgendeineMethodeMitParameter(string wert)
        {
            
        }
    }
}
