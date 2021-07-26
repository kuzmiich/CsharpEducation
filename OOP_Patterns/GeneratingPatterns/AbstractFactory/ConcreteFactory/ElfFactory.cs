using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;
using DesignPatterns.GeneratingPatterns.AbstractFactory.BaseFactory;
using DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteAbstract.MovementClass;
using DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteAbstract.WeaponClass;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.ConcreteFactory
{
    // Фабрика создания летящего героя с арбалетом
    class ElfFactory : HeroFactory
    {
        public override IMovement CreateMovement()
        {
            return new FlyMovement();
        }

        public override IWeapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}
