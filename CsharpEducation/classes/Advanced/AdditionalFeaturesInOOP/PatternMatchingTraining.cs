using System;

namespace Education.classes.Advanced.AdditionalFeaturesInOOP
{
    class PatternMatchingTraining
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Pattern match ----\n" +
                "патерн, который предусматривает реализацию сравнения с некоторым шаблоном\n" +
                "Constant pattern - сопоставление с некоторой константой.\n"
            );

            Employee emp = new Manager();
            UseEmployee(emp);
        }
        static void UseEmployee(Employee emp)
        {
            switch (emp)
            {
                case Manager manager:
                    manager.Work();
                    break;
                case null:
                    Console.WriteLine("Объект не задан!");
                    break;
                default:
                    Console.WriteLine("Объект не менеджер!");
                    break;
            }
        }
        static void UseEmpolyee1(Employee emp)
        {
            Manager manager = emp as Manager;
            if (manager != null && manager.IsOnVacation == false)
            {
                manager.Work();
            }
            else
            {
                Console.WriteLine("Преобразование прошло неудачно!");
            }
        }
        static void UseEmplyee2(Employee emp)
        {
            if (emp is Manager)
            {
                Manager manager = (Manager)emp;
                if(!manager.IsOnVacation)
                {
                    manager.Work();
                }
            }
            else
            {
                Console.WriteLine("Преобразование недопустимо!");
            }
        }
        static void UseEmplyee3(Employee emp)
        {
            try
            {
                Manager manager = (Manager)emp;
                if(!manager.IsOnVacation)
                {
                    manager.Work();
                }
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Да работаю я, работаю");
        }
    }
    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Отлично, работаем дальше");
        }
        public bool IsOnVacation { get; set; }
    }
}
