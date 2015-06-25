using System;

namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    public  class StatischeKlassen
    {
        private static DateTime _datum;

        // statischer Konstruktor
        static StatischeKlassen()
        {
            _datum = DateTime.Now;
        }

        public static void Something()
        {

        }

        //public int Irgendwas() // funktioniert nicht
        //{
        //    return 0;
        //}
    }


    public class Verwendung_einer_statischen_Klasse
    {
        public void Test()
        {
            StatischeKlassen.Something();

            
        }
    }
}
