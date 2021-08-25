using System;
using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteProduct.WeaponClass
{
    class Arbalet : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Стреляем из арбалета");
        }
    }
}
