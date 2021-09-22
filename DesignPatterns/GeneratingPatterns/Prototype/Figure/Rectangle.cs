﻿using System;
using DesignPatterns.GeneratingPatterns.Prototype.BasePrototype;

namespace DesignPatterns.GeneratingPatterns.Prototype.Figure
{
    class Rectangle : IFigure
    {
        private readonly int _width;
        private readonly int _height;
        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public IFigure Clone()
        {
            return new Rectangle(_width, this._height);
        }
        public void GetInfo()
        {
            Console.WriteLine($"Прямоугольник длиной {_height} и шириной {_width}");
        }
    }
}
