using Education.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.classes.Advanced
{
    class ExtensionMethodsTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Методы расширения----\n" +
                "Для расширения методов класса нужно создать статический класс,\n" +
                "в нем создать метод (this тип_который_расширяем переменная, параметры)"
            );

            string str = "Привет мир";
            char c = 'и';
            int count = str.CharCount(c);
            Console.WriteLine($"Char count - {count}");

            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine($"Length - {arr.MyLength()}");
        }
    }
    public static class StringExtends
    {
        /// <summary>
        /// Defines number of characters in a string
        /// </summary>
        /// <param name="str"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int CharCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (c == str[i])
                {
                    counter++;
                }
            }
            return counter;
        }
        /// <summary>
        /// Type conversion method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="text"></param>
        /// <returns></returns>
        public static T To<T>(this string text)
        {
            try
            {
                return (T)Convert.ChangeType(text, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }
    }
    public static class IntExtends
    {
        public static int MyLength(this int[] value)
        {
            return value.Length;
        }
    }
}
