namespace DHBW.EinstiegDotNet.Beispiele.Syntax
{
    public class Operatoren
    {
        public void Beispiele()
        {
            var variable1 = 1 + 2;
            var variable2 = variable1 * variable1;
        }

        public void Binäre_Operatoren()
        {
            var variable1 = "Hallo " + "Welt";
            var variable2 = true | false;

            int? variable3 = null;
            var variable4 = variable3 ?? 12;

            var variable5 = 2 == 43;
        }

        public void Unäre_Operatoren()
        {
            var variable1 = +1;
            var variable2 = -5;
            var variable3 = !true;
        }

        public void Ternäre_Operatoren()
        {
            int variable1 = 1;

            var variable2 = variable1 > 0 ? "Hallo" : "Welt";
        }
    }
}
