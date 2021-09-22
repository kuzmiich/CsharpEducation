using System;
using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteProduct.WeaponClass
{
    class Sword : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
}
