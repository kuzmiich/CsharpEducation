using ConsoleApp1.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.classes
{
    class ParamsTraining : ITask
    {
        
        public static void OutTask()
        {
            Console.WriteLine(Addition(1, 2, 3, 4, 5));

            Console.WriteLine(Addition(new int[] { 1, 2, 3, 4 }));

            Console.WriteLine(Addition());
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
