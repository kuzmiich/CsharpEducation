namespace ClassLibrary
{
    public class Account
    {
        public delegate void AccountStateHandler(string message);
        AccountStateHandler _accountStateHandler { get; set; }

        public uint _bank { get; private set; } // Переменная для хранения суммы на счете

        public Account(uint bank)
        {
            _bank = bank;
            this.RegisterHandler(_accountStateHandler);
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
}
