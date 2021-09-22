using System;
using DesignPatterns.GeneratingPatterns.FactorMethod.BaseProduct;

namespace DesignPatterns.GeneratingPatterns.FactorMethod.ConcreteProduct
{
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Wood house was build");
        }
    }
}
