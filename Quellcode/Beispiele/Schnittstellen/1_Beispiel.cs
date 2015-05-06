namespace DHBW.EinstiegDotNet.Beispiele.Schnittstellen.Beispiel
{
    public interface IPflanze
    {
        void Giessen();
    }

    public class Pflanze : IPflanze
    {
        public void Giessen()
        {
            //...
        }
    }
}
