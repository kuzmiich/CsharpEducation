using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteProduct.MovementClass
{
    class GoMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Идем");
        }
    }
}
