using Education.interfaces;
using System;
using System.Collections;
using System.Linq;

namespace Education.classes.Basics
{
    class IComparableTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Сортировка объектов.Изучение интерфейса IComparable ----\n" +
            "Для сравнения объектов используется интерфейс IComparable\n" +
            "Для создания своей реализации сравнения объектов можно использовать интерфейс IComparer." +
            "Но данный интерфейс уже устарел\n" +
            "Для сравнения объектов используется IComparable с применением Linq\n");

            Apple[] apples = new Apple[] {
                new Apple(ApplesColor.Green, 1000),
                new Apple(ApplesColor.Red, 200),
                new Apple(ApplesColor.Yellow, 500),
            };
            var sortedApples = apples.OrderBy(apple => apple.Price);
            
            foreach (var apple in sortedApples)
            {
                Console.WriteLine($"{apple.Color}");
            }
        }
    }
    enum ApplesColor { Green, Red, Yellow };

    class Apple : IComparable<Apple>
    {
        public Apple(ApplesColor color, double weight)
        {
            Color = color;
            Weight = weight;
        }

        public ApplesColor Color { get; private set; }
        public double Weight { get; set; }
        public double Price {
            get => Color switch
            {
                ApplesColor.Green => 0.5 * Weight,
                ApplesColor.Red => 2 * Weight,
                ApplesColor.Yellow => 9.5 * Weight,
                _ => throw new IndexOutOfRangeException("Invalid value of apple color!"),
            };
        }
        public int CompareTo(Apple apple)
        {
            return Color.CompareTo(apple.Weight);
        }
    }
}
