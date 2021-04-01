﻿using OOP_Paradigms.GeneratingPatterns.AbstractFactory.AbstractProduct;
using System;

namespace OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteAbstract.WeaponClass
{
    class Sword : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
}
