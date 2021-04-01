using System;

namespace Education.classes.Advanced.AdditionalFeaturesInOOP
{
    class PartialClassAndMethodTraining
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Частичные классы и методы ----" +
                "Частичные классы и методы определяются с помощью ключевого слова partial\n" +
                "Можно использовать только перед class, record, struct, interface или void\n" +
                "Частичные методы без тела необходимо переопределить в другом частичном классе\n" +
                "2.Частичные методы всегда имеют тип void\n" +
                "Частичные методы не могут иметь такие модификаторы как:\n" +
                "virtual, abstract, override, new, sealed.\n" +
                "Хотя допустимы static partial методы.\n" +
                "В partial методах не допустима использование out ссылок" 
            );
            Person oleg = new();
            oleg.Eat();
            oleg.Move();
            Person.DoSomething();
            oleg.DoSomethingElse();
        }
    }
    partial class Person
    {
        public void Eat()
        {
            Console.WriteLine("I`m eating");
        }
        public partial void DoSomethingElse();
        public static void DoSomething()
        {
            Console.WriteLine("Do something");
        }
    }
    partial class Person
    {
        public partial void DoSomethingElse()
        {
            Console.WriteLine("Do something else!");
        }

        public void Move()
        {
            Console.WriteLine("I`m moving");
        }
    }
}
