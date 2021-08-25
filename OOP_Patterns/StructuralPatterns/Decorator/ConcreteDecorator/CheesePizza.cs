using DesignPatterns.StructuralPatterns.Decorator.BaseComponent;
using DesignPatterns.StructuralPatterns.Decorator.BaseDecorator;

namespace DesignPatterns.StructuralPatterns.Decorator.ConcreteDecorator
{
    internal class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza)
            : base(pizza.Name + ", with cheese", pizza)
        { }
 
        public override int GetCost()
        {
            return Pizza.GetCost() + 5;
        }
    }
}