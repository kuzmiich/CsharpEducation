using System;

namespace Education.classes.Basics
{
    class ConstAndReadonlyTraining
    {
        public static void OutTask()
        {
            const int a = 5;
            // readonly int b = 1; не работает
            Console.WriteLine("Изучил отличия константы времени выполнения(const) от константы времени компиляции(readonly)");
            Console.WriteLine("константа readonly может быть изменена только в конструкторе");
        }
    }
    readonly struct @Math
    {
        //public readonly int operation = 5; не работает
        public readonly int operation;
        public string A { get; }
        public @Math(string a, int b)
        {
            this.A = a;
            this.operation = b;
        }
    }
}
