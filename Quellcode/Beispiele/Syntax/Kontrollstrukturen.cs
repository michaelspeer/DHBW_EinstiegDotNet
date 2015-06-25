using System;
using System.Collections.Generic;

namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    public class Kontrollstrukturen
    {
        public void Vergleich_mit_If()
        {
            if (12 + 3 == 15)
            {
                // wahr
            }
            else
            {
                // falsch
            }
        }

        public void Vergleich_mit_verkettetem_If()
        {
            if (12 + 3 == 15)
            {

            }
            else if (11 + 3 == 14)
            {

            }
            else if (10 + 3 == 13)
            {

            }
            else // wird ausgeführt, wenn keine frühere Bedingung zutraf
            {

            }
        }

        public void Vergleich_mit_Ternärem_Operator()
        {
            int ergebnis = 12 + 5 == 15 ? 1 : 0; // liefert 1 bei Wahr, sonst 0
        }

        public void Vergleich_mit_binärem_NullOperator()
        {
            object eineReferenz = null;

            object ergebnis = eineReferenz ?? "neuer Wert";


            // Übersetzung
            if (eineReferenz != null)
            {
                ergebnis = eineReferenz;
            }
            else
            {
                ergebnis = "neuer Wert";
            }
        }

        public void Vergleich_mit_Switch()
        {
            Zustände aktuellerZustand = Zustände.Zustand3;

            switch (aktuellerZustand)
            {
                case Zustände.Zustand1:
                    Console.WriteLine("Zustand 1");
                    break;

                case Zustände.Zustand2:
                    Console.WriteLine("Zustand 12");
                    break;

                case Zustände.Zustand3:
                    Console.WriteLine("Zustand 3");
                    break;

                default:
                    throw new NotSupportedException("unbekannter Zustand");
            }
        }

        public void Schleife_mit_For()
        {
            // ReSharper disable once EmptyForStatement
            for (int index = 0; index < 100; index++)
            {

                // Schleife von 0 bis 99
                //continue;
                //break;

            }
        }

        public void Schleife_mit_Foreach()
        {
            var wochentage = new List<string>
            {
                "Montag", 
                "Dienstag",
                "Mittwoch", 
                "Donnerstag", 
                "Freitag", 
                "Samstag", 
                "Sonntag"
            };

            foreach (var wochentag in wochentage)
            {
               

            }
        }

        public void Schleife_mit_While()
        {
            while (true)
            {
                // Ausführung NACH Vergleich
            }
        }

        public void Schleife_mit_DoWhile()
        {
            do
            {
                
                // Ausführung VOR Vergleich
            } while (true);
        }

        private enum Zustände
        {
            Zustand1 = 1300,
            Zustand2 = 1400,
            Zustand3 = 1500,
        }
    }
}
