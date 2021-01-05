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
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Person person1 = new Person("");
            person1.Display();
            Person person = new Client("", "");
            person.Display();
            Client client = new Client("", "");
            client.Display();
            Employee employee = new Employee("", "");
            employee.Display();
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
    }
}
