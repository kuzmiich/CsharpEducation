using Education.interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Education.classes.Advanced.Multithreading
{
    class MutexeSemaphoreTimerTraining : ITask
    {
        private static Mutex _mutex = new Mutex();
        public static void OutTask()
        {
            Console.WriteLine("---- Изучение Mutex, Semaphore, Timer ----\n" +
                "1.Mutex представляет из себя неизменяемый объект ссылочного типа, который используется в механизме:\n" +
                "'приостановка потока пока не получен _mutex + после обработки запроса поток освобождается.'\n" +
                "2.Semaphore - неизменяемый объект ссылочного типа, которой можно ограничивать по min и max количеству участников.\n" +
                "3.Timer - неизменяемый объект ссылочного типа\n" +
                "Используется для остановки потока на определенное время.Передаваемые параметры:\n" +
                "1.экземпляр делегата TimerCallback\n" +
                "2.параметры передаваемого метода\n" +
                "3.Через сколько нужно запустить\n" +
                "4.На какое время ставить задержку\n"
            );

            // 1

            /*for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Factorial);
                myThread.Name = $"Поток {i}";
                myThread.Start(5);
            }*/

            // 2

            /*for (int i = 1; i < 6; i++)
            {
                Reader reader = new Reader(i);
            }*/

            // 3

            /*TimerCallback timerCallback = new TimerCallback(Hello);
            int dueTime = 0;
            int period = 1000;
            Timer timer = new Timer(timerCallback, null, dueTime, period);*/
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
        private static void Hello(object obj)
        {
            Console.WriteLine("Hello world");
        }
    }

    class Reader
    {
        public static Semaphore _semaphore { get; private set; }
        private Thread _thread;
        private int _minThreadCount = 1;
        private int _maxThreadCount = 3;

        public Reader(int number)
        {
            _semaphore = new Semaphore(_minThreadCount, _maxThreadCount);
            _thread = new Thread(Read);
            _thread.Name = $"Читатель {number.ToString()}";
            _thread.Start();
        }

        private void Read()
        {
            int counter = 3;
            while (counter > 0)
            {
                _semaphore.WaitOne();

                Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");

                Console.WriteLine($"{Thread.CurrentThread.Name} читает");
                Thread.Sleep(1000);

                Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");

                _semaphore.Release();

                counter--;
                Thread.Sleep(1000);
            }
        }
    }
}
