using System;

namespace DHBW.EinstiegDotNet.Beispiele.AnonymeMethoden.LambdaAusdrückeAlsFunktion
{
    public class Beispiel
    {
        public void Test()
        {
            Func<int, int> lambda = (wert) => wert * 2;
            Func<int> lambda2 = () => 12;
            Func<int, int, bool> lambda3 = (wert1, wert2) => wert1 == wert2;

            Func<int, bool> meinDelegat = wert => wert.ToString().StartsWith("1");
            MachWas(meinDelegat);
        }

        public void MachWas(Func<int, bool> meineMethode)
        {
            //....
        }
    }
}
