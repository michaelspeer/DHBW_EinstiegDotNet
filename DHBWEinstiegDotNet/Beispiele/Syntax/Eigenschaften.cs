namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    public class Eigenschaften
    {
        private string _wert;


        public string AutoProperty { get; set; }
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

        // Indeizierte Eigenschaft
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
