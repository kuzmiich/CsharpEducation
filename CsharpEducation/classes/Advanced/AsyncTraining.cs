using Education.interfaces;
using System;
using System.IO;
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
