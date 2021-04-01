using OOP_Paradigms.GeneratingPatterns.AbstractFactory.AbstractProduct;
using OOP_Paradigms.GeneratingPatterns.AbstractFactory.BaseFactory;
using OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteAbstract.MovementClass;
using OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteAbstract.WeaponClass;

namespace OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteFactory
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
