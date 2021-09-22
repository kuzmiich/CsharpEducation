using DesignPatterns.StructuralPatterns.Decorator.BaseComponent;
using DesignPatterns.StructuralPatterns.Decorator.BaseDecorator;

namespace DesignPatterns.StructuralPatterns.Decorator.ConcreteDecorator
{
    internal class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza p) 
            : base(p.Name + ", with tomato", p)
        { }
 
        public override int GetCost()
        {
            return Pizza.GetCost() + 3;
        }
    }
}