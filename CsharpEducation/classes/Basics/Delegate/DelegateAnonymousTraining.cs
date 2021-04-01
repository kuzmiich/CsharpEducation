using System;

namespace Education.classes.Basics.Delegate
{
    class DelegateAnonymousTraining
    {
        delegate void MessageHandler(string mes);
        delegate long Operation(int x, int y);

        public static void OutTask()
        {
            Console.WriteLine("----Анонимные методы----\n" +
            "Описать конструкцию анонимного делегата.\n" +
            "Анонимный метод имеет доступ ко всем переменным определенным во внешнем коде\n" +
            "В анонимных методах нельзя использовать параметры по умолчанию\n");

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
        }
    }
}