namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    public static class StringExtensions
    {
        public static string Verschlüsseln(this string value, string passwort)
        {
            // ...

            return null;
        }

    }
    public class Erweiterungsmethoden
    {
        public void Test()
        {
            string wert = "Hallo Welt";
            string verschlüsselterWert = wert.Verschlüsseln("mein Passwort");

            string verschlüsselterWert2 = StringExtensions.Verschlüsseln(wert, "mein Passwort");
        }
    }
}
