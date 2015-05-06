using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHBW.EinstiegDotNet.Beispiele.Delegaten.Logging
{
    public class LogFramework
    {
        private readonly LogDelegate _log;

        public delegate void LogDelegate(string meldung);

        public LogFramework(LogDelegate log)
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
