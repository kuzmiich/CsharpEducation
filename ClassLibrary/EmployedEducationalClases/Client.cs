using ClassLibrary.Interfaces;
using System;

namespace ClassLibrary.EmployedEducationalClases
{

    public class Client : IClient, IAccount
    {
        public Client(string name, uint bank)
        {
            Name = name;
            Bank = bank;
        }

        public string Name { get; set; }
        public uint Bank { get; set; }

        public void PutMoney(uint money)
        {
            Bank += money;
            Console.WriteLine($"Сумма {money} добавлена на счет");
        }

        public void TakeMoney(uint money)
        {
            if (money <= Bank)
            {
                Bank -= money;
                Console.WriteLine($"Сумма {money} снята со счета");
            }
            else
            {
                Console.WriteLine("Недостаточно денег на счете");
            }
        }
    }
}
