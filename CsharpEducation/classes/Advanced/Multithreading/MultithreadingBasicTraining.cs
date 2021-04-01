using System;
using System.Threading;
using System.Threading.Tasks;

namespace Education.classes.Advanced.Multithreading
{
    class MultithreadingBasicTraining
    {
        private static AutoResetEvent _waitHandler = new AutoResetEvent(true);
        private static object _syncLocker = new object();

        public static void OutTask()
        {
            Console.WriteLine(
                "---- class Thread ----\n" +
                "1.Перебор методов и свойств класса. Thread\n" +
                "2.Для создания потока без параметров 'void Name(){}' используется 'new ThreadStart(имя метода)'\n" +
                "Для создания потоков с передачей параметра 'void Name(object name){}' используется 'new ParameterizedThreadStart(имя метода)'\n" +
                "3.Синхронизация потоков:\n" +
                "Синхронизация с использованием lock(object) {}\n" +
                "_______________________________Мониторы\n" +
                "_______________________________Класс AutoResetEvent\n" +
                ""
            );

            Thread thread = Thread.CurrentThread;
            // свойства
            Console.WriteLine($"Имя потока: {thread.Name}");
            Console.WriteLine($"Запущен ли поток: {thread.IsAlive}");
            Console.WriteLine($"Приоритет потока: {thread.Priority}");
            Console.WriteLine($"Статус потока: {thread.ThreadState}");
            Console.WriteLine($"Является ли поток фоновым: {thread.IsBackground}");
            Console.WriteLine($"Текущий запущенный поток: {thread.CurrentCulture}");
            Console.WriteLine($"Задает текущее состояние: {thread.CurrentUICulture}");
            Console.WriteLine($"Принадлежит ли поток управляемому потоку: {thread.IsThreadPoolThread}");
            Console.WriteLine($"Id управляемого потока: {thread.ManagedThreadId}");
            Console.WriteLine($"Домен приложения: {Thread.GetDomain().FriendlyName}");

            // методы
            //thread.Start(); // запускает новый поток
            //thread.Join(); // Блокирует вызывающий поток до тех пор, пока поток, представленный этим экземпляром, не завершится, или не будет продолжен
            //const ApartmentState State = new ApartmentState();
            //thread.SetApartmentState(State); // Задает модель "apartment" для потока до его запуска.
            //thread.TrySetApartmentState(State);
            //thread.Resume(); // продолжать вызывающий поток
            //thread.Abort(); //  уведомляет среду CLR о том, что надо прекратить поток, однако прекращение работы потока происходит не сразу, а только тогда, когда это становится возможно.
            //thread.Suspend(); // или приостанавливает поток, или ничего делает если он уже запущен
            //thread.Interrupt(); // Прерывает поток, который находится в Системе на некоторое время

            Thread.GetDomain(); // возвращает ссылку на домен приложения
            Thread.GetDomainID(); // возвращает id домена приложения, в котором выполняется текущий поток
            Thread.GetCurrentProcessorId(); //
            const int COUNT = 1000; //
            Thread.Sleep(COUNT); // останавливает поток на определенное количество миллисекунд
            Thread.SpinWait(COUNT); // 
            Thread.AllocateDataSlot(); //
            Thread.BeginCriticalRegion(); //
            Thread.EndCriticalRegion(); //
            Thread.BeginThreadAffinity(); //
            Thread.EndThreadAffinity(); //
            Thread.MemoryBarrier(); //

            byte[] arr = new byte[] { 1, 2, 3, 4, 5 };
            ref byte pArr = ref arr[0];
            Thread.VolatileRead(ref pArr); // 
            Thread.VolatileWrite(ref pArr, 1); //

            var slot = Thread.GetNamedDataSlot("Random");
            Thread.AllocateNamedDataSlot("Name"); //
            Thread.FreeNamedDataSlot("Name"); ; //
            Thread.GetData(slot); //
            Thread.SetData(slot, new object()); //
            //Thread.ResetAbort(); //
            Thread.Yield(); //

            // Работа с потоками. Создание разных типов методов
            Thread thread1 = new Thread(new ThreadStart(Hello));
            thread1.Start(); // запускаем поток
            Thread thread2 = new Thread(new ParameterizedThreadStart(Increment));
            thread2.Start(10);
            Random rand = new Random();

            Console.WriteLine("Вывод для новых потоков:");
            // 1
            for (int i = 0; i < 3; i++)
            {
                Thread myThread1 = new Thread(Factorial);
                myThread1.Name = "Поток " + i.ToString();
                myThread1.Start(i);
            }
            // 2
            for (int i = 0; i < 3; i++)
            {
                Thread myThread2 = new Thread(Factorial2);
                myThread2.Name = "Поток " + i.ToString();
                myThread2.Start(i);
            }
            // 3
            for (int i = 0; i < 3; i++)
            {
                Thread myThread3 = new Thread(Factorial2);
                myThread3.Name = "Поток " + i.ToString();
                myThread3.Start(i);
            }
            Task.WaitAll();
            AutoResetEvent.WaitAll(new WaitHandle[] { _waitHandler });
        }

        private static void Increment(object value)
        {
            Console.WriteLine((int)value + 1);
        }

        private static void Hello()
        {
            Console.WriteLine("Hello world");
        }

        public static void Factorial(object num)
        {
            lock (_syncLocker)
            {
                int x = 1;
                for (int i = 1; i < (int)num + 1; i++)
                {
                    x = x * i;
                    Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                    Thread.Sleep(100);
                }
            }
        }
        public static void Factorial2(object num)
        {
            bool acquiredLock = false;
            try
            {
                Monitor.Enter(_syncLocker, ref acquiredLock);

                int x = 1;
                for (int i = 1; i < (int)num + 1; i++)
                {
                    x = x * i;
                    Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                    Thread.Sleep(100);
                }
            }
            finally
            {
                if (acquiredLock)
                {
                    Monitor.Exit(_syncLocker);
                }
            }
        }
        public static void Factorial3(object num)
        {

            _waitHandler.WaitOne();
            int x = 1;
            for (int i = 1; i < (int)num + 1; i++)
            {
                x = x * i;
                Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                Thread.Sleep(100);
            }
            _waitHandler.Set();
        }
    }
}
