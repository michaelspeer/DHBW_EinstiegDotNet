using System.Diagnostics;

namespace DHBW.EinstiegDotNet.Beispiele.Verbungen.VerhaltenErsetzen
{
    public class Vater
    {
        public void Schlafen()
        {
            Debug.WriteLine("Träumen");
        }
    }

    public class Kind : Vater
    {
        public new void Schlafen()
        {
            Debug.WriteLine("...");
            base.Schlafen();
        }
    }
}
