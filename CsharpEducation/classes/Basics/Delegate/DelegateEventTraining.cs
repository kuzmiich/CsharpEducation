﻿using ClassLibrary.Base;
using ClassLibrary.EmployedEducationalClases;
using System;

namespace Education.classes.Basics.Delegate
{
    class DelegateEventTraining
    {
        public static void OutTask()
        {
            Console.WriteLine(
            "----Изучение event----\n" +
            "_Событие не может свойством!_" +
            "При вызове события будет вызываться последнее событие в списке вызовов, как и с делегатами\n" +
            "Добавление анонимных методов\n" +
            "Реализация добавления и удаления событий внутри класса\n" +
            "В event мождо добавлять делегат, метод и лямбда-функцию\n" +
            "Можно описывать делегат с использованием своего класса и передавать его 2 параметром\n" +
            "Для событий можно моксимально компактно описать методы, а также расширять класс для передачи в делегат\n");
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

            // добавление класса в делегат, не нужно добавлять обработчик на добавление и удаление события
            Account3 account3 = new Account3(100);
            account3.Notify += ShowMessage;
            account3.PutMoney(20);
            account3.TakeMoney(40);
            account3.TakeMoney(5);
        }
        private static void ShowMessage(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Сумма транзакций:{e.Bank}");
            Console.WriteLine(e.Message);
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
