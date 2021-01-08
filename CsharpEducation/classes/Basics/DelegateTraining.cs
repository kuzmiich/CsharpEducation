using Education.interfaces;
using System;

namespace Education.classes.Basics
{
    class DelegateTraining : ITask
    {
        delegate void Message();
        internal delegate T Operation<T, K>(K value);
        internal delegate int Operation(int first, int second);
        internal Operation operation { get; set; }

        public static void OutTask()
        {
            Console.WriteLine("----------Изучение делегата и работы с ним--------");
            Console.WriteLine("Делегат - это указатель на функцию");
            Console.WriteLine("Возращаемый и передаваемый типы должны соответствовать типам делегата");
            Console.WriteLine("В делегат можно добавлять несколько функций, а точнее добавлять в список вызова (invocation list)");
            Console.WriteLine("Для добавления применяется операция +=, удаление -=");
            Console.WriteLine("При удалении методов из делегата фактически будет создаватья новый делегат, который в списке вызова методов будет содержать на один метод меньше.");
            Console.WriteLine("Делегаты можно объеденять с помощью операции +");
            Console.WriteLine("Делегат можно вызывать с помощью метода Invoke");
            Console.WriteLine("При вызове пустого делегата будет вызвано исключение, поэтому лучше использовать условный null");
            Console.WriteLine("Если вызывать делегат с несколькими функциями, то будет вызвана последняя добавленная");
            Console.WriteLine("Делегаты могут быть параметрами методов");
            Console.WriteLine("Делегаты могут быть обобщенными");

            Message mes; // Создаем переменную делегата
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                mes = GoodMorning; // Присваиваем этой переменной адрес метода
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
            {
                mes = GoodAfternoon;
            }
            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 24)
            {
                mes = GoodEvening;
            }
            else
            {
                mes = GoodNight;
            }
            mes(); // Вызываем метод
            Console.WriteLine();

            // Делегат для функций с входными параметрами
            // Вызов делега с указателем на несколько функций
            Operation math;
            math = Plus;
            Console.WriteLine($"Plus 4 + 5 = {math(4, 5)}");
            math += Minus;
            Console.WriteLine($"Minus 7 - 5 = {math(5, 7)}");

            // Делегат с указателем на несколько функций
            Message mes2 = GoodNight;
            mes2 += GoodNight;
            mes += GoodMorning;
            mes();

            // удаление методов из делегатов
            mes2 -= GoodNight;
            mes();

            // объединение делегатов
            Message mes3 = mes + mes2;
            mes.Invoke();

            // Исключение при вызове пустого делегата
            Message mes4 = null;
            //mes4.Invoke();
            mes4?.Invoke();

            // Делегаты могу быть параметрами методов
            Message mes5 = GoodMorning;
            SayMessage(mes5);

            // Обобщения делегатов
            Operation<long, int> operation = Square;
            Console.WriteLine(operation?.Invoke(5));
        }
        static long Square(int x)
        {
            return x * x;
        }
        private static void SayMessage(Message message)
        {
            message?.Invoke();
        }
        private static int Minus(int first, int second)
        {
            return (first > second) ? first - second : second - first;
        }

        private static int Plus(int first, int second)
        {
            return first + second;
        }

        private static void GoodNight()
        {
            Console.WriteLine("Good Night");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
        private static void GoodAfternoon()
        {
            Console.WriteLine("Good afternoon");
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good morning");
        }
    }
}
