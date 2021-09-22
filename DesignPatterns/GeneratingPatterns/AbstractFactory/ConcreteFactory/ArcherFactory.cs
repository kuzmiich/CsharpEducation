using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;
using DesignPatterns.GeneratingPatterns.AbstractFactory.BaseFactory;
using DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteProduct.MovementClass;
using DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteProduct.WeaponClass;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteFactory
{
    // Фабрика создания героя с луком
    class ArcherFactory : HeroFactory
    {
        public override IMovement CreateMovement()
        {
            return new RunMovement();
        }

        public override IWeapon CreateWeapon()
        {
            return new Archer();
        }
    }
}
