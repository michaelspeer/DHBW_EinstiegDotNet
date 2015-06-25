namespace DHBW.EinstiegDotNet.Beispiele.Signaturen.Überladungen
{
    public class Beispiel
    {
        public void EineMethode()
        {
            EineMethode("Hallo Welt");
        }

        public void EineMethode(string wert)
        {
        }

        public void EineMethode(bool wert)
        {
            
        }

        //public int EineMethode(string wert) // geht nicht, da Signatur bereits vorhanden
        //{

        //}

        //public void EineMethode(string andererWert) // geht nicht, da Signatur bereits vorhanden
        //{

        //}
    }
}
