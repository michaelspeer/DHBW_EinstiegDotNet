namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    public class Eigenschaften
    {

        public void Test()
        {

            Eigenschaft_mit_Backingfield = "123";
            var wert = Eigenschaft_mit_Backingfield;

            this[12] = "12";
        }


        private string _wert;


        public string AutoProperty { get;  set; }
        public string AutoProperty2 { get; private set; }

        public string Nur_lesbare_AutoProperty { get; private set; }

        public string Eigenschaft_mit_Backingfield
        {
            get { return _wert; }
            set { _wert = value; }
        }

        public string Nur_lesbare_Eigenschaft_mit_Backingfield
        {
            get { return _wert; }
            private set { _wert = value; }
        }

        // Indizierte Eigenschaft
        public string this[int Index]
        {
            get
            {
                // liefere Wert mit Index
                return "";
                return "";
            }
            set
            {
                // schreibe value mit Index
            }
        }

    }
}
