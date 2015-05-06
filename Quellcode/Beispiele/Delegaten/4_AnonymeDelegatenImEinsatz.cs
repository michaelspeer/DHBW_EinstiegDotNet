using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHBW.EinstiegDotNet.Beispiele.Delegaten.AnonymeDelegatenImEinsatz
{
    public class LogFramework
    {
        private readonly Action<string>_log;

        public LogFramework(Action<string> log)
        {
            _log = log;
        }

        public void KritischerFehler(string meldung)
        {
            this._log("Kritischer Fehler : " + meldung);
        }
    }

    public class Beispiel
    {
        public void Test()
        {
            var logger = new LogFramework(Console.WriteLine);

            logger.KritischerFehler("nichts geht!");
        }
    }
}
