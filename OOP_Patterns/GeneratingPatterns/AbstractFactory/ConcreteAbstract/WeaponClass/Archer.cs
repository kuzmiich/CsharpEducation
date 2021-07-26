using System;
using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteAbstract.WeaponClass
{
    class Archer : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Стреляем из лука");
        }
    }
}
