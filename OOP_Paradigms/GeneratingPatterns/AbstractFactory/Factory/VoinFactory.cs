using OOP_Paradigms.GeneratingPatterns.AbstractFactory.AbstractProduct;
using OOP_Paradigms.GeneratingPatterns.AbstractFactory.BaseFactory;
using OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteAbstract.MovementClass;
using OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteAbstract.WeaponClass;

namespace OOP_Paradigms.GeneratingPatterns.AbstractFactory.Factory
{
    class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new GoMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
