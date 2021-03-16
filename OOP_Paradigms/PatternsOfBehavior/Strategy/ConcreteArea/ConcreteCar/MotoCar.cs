using OOP_Paradigms.PatternsOfBehavior.Strategy.CarState;
using System;

namespace OOP_Paradigms.PatternsOfBehavior.Strategy.ConcreteArea.ConcreteCar
{
    class MotoCar : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Moto car move");
        }
    }
}
