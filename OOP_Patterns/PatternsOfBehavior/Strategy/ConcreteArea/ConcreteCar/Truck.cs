using System;
using DesignPatterns.PatternsOfBehavior.Strategy.CarState;

namespace DesignPatterns.PatternsOfBehavior.Strategy.ConcreteArea.ConcreteCar
{
    class Truck : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Truck move");
        }
    }
}
