using ClassLibrary;
using Education.interfaces;
using System;

namespace Education.classes.Basics
{
    class DelegateEventTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("----Изучение event----");
            Console.WriteLine("_Событие не может свойством!_");
            Console.WriteLine("При вызове события будет вызываться последнее событие в списке вызовов, как и с делегатами");
            Console.WriteLine("Добавление анонимных методов");
            Console.WriteLine("Реализация добавления и удаления событий внутри класса");
            Console.WriteLine("В event мождо добавлять делегат, метод и лямбда-функцию");
            Account2 account = new Account2(1000);
            account.Notify += ShowMessage;
            account.TakeMoney(100);
            ShowMessage($"Сумма на счете = {account._bank}");
            account.Notify += ColorMessage;
            account.Notify -= ShowMessage;
            account.PutMoney(40);
            account.Notify -= ColorMessage;
            ShowMessage($"Сумма на счете = {account._bank}");
            account.Notify += ShowMessage;
            account.PutMoney(500);
            ShowMessage($"Сумма на счете = {account._bank}");
            account.Notify -= ShowMessage;

            // добавление анонимных методов
            account.Notify += delegate (string mes)
            {
                Console.WriteLine(mes);
            };
            account.PutMoney(100);
            ShowMessage($"Сумма на счете = {account._bank}");
            account.TakeMoney(200);
            ShowMessage($"Сумма на счете = {account._bank}\n");

            // удаление и добавление событий через методы внутри класса
            Account2 account2 = new Account2(100);
            account2.Notify += ShowMessage;
            account2.PutMoney(20);
            ShowMessage($"Сумма на счете = {account2._bank}");
            account2.Notify -= ShowMessage;
            account2.PutMoney(20);
            ShowMessage($"Сумма на счете = {account2._bank}\n");

            //
        }

        private static void ShowMessage(string value)
        {
            Console.WriteLine(value);
        }
        private static void ColorMessage(string message)
        {
            // Устанавливаем красный цвет символов
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            // Сбрасываем настройки цвета
            Console.ResetColor();
        }
    }
}
