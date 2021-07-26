using System;
using DesignPatterns.PatternsOfBehavior.Strategy.BaseCar;
using DesignPatterns.PatternsOfBehavior.Strategy.ConcreteArea.ConcreteCar;

namespace DesignPatterns.PatternsOfBehavior.Strategy
{
    class LaunchStrategy : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            Console.WriteLine("В каких случаях используется паттерн Strategy:\n" +
                "-Когда система состоит из множества классов, объекты которых должны находиться в согласованных состояниях\n" +
                "-Когда общая схема взаимодействия объектов предполагает две стороны: одна рассылает сообщения и является главным,\n" +
                "другая получает сообщения и реагирует на них.Отделение логики обеих сторон позволяет их рассматривать независимо\n" +
                "и использовать отдельно друга от друга." +
                "-Когда существует один объект, рассылающий сообщения, и множество подписчиков, которые получают сообщения.\n" +
                "При этом точное число подписчиков заранее неизвестно и процессе работы программы может изменяться.");

            var auto = new Car(4, "Volvo", new MotoCar());
            auto.Move();
            auto.Movable = new Truck();
            auto.Move();
        }
    }
}
