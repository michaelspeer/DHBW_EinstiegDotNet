namespace DHBW.EinstiegDotNet.Beispiele.Schnittstellen.SchnittstellenUndVererbung
{
    public interface IBaum
    {

    }
    public class Baum: IBaum
    {
        
    }

    public class Tanne : Baum // enthält das Interface IBaum
    {
        
    }
}
