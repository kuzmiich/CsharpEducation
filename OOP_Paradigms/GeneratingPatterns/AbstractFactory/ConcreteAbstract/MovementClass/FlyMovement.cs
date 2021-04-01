using OOP_Paradigms.GeneratingPatterns.AbstractFactory.AbstractProduct;
using System;

namespace OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteAbstract.MovementClass
{
    class FlyMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Летим");
        }
    }
}
