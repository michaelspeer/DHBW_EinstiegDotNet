namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    class IndizierteEigenschaft
    {
        private string[] _werte=new string[]{"wert1","wert2","wert3"};

        public string this[int index]
        {
            get { return _werte[index]; }
            set
            {
                // ...
            }
        }
    }

    class Test
    {
        public void DoIt()
        {
            IndizierteEigenschaft x = new IndizierteEigenschaft();
            string Wert2 = x[2];
        }
    }
}
