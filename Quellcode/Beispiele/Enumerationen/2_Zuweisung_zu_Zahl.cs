namespace DHBW.EinstiegDotNet.Beispiele.Enumerationen.ZuweisungZuZahl
{
    public enum Familie
    {
        Vater = 1,
        Mutter = 2,
        Sohn = 3,
        Tochter = 4
    }

    public class Beispiel
    {
        public void Test()
        {
            int zahl = (int)Familie.Mutter;
        }
    }
}
