using Education.interfaces;
using System;
using System.IO;

namespace Education.classes.Advanced.Multithreading
{
    class AsyncTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine();


            string path = @"./file.txt";
            ReadFile(path);
            ReadFileAsync(path);
        }
        public static void ReadFile(string path)
        {
            string textFromFile;
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
        public static async void ReadFileAsync(string path)
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
