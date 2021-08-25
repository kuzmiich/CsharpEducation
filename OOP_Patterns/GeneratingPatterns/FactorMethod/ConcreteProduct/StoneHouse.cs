using System;
using DesignPatterns.GeneratingPatterns.FactorMethod.BaseProduct;

namespace DesignPatterns.GeneratingPatterns.FactorMethod.ConcreteProduct
{
    class StoneHouse : House
    {
        public StoneHouse()
        {
            Console.WriteLine("Stone house was build");
        }
    }
}
