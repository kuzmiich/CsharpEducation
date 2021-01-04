using ConsoleApp1.interfaces;
using System;

namespace ConsoleApp1.classes
{
    struct User
    {
        public string name;
        public int age;
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }
    struct People
    {
        //public string name = "Sam";     // ! Ошибка
        //public int age = 23;            // ! Ошибка
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public People(string name, int age, string gender)
        {
            this.name = name;
            if (age < 0 || age > 120)
            {
                this.age = age;
            } else { throw new Exception("Error, incorrect data.Transfer number from 0 to 120"); }
            if (gender != "male" || gender != "female")
            {
                this.gender = gender;
            } else { throw new Exception("Error, incorrect data.Transfer 'male' or 'female'"); }
        }
        internal static string HiPeople(string name)
        {
            return $"Hi {name}";
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {this.name}  Age: {this.age}");
        }
    }
    class StructTraining : ITask
    {
        public static void OutTask()
        {
            User user = new User();
            user.DisplayInfo();
            //
            user.name = "name";
            user.age = 18;
            user.DisplayInfo();
            //
            string name = "Oleg";
            int age = 5;
            string gender = "male";
            People people = new People(name, age, gender);

            People.HiPeople(name);

            people.DisplayInfo();

            Console.Read();
        }
    }
}
