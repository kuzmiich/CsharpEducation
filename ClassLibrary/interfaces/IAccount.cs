namespace ClassLibrary.interfaces
{
    public interface IAccount
    {
        uint Bank { get; set; }
        void TakeMoney(uint sum);
        void PutMoney(uint sum);
    }
}
