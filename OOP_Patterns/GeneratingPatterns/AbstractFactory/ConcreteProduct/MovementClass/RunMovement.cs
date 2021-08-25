using System;
using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteProduct.MovementClass
{
    class RunMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}
