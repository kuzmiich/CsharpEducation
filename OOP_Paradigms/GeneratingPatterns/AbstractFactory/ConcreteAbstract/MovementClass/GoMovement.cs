using OOP_Paradigms.GeneratingPatterns.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteAbstract.MovementClass
{
    class GoMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Идем");
        }
    }
}
