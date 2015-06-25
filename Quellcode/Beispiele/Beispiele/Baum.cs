using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHBW.EinstiegDotNet.Beispiele.Beispiele
{
    public class Baum
    {
        public int Alter { get; private set; }

        private Baum(double Wuchshöhe)
        {
            
        }

        public Baum(int WasserInLiter, int DüngerInLiter):this(0.0)
        {

        }

        public Baum(int Alter):this(Alter * 0.01)
        {
            
        }
    }
}
