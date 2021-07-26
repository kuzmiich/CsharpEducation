using System;
using DesignPatterns.GeneratingPatterns.FactorMethod.BaseProduct;

namespace DesignPatterns.GeneratingPatterns.FactorMethod.Products
{
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
}
