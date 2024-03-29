﻿using System;
using DesignPatterns.GeneratingPatterns.Prototype.BasePrototype;
using DesignPatterns.GeneratingPatterns.Prototype.Figure;

namespace DesignPatterns.GeneratingPatterns.Prototype
{
    class LaunchPrototype : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            Console.WriteLine(
                "Когда нужно использовать паттерн прототип:\n" +
                "Когда конкретный тип создаваемого объекта должен определяться динамически во время выполнения" +
                "Когда нежелательно создание отдельной иерархии классов фабрик для создания объектов - продуктов из параллельной\n" +
                "иерархии классов(как это делается, например, при использовании паттерна Абстрактная фабрика)" +
                "Когда клонирование объекта является более предпочтительным вариантом нежели его создание и инициализация\n" +
                "с помощью конструктора. Особенно когда известно, что объект может принимать небольшое ограниченное число возможных состояний."
            );

            IFigure figure = new Rectangle(30, 40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(30);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
        }
    }
}
