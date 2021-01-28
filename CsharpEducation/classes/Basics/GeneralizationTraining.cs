using Education.interfaces;
using System;
using static ClassLibrary.Sorting;

namespace Education.classes.Basics
{
    class GeneralizationTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("----Изучение всего что связано с обобщениями----\n" +
            "Использование нескольких универсальных параметров, обобщенных классов\n" +
            "where T(некоторый_тип) : тип_ограничения\n" +
            "Какие есть ограничения для классов:\n" +
            "Классы\n" +
            "Интерфейсы\n" +
            "class - универсальный параметр должен представлять класс\n" +
            "struct - универсальный параметр должен представлять структуру\n" +
            "new() - универсальный параметр должен представлять открытый конструктор без параметров,\n" +
            "который имеет общедоступный(public) конструктор без параметров\n"
            ); 
            Console.WriteLine();
            // 1
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = new int[] { 4, 5, 6 };
            Swap(ref arr1, ref arr2);
            Console.WriteLine(string.Join(' ', arr1));
            Console.WriteLine(string.Join(' ', arr2));
            // 2
            Account<int> acc1 = new Account<int> (1) { Sum = 4500 };
            Account<int> acc2 = new Account<int> (2) { Sum = 5000 };

            Transaction<Account<int>, string> transaction1 = new Transaction<Account<int>, string>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Code = "45478758",
                Sum = 900
            };
            Console.WriteLine($"Поле FromAccount - {transaction1.FromAccount},\nполе ToAccount - {transaction1.FromAccount}");
            Console.WriteLine($"Поле code {transaction1.Code}, поле sum - {transaction1.Sum}");

            Transaction<Account<int>> transaction2 = new Transaction<Account<int>>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 900
            };
            transaction2.Execute();
        }
    }
    class Account<T>
    {
        public T Id { get; private set; } // номер счета
        public int Sum { get; set; }
        public Account(T _id)
        {
            Id = _id;
        }
        public override string ToString()
        {
            return $"Id - {Id}, Sum - {Sum}$";
        }
    }
    class Transaction<U, V>
    {
        public U FromAccount { get; set; }  // с какого счета перевод
        public U ToAccount { get; set; }    // на какой счет перевод
        public V Code { get; set; }         // код операции
        public int Sum { get; set; }        // сумма перевода
    }
    class Transaction<T> where T : Account<int>
    {
        public T FromAccount { get; set; }  // с какого счета перевод
        public T ToAccount { get; set; }    // на какой счет перевод
        public int Sum { get; set; }        // сумма перевода
        public void Execute()
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine($"Счет {FromAccount}\nСчет {ToAccount}");
            }
            else
            {
                Console.WriteLine($"Недостаточно денег на счете {FromAccount.Id}");
            }
        }
    }
}
