using Education.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Education.classes.Advanced.Multithreading
{
    class AsyncTraining : ITask
    {
        public async static void OutTask()
        {
            Console.WriteLine(
                "------- Асинхронность -------\n" +
                "Разновидности асинхронных методов:\n" +
                "void, Task, Task<T>, ValueTask<T>\n" +
                "Асинхронность используется для задач, в которых важно чтобы главные поток не был занят,\n" +
                "а запросы пользователя были запущены и обработаны другим ресурсом(БД) параллельно основному потоку\n" +
                "Асинхронным считается только тот метод, у которого есть ключевое слово async и есть хотя бы 1 await в теле метода\n" +
                "1.Параллельный вызов асинхронных операций\n" +
                "2.Обработка ошибок в асинхронных методах\n" +
                "3.Отмена асинхронных операций\n" +
                "4.Асинхронные стримы\n");


            /*
             * Тестировал насколько быстрее работает считывание данных из файла в синхронном потоке
             * Для работы с файлами лучше использовать многопоточность))))
             * 
             */
            string path = @"./file.txt";

            ReadFile(path);

            await ReadFileAsync(path);

            // 1
            Console.WriteLine("-----1.Параллельный вызов асинхронных операций"); 
            /*AsyncTraining asyncTraining = new AsyncTraining();
            await asyncTraining.HelloAsync();*/

            // 2
            Console.WriteLine("-----2.Обработка ошибок в асинхронных методах\n" +
                "Для обработки исключений используется конструкция try-catch-finally\n" +
                "Для обработки нескольких исключений используется Task.WhenAll()\n" +
                "В C# 6.0 добавили возможность await в блоке finally\n");

            // 3
            Console.WriteLine("-----3.Отмена асинхронных операций\n" +
                "Для отмены асинхронных операций также используются классы CancellationToken и CancellationTokenSource.\n");

            /*CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            await FactorialAsync(6, token);

            cts.Cancel();*/
            // 4
            Console.WriteLine("-----4.Асинхронные стримы\n" +
                "В версии C# 8.0 в C# были добавлены асинхронные стримы\n" +
                "Для реализации используется yield и интерфейс IAsyncEnumberable<T> содержащийся в System.Collections.Generic\n");

            /*await foreach (var number in GetNumbersAsync())
            {
                Console.WriteLine(number);
            }*/
        }
        public static async IAsyncEnumerable<int> GetNumbersAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                // Thread.Sleep(200);
                yield return i;
            }    
            
        }

        public static async Task FactorialAsync(int n, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                return;
            }
            await Task.Run(() => Factorial(n, token));
        }

        private static void Factorial(int n, CancellationToken token)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция прервана токеном");
                    return;
                }
                result *= i;
                Console.WriteLine($"Факториал числа {i} равен {result}");
                Thread.Sleep(1000);
            }
        }

        public virtual async Task HelloAsync()
        {
            Task t1 = Task.Run(() => Hello());
            Task t2 = Task.Run(() => Hello());
            Task t3 = Task.Run(() => Hello());
            
            await Task.WhenAll(new[] { t1, t2, t3 });
        }

        private static void Hello()
        {
            Console.WriteLine("Hello world!");
        }

        public static void ReadFile(string path)
        {
            DateTime time = DateTime.Now;
            string buf = string.Empty;
            using (StreamReader fin = new StreamReader(path))
            {
                if (fin == null)
                {
                    throw new Exception("File not exist.");
                }
                buf = fin.ReadToEnd();
            }
            Console.WriteLine($"Синхронное считывание - {DateTime.Now - time}");

        }
        public static async Task ReadFileAsync(string path)
        {
            DateTime time = DateTime.Now;
            string buf = string.Empty;
            using (StreamReader fin = new StreamReader(path))
            {
                if (fin == null)
                {
                    throw new Exception("File not exist.");
                }
                buf = await fin.ReadToEndAsync();
            }
            Console.WriteLine($"Асинхронное считывание - {DateTime.Now - time}");
        }
    }
}
