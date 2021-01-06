using Education.interfaces;
using System;
using static ClassLibrary.Sorting;

namespace Education.classes
{
    class GeneralizationTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("Изучение всего что связано с обобщениями");
            Console.WriteLine("Использование нескольких универсальных параметров");
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = new int[] { 4, 5, 6 };
            Swap(ref arr1, ref arr2);
            Console.WriteLine(string.Join(' ', arr1));
            Console.WriteLine(string.Join(' ', arr2));
        }
    }
}
