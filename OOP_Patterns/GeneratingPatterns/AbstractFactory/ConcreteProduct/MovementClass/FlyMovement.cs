using System;
using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteProduct.MovementClass
{
    class FlyMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Летим");
        }
    }
}
