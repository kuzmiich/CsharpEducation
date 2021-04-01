using OOP_Paradigms.GeneratingPatterns.AbstractFactory.BaseFactory;
using OOP_Paradigms.GeneratingPatterns.AbstractFactory.AbstractProduct;
using OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteAbstract.MovementClass;
using OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteAbstract.WeaponClass;

namespace OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteFactory
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
