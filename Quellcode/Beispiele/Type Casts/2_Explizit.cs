namespace DHBW.EinstiegDotNet.Beispiele.Type_Casts.Explizit
{
    public class Beispiel
    {
        public void EineMethode(int wert)
        {

        }
        public void Test()
        {
            double zahl = 12.5;
            EineMethode((int)zahl); // Achtung : Genauigkeitsverlust!
        }
    }
}
