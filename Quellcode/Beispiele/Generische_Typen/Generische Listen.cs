using System;
using System.Collections;
using System.Collections.Generic;

namespace DHBW.EinstiegDotNet.Beispiele.Generische_Typen.Generische_Listen
{
    public class Adresse
    {
        public string Strasse { get; set; }
        public int Hausnummer { get; set; }
    }

    public class Beispiel
    {

        public void Verwendung_einer_generischen_Liste()
        {
            List<Adresse> adressen = new List<Adresse>();

            adressen.Add(new Adresse() { Hausnummer = 12, Strasse = "Hauptstrasse" });
            adressen.Add(new Adresse() { Hausnummer = 1, Strasse = "Marktplatz" });

            Adresse adresse3 = new Adresse();
            adresse3.Hausnummer = 12;
            adresse3.Strasse = "";
            adressen.Add(adresse3);

            adressen[0].Hausnummer = 13;
        }

        public void Nicht_typisierte_Liste()
        {
            ArrayList adressen = new ArrayList();
            adressen.Add(new Adresse() { Hausnummer = 12, Strasse = "Hauptstrasse" });
            adressen.Add(new Adresse() { Hausnummer = 1, Strasse = "Marktplatz" });
            adressen.Add("Hallo");

            Object erstesObjekt = adressen[0];
            var ersteAdresse = (Adresse)erstesObjekt;

            Object drittesObjekt = adressen[2];
            var dritteAdresse = (Adresse)drittesObjekt;
        }
    }
}
