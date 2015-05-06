using System.Diagnostics;

namespace DHBW.EinstiegDotNet.Beispiele.Verbungen.Klassenattribute
{
    public class Vater
    {
        public void PostHolen()
        {
            Debug.WriteLine("Tür öffnen");
            Debug.WriteLine("Briefkasten öffnen");
            Debug.WriteLine("Briefkasten schließen");
            Debug.WriteLine("Tür schließen");
        }
    }

    public class Kind:Vater
    {
        public void MitarbeitImHaushalt()
        {
            PostHolen();
        }
    }
}
