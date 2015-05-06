namespace DHBW.EinstiegDotNet.Beispiele.Type_Casts.ExpliziteCastsMitAs
{
    public class Pflanze
    {
        
    }

    public class Baum : Pflanze
    {
        
    }
    public class Beispiel
    {
        public void Test()
        {
            var baum = new Baum();
            Pflanze BaumAlsPflanze = baum as Pflanze;

            if (BaumAlsPflanze != null)
            {
                // Cast hat funktioniert
            }
            else
            {
                // Cast hat nicht funktioniert!
            }
        }
    }
}
