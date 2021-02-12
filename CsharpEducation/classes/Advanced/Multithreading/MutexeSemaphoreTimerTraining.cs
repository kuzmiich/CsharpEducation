using Education.interfaces;
using System;
using System.Threading;

namespace Education.classes.Advanced.Multithreading
{
    class MutexeSemaphoreTimerTraining : ITask
    {
        private static Mutex _mutex = new Mutex();
        public static void OutTask()
        {
            Console.WriteLine("---- Изучение Mutex, Semaphore, Timer ----\n" +
                "1.Mutex представляет из себя объект ссылочного типа, который используется в механизме:\n" +
                "'приостановка потока пока не получен _mutex + после обработки запроса поток освобождается.'\n" +
                "2.''" +
                "3."
            );
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Factorial);
                myThread.Name = $"Поток {i}";
                myThread.Start(5);
            }

        }

        private static void Factorial(object num)
        {
            _mutex.WaitOne(); // приостанавливает выполнение потока до тех пор пока не будет получен _mutex
            int x = 1;
            for (int i = 1; i < (int)num + 1; i++)
            {
                x = x * i;
                Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                Thread.Sleep(100);
            }
            _mutex.ReleaseMutex(); // когда мьютекс не нужен освобождает поток
        }
        private static void Factorial2(object num)
        {
            _mutex.WaitOne(); // приостанавливает выполнение потока до тех пор пока не будет получен _mutex
            int x = 1;
            for (int i = 1; i < (int)num + 1; i++)
            {
                x = x * i;
                Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                Thread.Sleep(100);
            }
            _mutex.ReleaseMutex(); // когда мьютекс не нужен освобождает поток
        }
    }
}
