﻿using System;

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

            _notify?.Invoke($"На счет поступило {_bank}");
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
    public class Account3
    {
        public delegate void AccountHandler(object sender, AccountEventArgs e);
        private event AccountHandler Notify;

        public uint _bank { get; private set; } // Переменная для хранения суммы на счете

        public Account3(uint bank)
        {
            _bank = bank;
        }
        public void PutMoney(uint money)
        {
            _bank += money;

            Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {_bank}", _bank));
        }
        public void TakeMoney(uint money)
        {
            if (money <= _bank)
            {
                _bank -= money;

                Notify?.Invoke(this, new AccountEventArgs($"Сумма {money} снята со счета", money));
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs($"Недостаточно денег на счете.Текущий баланс {_bank}", money));
            }
        }
    }
    public class AccountEventArgs
    {
        public string Message { get; }
        public uint Bank { get; }

        public AccountEventArgs(string mes, uint money)
        {
            Message = mes;
            Bank = money;
        }
    }
}
