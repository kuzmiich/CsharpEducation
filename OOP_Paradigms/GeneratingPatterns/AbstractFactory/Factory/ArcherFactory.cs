using OOP_Paradigms.GeneratingPatterns.AbstractFactory.AbstractProduct;
using OOP_Paradigms.GeneratingPatterns.AbstractFactory.BaseFactory;
using OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteAbstract.MovementClass;
using OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteAbstract.WeaponClass;

namespace OOP_Paradigms.GeneratingPatterns.AbstractFactory.Factory
{
    // Фабрика создания героя с луком
    class ArcherFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Archer();
        }
    }
}
