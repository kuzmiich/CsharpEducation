using System;

namespace ClassLibrary
{
    public class Account
    {
        public delegate void AccountStateHandler(string message);
        event AccountStateHandler Notify;
        AccountStateHandler _accountStateHandler { get; set; }

        public uint _bank { get; private set; } // Переменная для хранения суммы на счете

        public Account(uint bank)
        {
            _bank = bank;
        }
        // Регистрируем делегат
        public void RegisterHandler(AccountStateHandler accountStateHandler)
        {
            _accountStateHandler = accountStateHandler;
        }
        // Отмена регистрации делегата
        public void UnregisterHandler(AccountStateHandler accountStateHandler)
        {
            _accountStateHandler -= accountStateHandler; // удаляем делегат
        }
        public void PutMoney(uint money)
        {
            _bank += money;
            if (_accountStateHandler != null)
            {
                _accountStateHandler($"Сумма {money} добавлена на счет");
            }
        }
        public void TakeMoney(uint money)
        {
            if (money <= _bank)
            {
                _bank -= money;

                if (_accountStateHandler != null)
                {
                    _accountStateHandler($"Сумма {money} снята со счета");
                }
            }
            else if(_accountStateHandler != null)
            {
                _accountStateHandler("Недостаточно денег на счете");
            }
        }
    }
    public class Account2
    {
        public delegate void AccountHandler(string message); 
        private event AccountHandler _notify;
        public event AccountHandler Notify
        {
            add
            {
                _notify += value;
                Console.WriteLine($"{value.Method.Name} добавлен");
            }
            remove
            {
                _notify -= value;
                Console.WriteLine($"{value.Method.Name} удален");
            }
        }

        public uint _bank { get; private set; } // Переменная для хранения суммы на счете

        public Account2(uint bank)
        {
            _bank = bank;
        }
        public void PutMoney(uint money)
        {
            _bank += money;

            _notify?.Invoke($"Сумма {money} добавлена на счет");
        }
        public void TakeMoney(uint money)
        {
            if (money <= _bank)
            {
                _bank -= money;

                _notify?.Invoke($"Сумма {money} снята со счета");
            }
            else
            {
                _notify?.Invoke($"Недостаточно денег на счете.Текущий баланс {_bank}");
            }
        }
    }
    class AccountEventArgs
    {
        // Сообщение
        public string Message { get; }
        // Сумма, на которую изменился счет
        public int Bank { get; }

        public AccountEventArgs(string mes, int money)
        {
            Message = mes;
            Bank = money;
        }
    }
}
