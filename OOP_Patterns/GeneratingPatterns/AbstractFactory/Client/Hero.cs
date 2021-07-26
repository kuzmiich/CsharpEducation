using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;
using DesignPatterns.GeneratingPatterns.AbstractFactory.BaseFactory;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.Client
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
