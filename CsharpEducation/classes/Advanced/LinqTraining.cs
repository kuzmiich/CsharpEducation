using Education.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Education.classes.Advanced
{
    class LinqTraining : ITask
    {
        public static void OutTask()
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 11, 12 };
            List<int> list2 = new List<int>() { 6 };
            var allList = list1.Zip(list2);
            foreach (var el in allList)
            {
                
                Console.WriteLine(el.First);
                Console.WriteLine(el.Second);
            }
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 5, 4, 3, 2, 1 };
            Console.WriteLine($"Is arr1 = arr2? - {CheckArraySequence(arr1, arr2)}"); 
            Console.WriteLine(string.Join(' ', Sort(arr1)));
            int num = 5;
            Console.WriteLine($"Search value {num} in [{string.Join(' ', arr1)}]\n" +
                              $"The number was found? - {Search(num, 9, 8, 3, 4, 5)}");
        }
        public static bool CheckArraySequence<T>(T[] arrFirst, T[] arrSecond) 
            => arrFirst.SequenceEqual(arrSecond);

        public static T[] Sort<T>(params T[] arr) 
            => (arr.OrderBy(x => x)).ToArray<T>();

        public static bool Search<T>(T index, params T[] arr) 
            => (arr.Any(x => object.Equals(x, index)));
    }
}
