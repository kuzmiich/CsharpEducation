using Education.interfaces;
using System;

namespace Education.classes.Basics
{
    class DelegateAnonymousTraining : ITask
    {
        delegate void MessageHandler(string mes);
        delegate long Operation(int x, int y);

        public static void OutTask()
        {
            Console.WriteLine("----Анонимные методы----");
            Console.WriteLine("Описать конструкцию анонимного делегата.");
            Console.WriteLine("Анонимный метод имеет доступ ко всем переменным определенным во внешнем коде");
            Console.WriteLine("В анонимных методах нельзя использовать параметры по умолчанию");

            MessageHandler messageHandler = delegate (string mes)
            {
                Console.WriteLine(mes);
            };
            messageHandler("Greetings from DotaII");
            //
            int z = 5;
            Operation sum = delegate (int x, int y)
            {
                return x + y + z;
            };
            sum?.Invoke(1, 2);
            //
        }
    }
}