using System;
using DesignPatterns.GeneratingPatterns.FactorMethod.BaseProduct;

namespace DesignPatterns.GeneratingPatterns.FactorMethod.Products
{
    class StoneHouse : House
    {
        public StoneHouse()
        {
            Console.WriteLine("Каменный дом построен");
        }
    }
}
