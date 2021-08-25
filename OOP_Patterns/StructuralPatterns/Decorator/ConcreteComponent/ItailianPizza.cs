using DesignPatterns.StructuralPatterns.Decorator.BaseComponent;

namespace DesignPatterns.StructuralPatterns.Decorator.ConcreteComponent
{
    internal class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Italian pizza")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }
}