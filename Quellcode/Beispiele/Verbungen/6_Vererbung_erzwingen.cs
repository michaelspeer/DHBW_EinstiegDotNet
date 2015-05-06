using System;

namespace DHBW.EinstiegDotNet.Beispiele.Verbungen.VererbungErzwingen
{
    public abstract class DerSinnDesLebens
    {
        public abstract void BereichereDieWelt();
    }

    public class Kind : DerSinnDesLebens
    {
        public override void BereichereDieWelt()
        {
            throw new NotImplementedException();
        }
    }
}
