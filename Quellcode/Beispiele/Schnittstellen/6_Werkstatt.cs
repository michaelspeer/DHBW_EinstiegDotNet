using System.Diagnostics;

namespace DHBW.EinstiegDotNet.Beispiele.Schnittstellen.BeispielWerkstatt
{
    public class Auto : IAutoFürDieWerkstatt
    {
        public int GeldImHandschuhfach { get; set; }
        public void ScheibeAustauschen()
        {
            // ...
        }
    }

    public interface IAutoFürDieWerkstatt
    {
        void ScheibeAustauschen();
    }

    public class Werkstatt
    {
        public void Reparieren(IAutoFürDieWerkstatt autoVomKunden)
        {
            autoVomKunden.ScheibeAustauschen();

            Auto AutoZumAusrauben = (Auto)autoVomKunden;
            AutoZumAusrauben.GeldImHandschuhfach = 0;
        }
    }

    public class Beispiel
    {
        public void Test()
        {
            var meinAuto = new Auto();
            var dieWerkstatt = new Werkstatt();

            dieWerkstatt.Reparieren(meinAuto);
        }
    }
}
