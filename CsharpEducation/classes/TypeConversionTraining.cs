using Education.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.classes
{
    class TypeConversionTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("------Преобразование типов и перегрузка операторов преобразования типов------");
            Console.WriteLine("Изучил что такое приведение вниз, приведение вверх!");
            Console.WriteLine("Изучил ключевые слова as, is и как они работают!");
            Console.WriteLine("Работа с implicit|explicit! Работает только со статичными методами.");

            // простое приведение
            Person person1 = new Person("Олег");
            person1.Display();
            Client client = new Client("Артем", "Ebank");
            client.Display();
            Employee employee = new Employee("Юрий", "Epam");
            employee.Display();

            //приведение вверх
            Person person = new Client("Вова", "Epam");
            person.Display();

            // приведение вниз
            Client cl = new Client("Вова", "Epam");
            Person person2 = cl;
            Client client1 = (Client)person2;
            // Ключевое слово as - С помощью него программа пытается преобразовать выражение к определенному типу, при этом не выбрасывает исключение.
            // В случае неудачного преобразования выражение будет содержать значение null
            Person p = new Person("Tom");
            Employee emp = p as Employee;
            if (p as Employee == null)
            {
                Console.WriteLine("Преобразование прошло неудачно");
            }
            else
            {
                Console.WriteLine(emp.Company);
            }
            // Отлавливание InvalidCastException
            /*Person person1 = new Person("Tom");
            try
            {
                Employee emp = (Employee)person1;
                Console.WriteLine(emp.Company);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }*/
            // is - проверке допустимости преобразования с помощью ключевого слова
            Person person3 = new Person("Tom");
            if (person is Employee)
            {
                Employee employee2 = (Employee)person3;
                Console.WriteLine(employee2.Company);
            }
            else
            {
                Console.WriteLine("Преобразование не допустимо");
            }

            Person tom1 = new Person("Tom");
            Employee empl = tom1 as Employee;
            tom1.Name = "Bob";
            // Console.WriteLine(empl.Name); //System.NullReferenceException

            // Работа с implicit|explicit
            Counter counter1 = new Counter { Seconds = 23 };
            Console.WriteLine((int)counter1);   // 23

            Counter counter2 = counter1;
            Console.WriteLine(counter2.Seconds + 1);  // 23
        }
    }
    class Counter
    {
        public int Seconds { get; set; }
        public Counter() {}
        // неявное преобразование
        public static implicit operator Counter(int x)
        {
            return new Counter { Seconds = x };
        }
        // явное преобразование
        public static explicit operator int(Counter counter)
        {
            return counter.Seconds;
        }
    }
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine($"Person {Name}");
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
    }

    class Client : Person
    {
        public string Bank { get; set; }
        public Client(string name, string bank) : base(name)
        {
            Bank = bank;
        }
        public new void Display()
        {
            Console.WriteLine($"Person { Name }, Bank { Bank }");
        }
    }
}
