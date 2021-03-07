using OOP_Paradigms.GeneratingPatterns.AbstractFactory.AbstractProduct;
using System;

namespace OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteAbstract.WeaponClass
{
    class Archer : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляем из лука");
        }
    }
}
