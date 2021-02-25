using ClassLibrary.interfaces;
using System;

namespace ClassLibrary.EmployedEducationalClases
{
    public class NewTransaction<T> where T : IAccount, IClient
    {
        public void Operate(T acc1, T acc2, uint sum)
        {
            if (acc1.Bank >= sum)
            {
                acc1.TakeMoney(sum);
                acc2.PutMoney(sum);
                Console.WriteLine($"{acc1.Name} : {acc1.Bank}\n{acc2.Name} : {acc2.Bank}");
            }
        }
    }
}
