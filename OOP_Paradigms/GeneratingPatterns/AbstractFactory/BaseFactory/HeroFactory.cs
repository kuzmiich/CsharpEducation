using OOP_Paradigms.GeneratingPatterns.AbstractFactory.AbstractProduct;

namespace OOP_Paradigms.GeneratingPatterns.AbstractFactory.BaseFactory
{
    abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
}
