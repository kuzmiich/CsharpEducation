using System;
using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteAbstract.MovementClass
{
    class RunMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}
