using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHBW.EinstiegDotNet.Beispiele.Beispiele
{
    public class FactoryPattern
    {
        private FactoryPattern()
        {
            
        }

        public static FactoryPattern Create(int p1)
        {

            return new FactoryPattern();
        }
    }
}
