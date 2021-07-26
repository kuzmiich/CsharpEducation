using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteAbstract.MovementClass
{
    class GoMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Идем");
        }
    }
}
