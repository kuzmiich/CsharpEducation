using Education.interfaces;
using System;
using System.Threading;

namespace Education.classes.Advanced.Multithreading
{
    class MultithreadingBasicTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("---- class Thread ----");
            Thread thread = Thread.CurrentThread;

            Console.WriteLine($"Имя потока: {thread.Name}");
            Console.WriteLine($"Запущен ли поток: {thread.IsAlive}");
            Console.WriteLine($"Приоритет потока: {thread.Priority}");
            Console.WriteLine($"Статус потока: {thread.ThreadState}");
            Console.WriteLine($"Статус потока: {thread.IsBackground}");
            Console.WriteLine($"Статус потока: {thread.ThreadState}");
            Console.WriteLine($"Статус потока: {thread.ThreadState}");
            Console.WriteLine($"Домен приложения: {Thread.GetDomain().FriendlyName}");
        }
    }
}
