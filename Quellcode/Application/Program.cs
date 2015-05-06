using System;
using Bibliothek;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufruf von MeineOperation(\"Meine Werte!\")");
            Operationen.MeineOperation("Meine Werte!");
            Console.WriteLine();
            Console.WriteLine("Aufruf von MeineOperation()");
            Operationen.MeineOperation();
        }
    }
}
