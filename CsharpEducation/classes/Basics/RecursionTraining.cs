using System;
using System.Threading;

namespace Education.classes.Basics
{
    class RecursionTraining
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Расширение стэка вызова рекурсии");
            var stackSize = 1_000_000_000;
            Thread t = new Thread(new ThreadStart(BigRecursion), stackSize);
            t.Start();
            t.Join();
        }
        private static int Recurcur(int num)
        {
            return Recurcur(num) + 1;
        }

        private static void BigRecursion()
        {
            Console.WriteLine(Recurcur(1));
        }
    }
}
