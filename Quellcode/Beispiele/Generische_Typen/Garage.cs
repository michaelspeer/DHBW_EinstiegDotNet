namespace DHBW.EinstiegDotNet.Beispiele.Generische_Typen
{
    public class Garage<T> where T : IFahrzeug, new()
    {
        public Garage()
        {
            this.Inhalt = new T();
        }

        public T Inhalt { get; set; }

        public void Putzen(T inhalt)
        {
        }
    }

    public interface IFahrzeug
    {
        void MotorAbstellen();

    }

    public class Auto:IFahrzeug
    {
        public void MotorAbstellen()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Schiff: IFahrzeug
    {
        public void MotorAbstellen()
        {

        }
    }

    public class Beispiel
    {
        public void Test()
        {
            Garage<Auto> GarageFürAuto = new Garage<Auto>();
            GarageFürAuto.Inhalt = new Auto();

            Garage<Schiff>  GarageFürSchiff = new Garage<Schiff>();
           
        }
    }
}
