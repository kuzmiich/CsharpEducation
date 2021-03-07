using OOP_Paradigms.GeneratingPatterns.Prototype.BasePrototype;
using System;

namespace OOP_Paradigms.GeneratingPatterns.Prototype.Figure
{
    class Rectangle : IFigure
    {
        private int _width;
        private int _height;
        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public IFigure Clone()
        {
            return new Rectangle(this._width, this._height);
        }
        public void GetInfo()
        {
            Console.WriteLine($"Прямоугольник длиной {_height} и шириной {_width}");
        }
    }
}
