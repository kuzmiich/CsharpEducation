using Education.classes.Basics.Delegate;
using Education.interfaces;
using System;

namespace Education.classes.Basics
{
    class NullTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("Значение Null это задание указателя на пустоту");

            Console.WriteLine("null-объединения - ??");
            object x = null;
            object y = x ?? 100;

            Console.WriteLine("оператор условного null - ?.");
            Test test1 = new Test();
            test1.test2 = null;
            string value =  test1?.test2 ?? "Поле класса содержит null";
            Console.WriteLine(value);
        }
    }
    class Test
    {
        public string test2;
    }
    class Test2
    {
        public UnitTest test;
    }
}
