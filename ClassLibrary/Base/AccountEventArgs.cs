namespace ClassLibrary.Base
{
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
