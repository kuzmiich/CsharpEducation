using Education.interfaces;
using System;

namespace Education.classes.Basics
{
    class DelegateActionPredicateFunc : ITask
    {
        public delegate void Action<T>(T value1);
        //public delegate void Action<T>(T value1, T value2);
        public static void OutTask()
        {
            Console.WriteLine("------ Делегаты Action, Predicate и Func ------");
            Console.WriteLine("Делегат Action представляет из себя обобщенный делегат, который ничего не возращает, имеющий перегрузку до 16 параметров.");
            Console.WriteLine("Делегат Predicate используется для сопоставления входного значения некоторому условию."+
                              "Не имеет перегрузок!");
            Console.WriteLine("Делегат Func, наиболее распространен, т.к. его можно модифицировать различными входными параметрами" +
                              "и выходными параметрами с модификаторами in, out.Также имеет 16 перегрузок");
            // Action
            Action<int, int> operation;
            operation = Sum;
            Operation(5, 4, operation);
            operation = Multiply;
            Operation(10, 6, operation);

            // Predicate
            Predicate<int> isPositive = delegate (int x)
            {
                return x > 0;
            };
            Console.WriteLine(isPositive(-20));
            Console.WriteLine(isPositive(20));

            // Func
            Func<int, int> getFactorialNumber = Factorial;
            int res1 = GetFactorialNumber(6, getFactorialNumber);
            Console.WriteLine(n1);

            int res2 = GetFactorialNumber(6, x => x * x);
            Console.WriteLine(n2);
        }
        private static void Operation(int x, int y, Action<int, int> operation)
        {
            if (x > y)
            {
                operation(x, y);
            }
            else
            {
                operation(y, x);
            }
        }
        private static void Sum(int x, int y)
        {
            Console.WriteLine($"Сумма чисел:{ x+y }");
        }
        private static void Multiply(int x, int y)
        {
            Console.WriteLine($"Деление чисел: { x/y }");
        }
        private static int GetFactorialNumber(int x1, Func<int, int> retF)
        {
            if (x1 > 0)
            {
                return (int)retF(x1);
            }
            return default;
        }
        private static int Factorial(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
