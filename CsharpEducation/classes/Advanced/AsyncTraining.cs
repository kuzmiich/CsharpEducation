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
                "");


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
