namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    public class Felder
    {
        private string _privatesFeld;
        
        public string _öffentlichesFeld;

        public static string _statischesFeld;

        public readonly int _nurLesbaresFeld;

        public const string KONSTANTE = "konstanterWert";

        public Felder()
        {
            _nurLesbaresFeld = 12; // readonly Felder können nur im Konstruktor geschrieben werden
        }
    }
}
