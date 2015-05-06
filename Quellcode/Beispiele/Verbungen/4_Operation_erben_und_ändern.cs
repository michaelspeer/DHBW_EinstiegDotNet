using System.Diagnostics;

namespace DHBW.EinstiegDotNet.Beispiele.Verbungen.OperationErbenUndÄndern
{
    public class Vater
    {
        public virtual void Essen()
        {
            Debug.WriteLine("Lecker!");
        }

        public virtual void Aufräumen()
        {
            Debug.WriteLine("...");
        }
    }

    public class Kind : Vater
    {
        public override void Essen()
        {
            Debug.WriteLine("Nörgeln");
            base.Essen();
            Debug.WriteLine("Kleckern");
        }

        public override sealed void Aufräumen()
        {
            Debug.WriteLine("Spielen");
        }
    }
}
