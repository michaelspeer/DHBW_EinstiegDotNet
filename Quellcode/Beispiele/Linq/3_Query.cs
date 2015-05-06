using System;
using System.Collections.Generic;
using System.Linq;

namespace DHBW.EinstiegDotNet.Beispiele.Linq.Query
{
    public static class Beispiel
    {
        public static void Test()
        {
            List<int> zahlen = new List<int> {1, 2, 3, 4, 5};

            IEnumerable<int> zahlenGrößer3 = zahlen.Where(zahl => zahl > 3);
            
            zahlen.Add(6);
            zahlen.Add(7);
            zahlen.Add(8);

            Console.WriteLine(zahlenGrößer3.Count());

            zahlen.Add(9);
            zahlen.Add(10);

            Console.WriteLine(zahlenGrößer3.Count());

            Something(zahlenGrößer3);
        }

        public static void Something(IEnumerable<int> values)
        {
            
        }

        public static IEnumerable<int> Iteration()
        {
            for (int i = 0; i < 100; i++)
            {
                yield return i;
            }
        }
    }
}
