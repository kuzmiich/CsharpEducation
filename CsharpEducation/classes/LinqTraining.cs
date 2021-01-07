using Education.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Education.classes
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
        }
    }
}
