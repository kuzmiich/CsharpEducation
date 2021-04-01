using System;

namespace Education.classes.Basics
{
    class InterfaceCovarianceAndContravariance
    {
        public static void OutTask()
        {
            Console.WriteLine(
                "----Ковариантность и контравариантность обобщенных интерфейсов----\n" +
                "Имеется три возможных варианта поведения:\n" +
                "Ковариантность: позволяет использовать более конкретный тип, чем заданный изначально\n" +
                "Контравариантность: позволяет использовать более универсальный тип, чем заданный изначально\n" +
                "Инвариантность: позволяет использовать только заданный тип\n" +
                ""

            );
            // ковариантность
            IBank<DepositAccount> depositBank = new Bank<DepositAccount>();
            AccountCovariance acc1 = depositBank.CreateAccount(34);

            IBank<AccountCovariance> ordinaryBank = new Bank<DepositAccount>(); //IBank<AccountCovariance> ordinaryBank = depositBank;
            AccountCovariance acc2 = ordinaryBank.CreateAccount(45);

            // контравариантность
            ITransaction<AccountCovariance> accTransaction = new TransactionContravariance<AccountCovariance>();
            accTransaction.DoOperation(new AccountCovariance(), 400);

            ITransaction<DepositAccount> depAccTransaction = new TransactionContravariance<AccountCovariance>();
            depAccTransaction.DoOperation(new DepositAccount(), 450);
        }
    }
    class AccountCovariance
    {
        public virtual void DoTransfer(int sum)
        {
            Console.WriteLine($"Клиент положил на счет {sum} долларов");
        }
    }
    class DepositAccount : AccountCovariance
    {
        public override void DoTransfer(int sum)
        {
            Console.WriteLine($"Клиент положил на депозитный счет {sum} долларов");
        }
    }
    interface IBank<out T>
    {
        T CreateAccount(int sum);
    }
    class Bank<T> : IBank<T> where T : AccountCovariance, new()
    {
        public T CreateAccount(int sum)
        {
            T acc = new T();  // создаем счет
            acc.DoTransfer(sum);
            return acc;
        }
    }

    interface ITransaction<in T>
    {
        void DoOperation(T account, int sum);
    }

    class TransactionContravariance<T> : ITransaction<T> where T : AccountCovariance
    {
        public void DoOperation(T account, int sum)
        {
            account.DoTransfer(sum);
        }
    }
}
