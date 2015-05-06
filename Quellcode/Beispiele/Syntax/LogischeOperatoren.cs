namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    public class LogischeOperatoren
    {
        public void einfache_Vergleiche()
        {
            bool vergleich = 12 != 3;
            bool vergleich2 = 12 == 11;
   }

        public void Langschluss_Vergleiche()
        {
            bool ergebnis = Sehr_langlaufende_Funktion() & Extrem_langlaufende_Funktion(); // beide Funktionen werden ausgeführt
        }

        public void Kurzschluss_Vergleiche()
        {
            bool ergebnis = Sehr_langlaufende_Funktion() && Extrem_langlaufende_Funktion(); // nur die erste Funktion wird ausgeführt, danach steht logisch das Ergebnis FALSCH bereits fest
        }

        public bool Sehr_langlaufende_Funktion()
        {
            return false;
        }

        public bool Extrem_langlaufende_Funktion()
        {
            return true;
        }

        public void TestMethode(Berechnung berechnung)
        {
            if (berechnung!=null && berechnung.IsAnwenderValide())
            {

            }
            else
            {
                
            }
        }

    }
    public class Berechnung
    {
        public bool IsAnwenderValide()
        {
            return false;
        }
    }
}
