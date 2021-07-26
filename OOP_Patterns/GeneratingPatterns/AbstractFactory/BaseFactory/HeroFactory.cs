using DesignPatterns.GeneratingPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.GeneratingPatterns.AbstractFactory.BaseFactory
{
    abstract class HeroFactory
    {
        public abstract IMovement CreateMovement();
        public abstract IWeapon CreateWeapon();
    }
}
