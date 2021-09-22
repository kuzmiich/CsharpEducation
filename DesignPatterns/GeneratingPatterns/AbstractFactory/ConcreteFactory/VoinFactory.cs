using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;
using DesignPatterns.GeneratingPatterns.AbstractFactory.BaseFactory;
using DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteProduct.MovementClass;
using DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteProduct.WeaponClass;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteFactory
{
    class VoinFactory : HeroFactory
    {
        public override IMovement CreateMovement()
        {
            return new GoMovement();
        }

        public override IWeapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
