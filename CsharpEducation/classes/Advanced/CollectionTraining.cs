using Education.interfaces;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace Education.classes.Advanced
{
    class CollectionTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Изучение коллекций ----\n" +
            "1.Описание библиотек, которые содержат коллекции.\n" +
            "2.Класс ObservableCollection(Отличается от обычного списка тем, что имеет\n" +
            "методы а также событие для оповещении об изменении объекта)\n" +
            "3.Реализация IEnumerable и IEnumerator\n" +
            "4.Итераторы и оператор yield");
            // 1.Collections:

            // System.Collections
            ArrayList arrayList = new ArrayList();
            Hashtable hashtable = new Hashtable();
            Queue queue = new Queue();
            Stack stack = new Stack();

            // System.Collections.Generic
            Dictionary<int, string> dict = new Dictionary<int, string>();
            List<int> list = new List<int>();
            SortedList<int, string> sortedList = new SortedList<int, string>();
            Stack<int> stack2 = new Stack<int>();
            Queue<int> queue2 = new Queue<int>();

            // System.Collections.Concurrent
            BlockingCollection<int> blockingCollection = new BlockingCollection<int>();
            ConcurrentBag<int> cBag = new ConcurrentBag<int>();
            ConcurrentDictionary<int, string> cDict = new ConcurrentDictionary<int, string>();
            ConcurrentQueue<int> cQueue = new ConcurrentQueue<int>();
            ConcurrentStack<int> cStack = new ConcurrentStack<int>();

            // Create a load-balancing partitioner. Or specify false for static partitioning.
            var nums = Enumerable.Range(0, 100000000).ToArray();
            Partitioner<int> partitioner2 = Partitioner.Create<int>(nums, true);
            OrderablePartitioner<Tuple<int, int>> customPartitioner = Partitioner.Create(0, nums.Length);
            
            // 2.ObservableCollection, library : System.Collections.ObjectModel, System.Collections.Specialized
            ObservableCollection<int> obj = new ObservableCollection<int>();
            obj.Count();
            obj.CollectionChanged += Obj_CollectionChanged;
            
            // 3.Реализация IEnumerable и IEnumerator
            Week week = new Week();
            foreach (var w in week)
            {
                Console.WriteLine(w.ToString());
            }

            Week2 week2 = new Week2();
            Console.WriteLine();
            while (week2.MoveNext())
            {
                Console.WriteLine(week2.Current);
            }
            week2.Reset();

            //4. Оператор yield
            Library library = new Library();
            foreach (var lib in library.GetBooks(5))
            {
                Console.WriteLine(lib.ToString());
            }    
        }
        
        private static void Obj_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    User newUser = e.NewItems[0] as User;
                    Console.WriteLine($"Добавлен новый объект: {newUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    User oldUser = e.OldItems[0] as User;
                    Console.WriteLine($"Удален объект: {oldUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    User replacedUser = e.OldItems[0] as User;
                    User replacingUser = e.NewItems[0] as User;
                    Console.WriteLine($"Объект {replacedUser.Name} заменен объектом {replacingUser.Name}");
                    break;
            }
        }
    }
    class Week
    {
        string[] days = {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };
        /// <summary>
        /// Метод для использования класса в цикле foreach
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return days.GetEnumerator();
        }
    }
    class Week2 : WeekEnumerator
    {
    }
    abstract class WeekEnumerator : IEnumerable, IEnumerator
    {
        public string[] days {
            get
            {
                return new string[]
                {
                    "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday"
                };
            }
        }
        int position = -1;
        public string Current
        {
            get
            {
                if (position >= days.Length)
                {
                    throw new InvalidOperationException();
                }
                else if (position == -1 && days.Length != 0)
                {
                    return days[days.Length - 1];
                }
                return days[position];
            }
        }

        object IEnumerator.Current => days[position];

        public bool MoveNext()
        {
            if (position < days.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return days.GetEnumerator();
        }
    }
    class User : IDisposable
    {
        public string Name { get; set; }

        public void Dispose()
        {
            Console.WriteLine("Disposed");
        }
    }
    class Book
    {
        public Book(string name)
        {
            this.Name = name;
        }
        public string Name { get; init; }
        public override string ToString()
        {
            return $"Name - {Name}";
        }
    }
    class Library : IEnumerable
    {
        private Book[] books;

        public Library()
        {
            books = new Book[] { 
                new Book("Отцы и дети"),
                new Book("Война и мир"),
                new Book("Евгений Онегин")
            };
        }

        public int Length
        {
            get { return books.Length; }
        }

        public IEnumerable GetBooks(int max)
        {
            for (int i = 0; i < max; i++)
            {
                if (i == books.Length)
                {
                    yield break;
                }
                else
                {
                    yield return books[i];
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return books.GetEnumerator();
        }
    }
}
