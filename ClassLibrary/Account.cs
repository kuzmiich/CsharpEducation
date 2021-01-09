namespace ClassLibrary
{
    public class Account
    {
        // Объявляем делегат
        public delegate void AccountStateHandler(string message);
        // Создаем переменную делегата
        AccountStateHandler _accountStateHandler;

        public int _bank { get; private set; } // Переменная для хранения суммы на счете

        public Account(int bank)
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

        public void Withdraw(int sum)
        {
            if (sum <= _bank)
            {
                _bank -= sum;

                if (_accountStateHandler != null)
                {
                    _accountStateHandler($"Сумма {sum} снята со счета");
                }
            }
            else if(_accountStateHandler != null)
            {
                _accountStateHandler("Недостаточно денег на счете");
            }
        }
    }
}
