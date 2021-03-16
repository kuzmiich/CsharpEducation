using OOP_Paradigms.PatternsOfBehavior.Strategy.CarState;
using System;

namespace OOP_Paradigms.PatternsOfBehavior.Strategy.ConcreteArea.ConcreteCar
{
    class Truck : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Truck move");
        }
    }
}
