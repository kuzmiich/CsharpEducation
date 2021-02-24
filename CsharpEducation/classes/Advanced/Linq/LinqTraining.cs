using Education.classes.Advanced.Tools;
using Education.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Education.classes.Advanced.Linq
{
    class LinqTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Изучение Linq ----\n" +
                "Zip - соединить 2 коллекции\n" +
                "OrderBy - отсортировать по возрастанию\n" +
                "OrderByDescending - отсортировать по убыванию\n" +
                "Where - критерий выборки\n" +
                "Except - удаляет одинаковые значения в некоторой коллекции\n");

            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 11, 12 };
            List<int> list2 = new List<int>() { 6, 8, 10, 22 };
            var allList = list1.Zip(list2);

            foreach (var el in allList)
            {
                Console.WriteLine(el.First);
                Console.WriteLine(el.Second);
            }

            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 5, 4, 3, 2, 1 };
            Console.WriteLine($"Is arr1 = arr2? - {CollectionAnalysis.CheckArraySequence(arr1, arr2)}"); 

            Console.WriteLine($"Ascending sort array - {string.Join(' ', CollectionAnalysis.AscendingSort(arr2))}");

            Console.WriteLine($"Ascending sort array - {string.Join(' ', CollectionAnalysis.DescendingSort(arr2))}");

            int num = 5;
            Console.WriteLine($"Search value {num} in [{string.Join(' ', arr1)}]\n" +
                              $"The number was found? - {CollectionAnalysis.Search(num, 9, 8, 3, 4, 5)}");


            var even = from i in list1
                        where i % 2 == 0 && i > 10
                        select i;

            Console.WriteLine($"Even numbers of list1 - {string.Join(" ", even)}");

            Console.WriteLine($"Even numbers of list2 - {string.Join(" ", CollectionAnalysis.GetEvenNumbers(list2))}");

            var companies = new string[] { "Microsoft", "IBM", "Google", "Apple", "Amazone" };
            var filterCondition = new string[] { "IBM", "мат", "женщина", "логика"};

            Console.WriteLine($"Filter companies - {string.Join("/\\", CollectionAnalysis.ExceptFilter(companies, filterCondition))}");
        }
    }
}
