using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHBW.EinstiegDotNet.Beispiele.Schnittstellen
{
    public static class BeispielSchnitstelle
    {
        public static void Test()
        {
            double zahl1 = 12;
            double zahl2 = 36;
            IRechenart rechenart = new Addieren();

            double ergebnis = Rechnen(zahl1, zahl2, rechenart);
        }

        public static void BeispielSortieren()
        {
            var liste = new List<object>();

            liste.Sort();
        }

        public static double Rechnen(double Zahl1, double Zahl2, IRechenart konkreteRechenart)
        {
            return konkreteRechenart.Berechnen(Zahl1, Zahl2);
        }

    }

    public class Addieren : IRechenart
    {
        public double Berechnen(double Zahl1, double Zahle2)
        {
            return Zahl1 + Zahle2;
        }
    }

    public interface IRechenart
    {
       double Berechnen(double Zahl1, double Zahle2);
    }

    

}
