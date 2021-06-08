using OOP_Paradigms.GeneratingPatterns.AbstractFactory.AbstractProduct;
using System;

namespace OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteAbstract.WeaponClass
{
    class Archer : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Стреляем из лука");
        }
    }
}
