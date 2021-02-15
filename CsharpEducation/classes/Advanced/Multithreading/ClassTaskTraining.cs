using Education.interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Education.classes.Advanced.Multithreading
{
    class ClassTaskTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine(
                "---- Изучение класса Task ----\n" +
                "Класс обертка, который предназначен для упрощения работы с потоками.\n" +
                "Вложенная задача начнет выполняться только после выполнения внешней задачи.\n" +
                "Если необходимо, чтобы вложенная задача выполнялась с внешней нужно использовать значение TaskCreationOptions.AttachedToParent\n"
            );

            Task t = new Task(() => { });
            Console.WriteLine($"Объект состояния задачи - {t.AsyncState}");
            Console.WriteLine($"Объект исключения, возникшего при выполнении задачи - {t.Exception}");
            Console.WriteLine($"Статус задачи - {t.Status}");
            Console.WriteLine($"Варианты создания - {t.CreationOptions}");

            // способы запуска потока
            // 1
            Task task1 = new Task(() => Console.WriteLine("Hello Task 1!"));
            task1.Start();
            // 2
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Hello Task 2!"));
            // 3
            Task task3 = Task.Run(() => Console.WriteLine("Hello Task 3!"));

            // 4
            Task task4 = new Task(Display);
            task4.Start();
            task4.Wait();

            // вложенные Task
            var outer = Task.Run(() =>
            {
                Console.WriteLine("Outer task starting...");
                var inner = Task.Factory.StartNew(() => 
                {
                    Console.WriteLine("Inner task starting...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Inner task finished.");
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
            Task<Book> taskBook = new Task<Book>(() =>
            {
                return new Book("Война и мир", "Л. Толстой", 1400);
            });
            taskBook.Start();

            Book book = taskBook.Result;  // ожидаем получение результата
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.CurrentCost(DateTime.Now));
            Console.WriteLine("Завершение метода Main");
        }

        private static void Display()
        {
            Console.WriteLine("Начало метода Display");

            Console.WriteLine("Конец метода Display");
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
        public double CurrentCost(DateTime currentTime)
        {
            double resCost = 0;
            if (currentTime.Month == 12 || currentTime.Month > 0 && currentTime.Month <= 2)
            {
                resCost = Cost * 0.8;
            }
            else if (currentTime.Month > 2 && currentTime.Month <= 5)
            {
                resCost = Cost * 1;
            }
            else if (currentTime.Month > 5 && currentTime.Month <= 8)
            {
                resCost = Cost * 1.2;
            }
            else if (currentTime.Month > 9 && currentTime.Month <= 12)
            {
                resCost = Cost * 1;
            }
            else
            {
                throw new Exception("Wrong datetime.");
            }
            return resCost;
        }

        public override string ToString()
        {
            return $"Название книги: {Title}, автор: {Author}";
        }
    }
}
