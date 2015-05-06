using System;

namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    public class Musterklasse
    {
        private readonly int _id;
        private string _vorname;
        private Guid _guid;

        public Musterklasse(int id)
        {
            _id = id;
            _guid = Guid.NewGuid();
        }

        public int Id
        {
            get { return _id; }
        }

        public string Vorname
        {
            get { return _vorname; }
            set { _vorname = value; }
        }

        public string Nachname { get; set; }

        public string GetDisplayname()
        {
            return Vorname + " " + Nachname;
        }
    }
}
