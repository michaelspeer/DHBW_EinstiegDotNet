using System;

namespace DHBW.EinstiegDotNet.Beispiele.AnonymeMethoden.LambdaAusdrücke
{
    public class Beispiel
    {
        public void Test()
        {
            Action Log = () => Console.WriteLine("ein Wert");
            Action<string> Log2 = (wert) => Console.WriteLine(wert);
            Action<string, int> log3 = (wert, anzahl) => Console.WriteLine(anzahl.ToString() + " : " + wert);
            Action<string> log4 = Console.WriteLine;
        }
    }
}
