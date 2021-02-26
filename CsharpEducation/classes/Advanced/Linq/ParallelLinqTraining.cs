using Education.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Education.classes.Advanced.Linq
{
    class ParallelLinqTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Изучение Parallel Linq ----\n" +
                "Он представлен классом System.Linq.ParallelEnumerable.Методы расширения:\n" +
                "1.AsParallel - используется для параллельной обработки данных Linq запросами, используется там, где можно распараллелить данные\n" +
                "2.ForAll - перебирает данные в том же потоке в котором они обрабатываются\n" +
                "3.AsOrdered - упорядочивание в соответствии с текущей операцией(последовательностью)\n" +
                "4.AsUnordered - используется, когда упорядочивание больше не требуется" +
                "5.AggregateException - \n" +
                "6.WithCancellation - механизм, прерывания операции если выполняется некоторое уловие." +
                "Для исопользования необходимо передать токен экземпляра CancellationTokenSource\n"
            ); 
            int[] numbers = new int[] { -2, -1, 0, 1, 2, 4, 3, 5, 6, 7, 8, };

            var factorials = numbers.AsParallel()
                    .AsOrdered()
                    .Where(x => x > 0)
                    .Select(x => Factorial(x));
            try
            {
                factorials.ForAll(val => Console.WriteLine(val));
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static long Factorial(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Error, invalid number!");
            }

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
