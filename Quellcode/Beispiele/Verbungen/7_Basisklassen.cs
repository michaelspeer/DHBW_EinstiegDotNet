namespace DHBW.EinstiegDotNet.Beispiele.Verbungen.Basisklassen
{
    public abstract class MeineKinder
    {
        public abstract void TueNichtsFalsches();
        public abstract void LiebeAllesLeben();

        public void VerbessereDieWelt()
        {
            TueNichtsFalsches();
            LiebeAllesLeben();
        }
    }
}
