using OOP_Paradigms.GeneratingPatterns.AbstractFactory.AbstractProduct;

namespace OOP_Paradigms.GeneratingPatterns.AbstractFactory.BaseFactory
{
    abstract class HeroFactory
    {
        public abstract IMovement CreateMovement();
        public abstract IWeapon CreateWeapon();
    }
}
