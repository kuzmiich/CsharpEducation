using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Education.classes.Advanced.Multithreading
{
    class ClassTaskTraining
    {
        public static void OutTask()
        {
            Console.WriteLine(
                "---- Изучение класса Task ----\n" +
                "1.Класс обертка, который предназначен для упрощения работы с потоками.\n" +
                "Вложенная задача начнет выполняться только после выполнения внешней задачи.\n" +
                "Если необходимо, чтобы вложенная задача выполнялась с внешней нужно использовать значение TaskCreationOptions.AttachedToParent\n" +
                "2.Задачи продолжения. Задачи, которые позволяют определить задачи, которые выполняются после выполнения других задач.\n" +
                "Такие задачи мы можем вызвать после выполнения некоторой задачи, определить условия при котором будет выполняться эта задача,\n" +
                "Передать из предыдущей задачи в следующие некоторые данные.\n" +
                "3.Класса Parallel. Его методы и свойства\n" +
                "4.Отмена задач и параллельных операций. CancellationToken\n"
            );
            // 1
            Task t = new Task(() => { });
            Console.WriteLine($"Объект состояния задачи - {t.AsyncState}");
            Console.WriteLine($"Объект исключения, возникшего при выполнении задачи - {t.Exception}");
            Console.WriteLine($"Статус задачи - {t.Status}");
            Console.WriteLine($"Варианты создания - {t.CreationOptions}");

            // способы запуска потока
            
            Task task1 = new Task(() => Console.WriteLine("Hello Task 1!"));
            
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Hello Task 2!"));
            
            Task task3 = Task.Run(() => Console.WriteLine("Hello Task 3!"));

            Task task4 = new Task(Display);
            task4.Start();
            task4.Wait();

            // вложенные Task
            var outer = Task.Run(() =>
            {
                Console.WriteLine("Задача Outer началась...");
                var inner = Task.Factory.StartNew(() => 
                {
                    Console.WriteLine("Задача Inner началась...");
                    Thread.Sleep(1000);
                    Console.WriteLine("Задача task закончилась.");
                }, 
                TaskCreationOptions.AttachedToParent);// используется для синхронизации с внешним потоком
            });
            outer.Wait();

            // массив Task
            Task[] taskArray = new Task[]
            {
                new Task(() => Console.WriteLine("First task")),
                new Task(() => Console.WriteLine("Second task")),
                new Task(() => Console.WriteLine("Third task")),
            };
            foreach (var task in taskArray)
            {
                task.Start();
            }
            Task.WaitAll(taskArray); // ожидаем завершения задач в taskArray

            // Если нужно вернуть значение
            var taskBook = new Task<Book>(() =>
            {
                return new Book("Война и мир", "Л. Толстой", 1400);
            });
            taskBook.Start();

            Book book = taskBook.Result;  // ожидаем получение результата
            Console.WriteLine(book.ToString());
            Console.WriteLine($"Стоимость книги - {book.Cost}");

            // 2. Задачи продолжения
            Task task5 = new Task(() =>
            {
                Console.WriteLine($"Id задачи: {Task.CurrentId}");
            });
            Task task6 = task5.ContinueWith(Display);

            task5.Start();

            task6.Wait();

            Task<string> taskRain = new Task<string>(() =>
            {
                return "Начался дождь!\nИдет дождь...";
            });

            Task endTaskRain = taskRain.ContinueWith(rain =>
            {
                Console.WriteLine(rain.Result);
            });

            taskRain.Start();
            taskRain.Wait();

            endTaskRain.Wait();

            Console.WriteLine("Дождь закончился!");

            // class Parallel 
            Parallel.Invoke();// запускает некоторую паралельную операцию

            ParallelLoopResult parallelLoopResult = Parallel.For(1, 10, Factorial);
            Console.WriteLine(
                $"1.Завершилось ли полное выполнение цикла - {parallelLoopResult.IsCompleted}\n" +
                $"Индекс, на котором произошло прерывание работы - {parallelLoopResult.LowestBreakIteration}");

            var parallelLoopResult2 = Parallel.ForEach<int>(new List<int>() { 1, 3, 5, 9 }, Factorial);
            Console.WriteLine(
                $"2.Завершилось ли полное выполнение цикла - {parallelLoopResult2.IsCompleted}\n" +
                $"Индекс, на котором произошло прерывание работы - {parallelLoopResult2.LowestBreakIteration}");

            // 4. Отмена задач и параллельных операций. CancellationToken, ParallelOptions
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancelTokenSource.Token;
            
            Task cancellationTokenTask = new Task(() => {
                Console.WriteLine("Тестовая задача)");

                if (cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine("1.Операция прервана!");
                }

                Thread.Sleep(5000);
            });

            cancellationTokenTask.Start();

            cancelTokenSource.Cancel();

            cancellationTokenTask.Wait();

            try
            {
                Parallel.For(1, 3, new ParallelOptions { CancellationToken = cancellationToken }, Factorial);
            }
            catch(OperationCanceledException ex)
            {
                Console.WriteLine("2.Операция прервана!");
            }
            finally
            {
                cancelTokenSource.Dispose();
            }

            Console.WriteLine("Завершение метода Main");
        }

        private static void Display()
        {
            Console.WriteLine("Начало метода Display");

            Console.WriteLine("Конец метода Display");
        }
        private static void Display(Task t)
        {
            Console.WriteLine($"Id задачи: {Task.CurrentId}");
            Console.WriteLine($"Id предыдущей задачи: {t.Id}");
            Thread.Sleep(3000);
        }
        static long Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
        static void Factorial(int x, ParallelLoopState parallel)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
                if (i > 5)
                {
                    parallel.Break();
                }
            }
            Console.WriteLine(result);
        }
    }
    public enum BookImportance { Unknown, Recognize, Famous };

    public class Book
    {
        public Book(string title, string author, uint countPages)
        {
            Title = title;
            Author = author;
            _countPages = countPages;
        }
        
        public string Title { get; set; }
        public string Author { get; set; }
        public uint _countPages { get; private set; }

        public BookImportance _bookImportance { get; private set; }
        public double Cost
        {
            get
            {
                return _bookImportance switch
                {
                    BookImportance.Unknown => _countPages * 0.5,
                    BookImportance.Recognize => _countPages * 1.2,
                    BookImportance.Famous => _countPages * 1.8,
                    _ => throw new Exception("Unknown importance.")
                };
            }
        }

        public override string ToString()
        {
            return $"Название книги: {Title}, автор: {Author}";
        }
    }
}
