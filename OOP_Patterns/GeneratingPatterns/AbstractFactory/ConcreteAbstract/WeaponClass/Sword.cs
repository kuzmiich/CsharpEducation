using System;
using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteAbstract.WeaponClass
{
    class Sword : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
}
