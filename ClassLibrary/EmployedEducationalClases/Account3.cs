using ClassLibrary.Base;

namespace ClassLibrary.EmployedEducationalClases
{

    public class Account3
    {
        public delegate void AccountHandler(object sender, AccountEventArgs e);
        public event AccountHandler Notify;

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
}
