namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    public class CtorTest
    {
        public void Test()
        {
            var k = new Konstruktoren();
        }
    }
    public class Konstruktoren
    {
        // "Default"-Konstruktor
        public Konstruktoren()
        {
        }

        // Parameter-Übergabe
        public Konstruktoren(string Wert)
        {
            // ...
        }

        // Verkettung von Konstruktoren
        public Konstruktoren(string Wert, int Wert2) : this(Wert)
        {
            // ...
        }

        // Konstruktor nur zur internen Verwendung
        private Konstruktoren(int Wert)
        {
            // ---
        }
    }
}
