namespace DHBW.EinstiegDotNet.Beispiele.Schnittstellen.Interfacevererbung
{
    public interface IPflanze
    {
        int Wurzeltiefe { get; set; }
    }

    public interface IBaum : IPflanze
    {
        int Alter { get; set; }
    }

    public class Tanne : IBaum
    {
        public int Wurzeltiefe { get; set; }
        public int Alter { get; set; }
    }
}
