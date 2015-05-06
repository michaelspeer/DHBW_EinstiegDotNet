namespace DHBW.EinstiegDotNet.Beispiele.Schnittstellen.Vielfachvererbung
{
    public interface IPflanze
    {
        
    }

    public interface IKonifere
    {
        
    }

    public interface IBaum
    {
        
    }

    public interface Tanne : IPflanze, IKonifere, IBaum
    {
        
    }
}
