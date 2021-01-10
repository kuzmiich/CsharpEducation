using Education.interfaces;
using System;

namespace Education.classes.Basics
{
    class DelegateEventTraining : ITask
    {
        delegate void MessageHandler(string mes);
        delegate long Operation(int x, int y);

        public static void OutTask()
        {
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
