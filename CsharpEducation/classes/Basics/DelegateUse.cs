using Education.interfaces;
using System;
using Account = ClassLibrary.Account;

namespace Education.classes.Basics
{
    class DelegateUse : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("--------Использование делегатов--------\n" +
            "Передача метода делегату представленному как поле класса\n"
            );
            
            Account account = new Account(1000);
            account.RegisterHandler(new Account.AccountStateHandler(ShowMessage));
            Account.AccountStateHandler colorDelegate = 
                new Account.AccountStateHandler(ColorMessage);
            account.RegisterHandler(colorDelegate);
            account.TakeMoney(100);
            ShowMessage($"Сумма на счете = {account._bank}");
            account.TakeMoney(300);
            ShowMessage($"Сумма на счете = {account._bank}");
            account.TakeMoney(700);
            //
            account.UnregisterHandler(colorDelegate);
            account.TakeMoney(50);
            ShowMessage($"Сумма на счете = {account._bank}");
        }
        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
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