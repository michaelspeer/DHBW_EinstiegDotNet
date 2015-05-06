namespace DHBW.EinstiegDotNet.Beispiele.Verbungen.Abstrakte_Vererbung
{
    public abstract class FamilienMitglied
    {
        public abstract void Aufräumen();
    }

    public abstract class Erwachsener : FamilienMitglied
    {
        public abstract void Einkaufen();
    }

    public class Vater : Erwachsener
    {
        public override void Aufräumen()
        {
            //...
        }

        public override void Einkaufen()
        {
            //...
        }
    }
}
