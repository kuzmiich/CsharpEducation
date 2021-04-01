using OOP_Paradigms.GeneratingPatterns.AbstractFactory.AbstractProduct;
using OOP_Paradigms.GeneratingPatterns.AbstractFactory.BaseFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Paradigms.GeneratingPatterns.AbstractFactory.Client
{
    class Hero
    {
        private readonly IWeapon _weapon;
        private readonly IMovement _movement;

        public Hero(HeroFactory factory)
        {
            _weapon = factory.CreateWeapon();
            _movement = factory.CreateMovement();
        }
        public void Run()
        {
            _movement.Move();
        }
        public void Hit()
        {
            _weapon.Hit();
        }
    }
}
