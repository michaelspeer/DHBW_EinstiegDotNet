using System;

namespace DHBW.EinstiegDotNet.Beispiele.Generische_Typen
{
    public class Generische_Typconstraints
    {
        private class Adresse
        {
            public Adresse()
            {
            }
        }

        public interface IHatGeburtstag
        {
            DateTime Geburtstag { get; }
        }

        public T ErstelleAdresse<T>() where T : new()
        {
            return new T();
        }

        public DateTime LiefereGeburtsdatum<T>(T value) where T:IHatGeburtstag
        {
            return value.Geburtstag; 
        }
    }
}
