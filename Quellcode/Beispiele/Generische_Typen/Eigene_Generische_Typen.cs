using System;
using System.Collections.Generic;

namespace DHBW.EinstiegDotNet.Beispiele.Generische_Typen
{
    public class Eigene_Generische_Typen
    {
        public interface IDatabaseObject
        {
            int Id { get; }
        }

        public class Adresse : IDatabaseObject
        {
            public int Id { get; private set; }
            public string Name { get; set; }
            public string Vorname { get; set; }

        }

        public class UpdateResult<T>
        {
            public T Value { get; set; }
            public bool HasBeenUpdated { get; set; }
        }

        public void Speichere_Adressen() 
        {
            var adressen = new List<Adresse>
                {
                    new Adresse {Name = "Meier", Vorname = "Hans"},
                    new Adresse {Name = "Müller", Vorname = "Egon"},
                };


            foreach (var adresse in adressen)
            {
                var result = UpdateObject<Adresse>(adresse);
                
                Console.WriteLine("ID: {0}, Result: {1}",result.Value.Id,result.HasBeenUpdated);
            }
        }


        public UpdateResult<T> UpdateObject<T>(T value) where T : IDatabaseObject
        {
            var x = value.Id;
            return new UpdateResult<T> {Value = value, HasBeenUpdated = true};
        }
    }
}
