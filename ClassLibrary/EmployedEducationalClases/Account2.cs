using System;

namespace ClassLibrary.EmployedEducationalClases
{

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
}
