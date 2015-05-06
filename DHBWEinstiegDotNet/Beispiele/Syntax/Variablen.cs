using System;

namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    public class Variablen
    {
        public void eineMethode()
        {
            string variable1 = "Hallo Welt";
            int variable2;
            bool variable3 = true;
        }

        public void eineMethode2()
        {
            string variable1 = "Wochentag";

            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                string variable2 = "Hallo Welt";
                variable1 = "Donnerstag";
            }

            // variable2 = "geht nicht";
        }
    }
}
