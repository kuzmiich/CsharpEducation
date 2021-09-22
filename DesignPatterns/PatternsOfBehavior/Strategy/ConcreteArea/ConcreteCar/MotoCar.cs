using System;
using DesignPatterns.PatternsOfBehavior.Strategy.CarState;

namespace DesignPatterns.PatternsOfBehavior.Strategy.ConcreteArea.ConcreteCar
{
    class MotoCar : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Moto car move");
        }
    }
}
