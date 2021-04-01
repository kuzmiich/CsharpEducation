using ClassLibrary.Base;
using ClassLibrary.Logic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Education.classes.Advanced.Linq
{
    class LinqTraining
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Изучение Linq ----\n" +
                "1.Конструкция from-in-where-select" +
                "2.groupBy - применяется, когда нужно сгрупировать по определенному ключу" +
                "3.Zip - соединить 2 коллекции\n" +
                "4.OrderBy - отсортировать по возрастанию\n" +
                "5.OrderByDescending - отсортировать по убыванию\n" +
                "6.Where - критерий выборки в коллеции\n" +
                "7.Except - удаляет одинаковые значения в некоторой коллекции\n" +
                "8.Skip - пропускает определенное количество элементов в коллекции\n" +
                "Take - извлекает определенное количество элементов из коллекции\n" +
                "9.TakeWhile - извлекает определенное количество элементов из коллекции с определенным условием\n" +
                "SkipWhile - пропускает определенное количество элементов в коллекции пока она удовлетворяет определенному условию\n" +
                "10.Join - используется для объединения коллекций, но принимает 4 параметра:\n" +
                "---второй список, который соединяем с текущим\n" +
                "---свойство объекта из текущего списка, по которому идет соединение\n" +
                "---свойство объекта из второго списка, по которому идет соединение\n" +
                "---новый объект, который получается в результате соединения\n" +
                "11.GroupJoin - кроме соединения последовательностей также выполняет и группировку\n" +
                "12.All(bool) - проверяет, соответствует ли все элементы некоторому условию\n" +
                "13.Any(bool) - хотя бы 1 элемент содержится в этой коллекции\n" +
                "14.Contains(bool) - проверяет, содержится ли некоторый элемент в коллекции\n" +
                "15.Атомарные операции - Count(), First(), Last(), Min(), Max(), Sum(), Aggregate - преобразует коллекцию по заданному условию\n" +
                "Они выполняются при определении запроса и их уже нельзя изменить изменением передаваемой коллекции.\n" +
                "Также для получения необходимого типа есть операции ToList, ToArray, ToDictionary(), ToHashSet, ToLookup\n" +
                "16.Использование делегатов(и анонимных делегатов) в качестве условия Linq запроса");

            // 1
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 11, 12 };
            var even = from i in list1
                       where i % 2 == 0 && i < 5
                       select i;

            Console.WriteLine($"Even numbers of list1 - {string.Join(" ", even)}");

            // 2
            List<Phone> phones = new()
            {
                new Phone {Name="Lumia 430", Company="Microsoft" },
                new Phone {Name="Mi 5", Company="Xiaomi" },
                new Phone {Name="LG G 3", Company="LG" },
                new Phone {Name="iPhone 5", Company="Apple" },
                new Phone {Name="Lumia 930", Company="Microsoft" },
                new Phone {Name="iPhone 6", Company="Apple" },
                new Phone {Name="Lumia 630", Company="Microsoft" },
                new Phone {Name="LG G 4", Company="LG" }
            };
            var groupPhones = phones.GroupBy(p => p.Company)
                .Select(g => new
                {
                    Name = g.Key,
                    Count = g.Count(),
                    Phones = g.Select(p => p)
                });
            foreach (var group in groupPhones)
            {
                Console.WriteLine($"{group.Name} - {group.Count}");
                foreach (Phone phone in group.Phones)
                {
                    Console.WriteLine($"{phone.Name} - {phone.Company}");
                }
            }
            // 3
            List<int> list2 = new List<int>() { 6, 8, 10, 22 };
            var allList = list1.Zip(list2);

            foreach (var el in allList)
            {
                Console.WriteLine(el.First);
                Console.WriteLine(el.Second);
            }

            int[] arr1 = { 1, 2, 3, 4, -5 };
            int[] arr2 = { 5, 4, 3, 2, 1 };
            Console.WriteLine($"Is arr1 = arr2? - {CollectionAnalysis.CheckArraySequence(arr1, arr2)}"); 

            // 4
            Console.WriteLine($"Ascending sort array - {string.Join(' ', CollectionAnalysis.AscendingSort(arr2))}");

            Console.WriteLine($"Ascending sort array - {string.Join(' ', CollectionAnalysis.DescendingSort(arr2))}");

            // 5
            int num = 5;
            Console.WriteLine($"Search value {num} in [{string.Join(' ', arr1)}]\n" +
                              $"The number was found? - {CollectionAnalysis.Search(num, 9, 8, 3, 4, 5)}");

            // 6
            Console.WriteLine($"Even numbers of list2 - {string.Join(" ", CollectionAnalysis.GetEvenNumbers(list2))}");

            // 7 
            var companies = new string[] { "Microsoft", "IBM", "Google", "Apple", "Amazone" };
            var filterCondition = new string[] { "IBM", "мат", "женщина", "логика"};

            Console.WriteLine($"Filter companies - {string.Join("/\\", CollectionAnalysis.ExceptFilter(companies, filterCondition))}");

            // 8
            Console.WriteLine(string.Join("-", arr1.Skip(arr1.Length / 2).Take(arr1.Length / 2)));

            // 9
            string[] teams = { "Бавария", "Беларусь", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };
            var sortTeams = teams.TakeWhile(t => t.StartsWith("Б"));
            Console.WriteLine(string.Join(' ', sortTeams));

            // 10
            var phones2 = phones.Take(phones.Count - 2);
            var joinList = phones.Join(phones2,
                x => x.Company,
                y => y.Name,
                (x, y) => new { Name = x.Name, Company = y.Company });

            foreach (var el in joinList)
            {
                Console.WriteLine($"{el.Name} - {el.Company}");
            }

            // 11
            var joinList2 = phones.GroupJoin(phones2,
                x => x.Name,
                y => y.Company,
                (x, y) => new { Name = x.Name, Company = x.Company, Phones = y.Select(p => p.Name)}
                );
            foreach (var el in joinList2)
            {
                Console.WriteLine($"{el.Name} - {el.Company}");
                foreach (var phone in el.Phones)
                {
                    Console.WriteLine(phone);
                }
            }
            // 12
            bool isPositive = arr1.All(x => x > 0);
            Console.WriteLine($"Is all values positive - {isPositive}");

            // 13
            bool isPositiveAtLeastOne = arr1.Any(x => x > 0);
            Console.WriteLine($"Is at least 1 number positive - {isPositiveAtLeastOne}");

            // 14
            int value = 1;
            bool isContain = arr1.Contains(value);
            Console.WriteLine($"Is contain {value} in array - {isContain}");

            // 15
            int[] numbers = { 1, 2, 3, 4, 5, 6, 8 };
            var aggregateNumbers = numbers.Aggregate((x, y) => x + y);
            Console.WriteLine($"Result value - {aggregateNumbers}");

            // 16
            var numbersMoreTen = numbers.Where(MoreThanTen);
            Console.WriteLine($"Is first element more 10 - {string.Join(' ', numbersMoreTen.FirstOrDefault())}");


            Func<int, bool> MoreThanTen2 = delegate (int i) { return i > 10; };
            var numbersMoreTen2 = numbers.Where(MoreThanTen2);
            Console.WriteLine($"Is first element more 10 - {string.Join(' ', numbersMoreTen2.FirstOrDefault())}");
        }
        private static bool MoreThanTen(int i)
        {
            return i > 10;
        }
    }
}
