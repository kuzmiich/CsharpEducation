using Education.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.classes.Advanced
{
    class AdditionalClassesAndStructures : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine(
                "---- Дополнительные классы и структуры ----\n" +
                "1.Структура DateTime представляет из себя объект, который содержится в пространстве имен System\n" +
                "Данный объект, используется для работы со временем\n" +
                "2.\n" +
                "3.\n" +
                "4.\n"
            );

            // DataTime
            DateTime date = new DateTime();
            // Lazy initialization
            Person person = new Person();
            person.PlayGuitar();
            person.DoesntPlayGuitar();
            person.DoesntPlayGuitar();
            person.DoesntPlayGuitar();
            person.DoesntPlayGuitar();
            person.PlayGuitar();
        }
    }








    class Guitar
    {
        private static string _notes;
        public string PlayMusic { 
            get
            {
                return "Song ♫♫♫";
            }
            set
            {
                _notes = value;
            }
        }
    }
    class Person
    {
        Lazy<Guitar> guitar = new Lazy<Guitar>();

        public void PlayGuitar()
        { 
            Console.WriteLine($"{guitar.Value.PlayMusic}.Играет на гитаре!");
        }
        public void DoesntPlayGuitar()
        {
            Console.WriteLine("Не играет на гитаре");
        }
    }
}
