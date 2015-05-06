namespace DHBW.EinstiegDotNet.Beispiele.Enumerationen.Beispiel
{
    public enum Familie
    {
        Vater = 1,
        Mutter = 2,
        Sohn = 3,
        Tochter // Wert wird automatisch vergeben
    }

    public class Beispiel
    {
        public void Test()
        {
            Familie ich = Familie.Vater;

            ich = Familie.Sohn;

        }
    }
}
