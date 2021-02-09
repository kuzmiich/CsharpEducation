using Education.interfaces;
using System;
using System.Threading;

namespace Education.classes.Advanced.Multithreading
{
    class MultithreadingBasicTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine(
                "---- class Thread ----\n" +
                "1.Перебор методов и свойств класса. Thread\n" +
                "2."
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
            thread.Start();// запускает новый поток
            thread.Join();// Блокирует вызывающий поток до тех пор, пока поток, представленный этим экземпляром, не завершится, или не будет продолжен
            const ApartmentState State = new ApartmentState();
            thread.SetApartmentState(State); // Задает модель "apartment" для потока до его запуска.
            thread.TrySetApartmentState(State);
            thread.Resume(); // продолжать вызывающий поток
            thread.Abort(); //Вызывает исключение ThreadAbortException в вызвавшем его потоке для того, чтобы начать процесс завершения потока.
            thread.Suspend(); // или приостанавливает поток, или ничего делает если он уже запущен
            thread.Interrupt(); // Прерывает поток, который находится в Системе.

            Thread.GetDomain(); //
            Thread.GetDomainID(); //
            Thread.GetCurrentProcessorId(); //
            const int COUNT = 1000; //
            Thread.Sleep(COUNT); //
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
            Thread.ResetAbort(); //
            Thread.Yield(); //
        }
    }
}
