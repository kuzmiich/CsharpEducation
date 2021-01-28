﻿using Education.interfaces;
using System;

namespace Education.classes.Basics
{
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
            Console.WriteLine("2.Явная реализация интерфейсов");
            Console.WriteLine("Если мы используем модификатор доступа не public для полей и методов, то необходимо использовать явную реализацию.");
            Console.WriteLine("Если мы явно реализуем поле или метод интерфейса, то по умолчанию он является закрытым.\nК нему можно обратиться только через интерфейс, или явному приведению к интерфейсу");
            Console.WriteLine("Или если нам нужно переопределить метод в базовом классе.");
            Console.WriteLine("3.Реализация интерфейсов в базовых и прроизводных классов");
            Console.WriteLine("Задача, создать метод в интерфейсе, в унаследуемом классе переопределить метод на abstract или virtual,\n а после реализовать в классе, который унаследует предыдущий");
            // Интерфейсы и преобразование типов
            IMovable movable = new Car("Porsh", 10, "drive");
            Console.WriteLine(movable.ToString());
            movable.Move();

            Car car = (Car)movable;
            string moveName = ((Car)movable).TypeMove;
            Console.WriteLine(moveName);
             
            // Использование интерфейсов с методами класса
            BaseAction action1 = new HeroAction();
            action1.Move();            // Move in BaseAction

            IAction action2 = new HeroAction();
            action2.Move();             // Move in BaseAction

            // создание события с помощью интерфейса
            IMovable mov = new Car("Porsh", 10, "drive");
            // подписываемся на событие
            mov.MoveEvent += (string value) => Console.WriteLine(value);
            mov.Move();

            // Создание и переопределение метода или поля интерфейса в унаследованном классе.
            ICoin icoin = new Wallet(10, "USD", "25 cents");
            icoin.ToString();             // Move in IAction

            Wallet wallet = new Wallet(10, "USD", "25 cents");
            wallet.Info();             // Move in HeroAction

            // Использование обобщейний для интерфейсов
            ClassLibrary.Client client1 = new ClassLibrary.Client("Tom", 300);
            ClassLibrary.Client client2 = new ClassLibrary.Client("Олег", 200);
            var transaction = new ClassLibrary.NewTransaction<ClassLibrary.Client>();
            transaction.Operate(client1, client2, 150);

            IProductTest<int> user1 = new ProductTest<int>(55);
            Console.WriteLine(user1._id);
            IProductTest<string> user2 = new ProductTest<string>("12345");
            Console.WriteLine(user2._id);
        }
        public void Execute()
        {
            Console.WriteLine("Tester Executes");
        }
    }
    interface IProductTest<T>
    {
        T _id { get; }
    }
    class ProductTest<T> : IProductTest<T>
    {
        public ProductTest(T id)
        {
            _id = id;
        }
        public T _id { get; private set; }
    }
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
        public string CarType { get; private set; }
        protected int CarYear { get; private set; }
        public string TypeMove { get; private set; }
        public Car(string carType, int carYear, string nameMove)
        {
            CarType = carType;
            CarYear = carYear;
            TypeMove = nameMove;

        }
        string IMovable.Name
        {
            get => TypeMove;
            set => TypeMove = value;
        }
        IMovable.MoveHandler _moveEvent;
        event IMovable.MoveHandler IMovable.MoveEvent
        {
            add => _moveEvent += value;
            remove => _moveEvent -= value;
        }

        public void Move()
        {
            Console.WriteLine($"Тип движения: { TypeMove }");
        }
        public override string ToString()
        {
            return $"Car type - {CarType}, Car year - {CarYear}, Name of move - {TypeMove}";
        }
    }
    interface IAction
    {
        void Move();
    }
    class BaseAction : IAction
    {
        public void Move()
        {
            Console.WriteLine("Move in BaseAction");
        }
    }
    class HeroAction : BaseAction
    {
        public new void Move()
        {
            Console.WriteLine("Move in HeroAction");
        }
    }
    interface ICoin
    {
        string Nominal { get; set; }
        void Info();
    }
    abstract class Coin : ICoin
    {
        public abstract string CurrencyType { get; set; }
        public abstract string Nominal { get; set; }

        protected Coin()
        {
        }

        public override string ToString()
        {
            return $"Currency type - {CurrencyType}, Nominal - {Nominal}";
        }
        public abstract void Info();
    }
    class Wallet : Coin
    {
        public static int Count { get; set; }
        public override string Nominal { get; set; }
        public override string CurrencyType { get; set; }
        public Wallet(int count, string currencyType, string nominal)
        {
            Count = count;
            CurrencyType = currencyType;
            Nominal = nominal;
        }

        public override void Info()
        {
            Console.WriteLine($"{base.ToString()}, Count - {Count}");
        }
    }
}
