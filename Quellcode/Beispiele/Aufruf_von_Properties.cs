using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DHBW.EinstiegDotNet.Beispiele.Syntax;

namespace DHBW.EinstiegDotNet.Beispiele
{
    class Aufruf_von_Properties
    {
        public void Einfacher_Aufruf()
        {
            var e = new Eigenschaften();

            var wert = e.AutoProperty;
            var wert2 = e.Nur_lesbare_AutoProperty;

            var wert3 = e[1];

        }
    }
}
