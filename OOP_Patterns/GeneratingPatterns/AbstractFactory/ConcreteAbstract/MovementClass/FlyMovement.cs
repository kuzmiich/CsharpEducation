using System;
using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteAbstract.MovementClass
{
    class FlyMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Летим");
        }
    }
}
