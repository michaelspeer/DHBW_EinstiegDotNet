using System;
using System.Collections;
using System.Collections.Generic;

namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    class Listen
    {
        public void Verwendung_von_ArrayList()
        {
            ArrayList liste = new ArrayList();
            liste.Add(12);
            liste.Add("Hallo");
            liste.Add(DateTime.Now);

            
        }

        public void Verwendung_von_List()
        {
            List<string> liste = new List<string>();
            liste.Add("erster String");
            liste.Add("zweiter String");

        }

        public void Verwendung_von_Hashtable()
        {
            var werte = new Hashtable();

            werte.Add("Schlüssel", "Wert");
            werte.Add(1,2);
        }

        public void Verwendung_von_Dictionary()
        {
            var werte = new Dictionary<int,string>();

            werte.Add(1, "Müller");
            werte.Add(2, "Meier");

        }

        public void Verwendung_von_Queue()
        {
            var werte = new Queue<int>();

            werte.Enqueue(1);
            werte.Enqueue(2);
            werte.Enqueue(3);

            var wert = werte.Dequeue(); // liefert 1
        }

        public void Verwendung_von_Stack()
        {
            var werte = new Stack<int>();
            werte.Push(1);
            werte.Push(2);
            werte.Push(3);

            var wert = werte.Pop();

        }

    }
}
