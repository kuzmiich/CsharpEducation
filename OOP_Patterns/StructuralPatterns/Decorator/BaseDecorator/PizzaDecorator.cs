using DesignPatterns.StructuralPatterns.Decorator.BaseComponent;

namespace DesignPatterns.StructuralPatterns.Decorator.BaseDecorator
{
    internal abstract class PizzaDecorator : Pizza
    {
        protected Pizza Pizza;
        public PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            Pizza = pizza;
        }
    }
}