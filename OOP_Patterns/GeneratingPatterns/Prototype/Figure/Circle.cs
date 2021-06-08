using OOP_Paradigms.GeneratingPatterns.Prototype.BasePrototype;
using System;

namespace OOP_Paradigms.GeneratingPatterns.Prototype.Figure
{
    class Circle : IFigure
    {
        private double _radius;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            _radius = radius;
        }

        public IFigure Clone()
        {
            return new Circle(_radius);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Круг радиусом {_radius}");
        }
    }
}
