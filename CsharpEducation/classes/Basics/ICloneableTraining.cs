using ClassLibrary.Base;
using System;

namespace Education.classes.Basics
{
    class ICloneableTraining
    {
        public static void OutTask()
        {
            Console.WriteLine("----Изучение интерфейса ICloneable----\n" +
            "Реализация интерфейса ICloneable, и класса который его наследует\n" +
            "Есть метод объекта this.MemberwiseClone, для того чтобы сделать копию\n" +
            "Этот метод реализует поверхностное (неглубокое) копирование.\n" +
            "При глубоком копировании необходимо реализовать ВСЕ поля объекта\n"
            );
            
            // поверхностное копирование
            River river1 = new River("Птичь", 1000);
            River river2 = (River)river1.Clone();
            river1.SetAge(500);
            Console.WriteLine($"River1 age - {river1._age}");
            Console.WriteLine($"River2 age - {river2._age}");

            // глубокое копирование
            River2 river3 = new River2("Припять", 1500) { Person = new Person ("Иванов И.В.", "мужчина", 50) };
            River2 river4 = (River2)river3.Clone();
            river3.SetAge(700);
            river4.Person.FIO = "Дурачок";
            river4.Person.Gender = "женщина";
            Console.WriteLine($"River3 name - {river3._name}\nRiver3 age - {river3._age}\nPerson info - {river3.Person.ToString()}");
            Console.WriteLine($"River4 name - {river4._name}\nRiver4 age - {river4._age}\nPerson info - {river4.Person.ToString()}");

        }
    }
    class River : ICloneable
    {
        public River(string name, uint age)
        {
            _name = name;
            _age = age;
        }
        public string _name { get; private set; }
        public uint _age { get; private set; }

        public void SetAge(uint value)
        {
            _age = value;
        }
        public void SetName(string value)
        {
            _name = value;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
    class River2 : ICloneable
    {
        public River2(string name, uint age)
        {
            _name = name;
            _age = age;
        }
        public string _name { get; private set; }
        public uint _age { get; private set; }
        public Person Person { get; set; }
        public void SetAge(uint value)
        {
            _age = value;
        }
        public void SetName(string value)
        {
            _name = value;
        }

        public object Clone()
        {
            return new River2(_name = this._name, _age = this._age)
            {
                Person = new Person(this.Person.FIO, this.Person.Gender, this.Person.Age)
            };
        }
    }
}
