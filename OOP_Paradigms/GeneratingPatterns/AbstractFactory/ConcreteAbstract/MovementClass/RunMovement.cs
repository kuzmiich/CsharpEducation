using OOP_Paradigms.GeneratingPatterns.AbstractFactory.AbstractProduct;
using System;

namespace OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteAbstract.MovementClass
{
    class RunMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}
