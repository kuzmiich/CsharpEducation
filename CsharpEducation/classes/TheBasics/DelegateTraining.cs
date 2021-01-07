using Education.interfaces;
using System;

namespace Education.classes.TheBasics
{
    class DelegateTraining : ITask
    {
        delegate void Message();
        public static void OutTask()
        {
            Console.WriteLine("----------Изучение делегата и работы с ним--------");
            Message mes; // Создаем переменную делегата
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                mes = GoodMorning; // Присваиваем этой переменной адрес метода
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
            {
                mes = GoodAfternoon;
            }
            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 24)
            {
                mes = GoodEvening;
            }
            else
            {
                mes = GoodNight;
            }
            mes(); // Вызываем метод
        }

        private static void GoodNight()
        {
            Console.WriteLine("Good Night");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
        private static void GoodAfternoon()
        {
            Console.WriteLine("Good afternoon");
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good morning");
        }
    }
}
