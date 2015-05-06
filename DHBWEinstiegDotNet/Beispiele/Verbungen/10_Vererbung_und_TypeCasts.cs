using System;

namespace DHBW.EinstiegDotNet.Beispiele.Verbungen.VererbungUndTypeCasts
{
    public class Kind
    {
        public virtual void Hausarbeit()
        {
            Console.WriteLine("Ab und zu aufräumen");
        }

        public void Essen()
        {
            Console.WriteLine("Bääh");
        }
    }

    public class Erwachsener : Kind
    {
        public override void Hausarbeit()
        {
            base.Hausarbeit();
            Console.WriteLine("Müll rausbringen");
            Console.WriteLine("Haus saugen");
        }
    }

    public class Tochter : Erwachsener
    {
        public new void Essen()
        {
            Console.WriteLine("Lecker");
        }
    }

    public static class Beispiel
    {
        public static void Test()
        {
            Console.WriteLine("Tochter:");
            Console.WriteLine();

            var meineTochter = new Tochter();
            meineTochter.Hausarbeit();
            meineTochter.Essen();

            Console.WriteLine();
            Console.WriteLine("Tochter als Kind:");
            Console.WriteLine();

            var meineTochterAlsKleinesKind = (Kind)meineTochter;

            meineTochterAlsKleinesKind.Hausarbeit();
            meineTochterAlsKleinesKind.Essen();
        }
    }
}
