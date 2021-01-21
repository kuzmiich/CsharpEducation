using Education.interfaces;
using System;

namespace Education.classes.Basics
{
    interface IMovable
    {
        public const int minSpeed = 0;     // минимальная скорость
        private static int maxSpeed = 60;   // максимальная скорость
        protected internal string Name { get; set; }    // название
        public delegate void MoveHandler(string message);  // определение делегата для события
        public event MoveHandler MoveEvent;    // событие движения
        abstract void Move();
        /* class A
        {
            class B
            {
                
            }
        }
        struct C
        {
            struct D
            {

            }
        }*/
    }
    interface IFoo
    {
        abstract void Execute();
    }
    interface IBar
    {
        abstract void Execute();
    }
    class Car : IMovable
    {
        public string CarType { get; set; }
        protected int CarYear { get; set; }
        public string NameMove { get; private set; }
        public Car(string carType, int carYear, string nameMove)
        {
            CarType = carType;
            CarYear = carYear;
            NameMove = nameMove;

        }
        string IMovable.Name
        {
            get => NameMove;
            set => NameMove = value;
        }
        public event IMovable.MoveHandler MoveEvent;
        event IMovable.MoveHandler IMovable.MoveEvent
        {
            add
            {
                MoveEvent += value;
            }
            remove
            {
                MoveEvent -= value;
            }
        }
        public void Move()
        {
            Console.WriteLine($"Тип движения: { NameMove }");
        }
        public override string ToString()
        {
            return $"Car type - {CarType}, Car year - {CarYear}, Name of move - {NameMove}";
        }
    }
    class InterfaceBasicTraining : ITask, IFoo, IBar
    {
        public static void OutTask() 
        {
            Console.WriteLine("---- Основные сведения об интерфейсах ----");
            Console.WriteLine("Интерфейс представляет ссылочный тип, используется для определения \nнекоторого функционала - набор методов и свойств и реализации.");
            Console.WriteLine("После данный функционал реализуют классы или структуры, которые применяют применяют данные интерфейса.");
            Console.WriteLine("По умолчанию интерфейсы имеют модификатор доступа internal.\nИнтерфейсы не могут иметь модификатора доступа abstract");
            Console.WriteLine("В интерфейсах константы и статические классы имеют модификатор доступа public");
            Console.WriteLine("В класс можно добавлять неограниченное количество интерфейсов");
            Console.WriteLine("1.Интерфейсы и преобразование типов");
            Console.WriteLine("2.");

            // Все объекты Client являются объектами IAccount 
            IMovable movable = new Car("Porsh", 10, "drive");
            Console.WriteLine(movable.ToString());
            movable.Move();

            Car car = (Car)movable;
            string moveName = ((Car)movable).NameMove;
            Console.WriteLine(moveName);
        }
        public void Execute()
        {
            Console.WriteLine("Tester Executes");
        }
    }
}
