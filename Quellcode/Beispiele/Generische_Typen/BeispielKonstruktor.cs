using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHBW.EinstiegDotNet.Beispiele.Generische_Typen
{
    public class BeispielKonstruktor<T> where T : new()
    {
        public T Create()
        {
            return new T(); // ermöglicht durch Type-Constraint new()
        }

        public void Add(T p1, T p2)
        {
            
        }
    }
}
