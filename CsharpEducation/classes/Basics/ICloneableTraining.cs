using ClassLibrary;
using Education.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.classes.Basics
{
    class ICloneableTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("----Изучение интерфейса ICloneable----");
            Console.WriteLine("Реализация интерфейса ICloneable, и класса который его наследует");
            Console.WriteLine("Есть метод объекта this.MemberwiseClone, для того чтобы сделать копию");
            Console.WriteLine("Этот метод реализует поверхностное (неглубокое) копирование.");
            Console.WriteLine("При глубоком копировании необходимо реализовать ВСЕ поля объекта");
            Console.WriteLine();
            
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
    public interface ICloneableDeep
    {
        object Clone();
    }
    public interface ICloneableSurface
    {
        object Clone();
    }
    class River : ICloneableSurface
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
            return this.MemberwiseClone();
        }
    }
    class River2 : ICloneableDeep
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
