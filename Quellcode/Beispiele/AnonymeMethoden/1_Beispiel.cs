using System;

namespace DHBW.EinstiegDotNet.Beispiele.AnonymeMethoden.Beispiel
{
    public class Beispiel
    {
        public void Test()
        {
            Action meineMethode = () =>
            {
                var a = 12;
                var b = 27;

                Console.WriteLine(a + b);
            };

            meineMethode();
        }

        public void Test2()
        {
            Action<string, int> meineNeueMethode;

            meineNeueMethode = (wert1, wert2) =>
            {
                // ...

            };

            meineNeueMethode("123", 123);
        }
    }
}
