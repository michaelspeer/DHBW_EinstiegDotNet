using System;

namespace DHBW.EinstiegDotNet.Beispiele.AnonymeMethoden.AnonymeMethodenAlsParameter
{
    public class Beispiel
    {
        public Action<int> Wiederholen(string wert)
        {
            return (anzahl) =>
            {
                for (int i = 0; i < anzahl; i++)
                {
                    Console.WriteLine(wert);
                }
            };
        }
        
        public void Test()
        {
            var wiederholen = this.Wiederholen("Hallo Welt");

            wiederholen(5);
        }
    }
}
