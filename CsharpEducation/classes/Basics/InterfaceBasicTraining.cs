using Education.interfaces;
using System;

namespace Education.classes.Basics
{
    public interface IMovable
    {
        public const int minSpeed = 0;     // минимальная скорость
        private static int maxSpeed = 60;   // максимальная скорость
        protected internal string Name { get; set; }    // название
        public delegate void MoveHandler(string message);  // определение делегата для события
        public event MoveHandler MoveEvent;    // событие движения
        abstract void Move();
    }
    class InterfaceBasicTraining : ITask, IMovable
    {
        string IMovable.Name { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public event IMovable.MoveHandler MoveEvent;

        event IMovable.MoveHandler IMovable.MoveEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public static void OutTask()
        {
            Console.WriteLine("---- Основные сведения об интерфейсах ----");
            Console.WriteLine("Интерфейс представляет ссылочный тип, используется для определения \nнекоторого функционала - набор методов и свойств и реализации.");
            Console.WriteLine("После данный функционал реализуют классы или структуры, которые применяют применяют данные интерфейса.");
            Console.WriteLine("По умолчанию интерфейсы имеют модификатор доступа internal.\nИнтерфейсы не могут иметь модификатора доступа abstract");
            Console.WriteLine("В класс можно добавлять неограниченное количество интерфейсов");
            Console.WriteLine("1.Интерфейсы и преобразование типов");
            Console.WriteLine("2.");
        }
        static void Move()
        {
            Console.WriteLine(1);
        }
        void IMovable.Move()
        {
            throw new NotImplementedException();
        }
    }
}
