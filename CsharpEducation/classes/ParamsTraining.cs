using Education.interfaces;
using System;

namespace Education.classes
{
    class ParamsTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("Работа с params!");
            Addition(1, 2, 3, 4, 5);

            Addition(new int[] { 1, 2, 3, 4 });

            Addition();
        }
        private static int Addition(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            return result;
        }
        // params указывается последним значением метода, может быть только 1
        private void Addition(int x, string mes, params int[] integers)
        { }
    }
}
