using System;
using System.Diagnostics;

namespace DHBW.EinstiegDotNet.Beispiele.Verbungen.DatenErben
{
    public class Vater
    {
        private string kreditkartePIN = "1234";
        protected readonly DateTime geburtsdatumPapa = new DateTime(1977, 8, 5);
        protected string adresse = "MeineStrasse 12";
    }

    public class Kind : Vater
    {
        public Kind()
        {
            Debug.WriteLine(geburtsdatumPapa);
            adresse = "Ich bin umgezogen!";

            // Debug.WriteLine(this.kreditkartePIN); // Mist!
        }
    }
}
