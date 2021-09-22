using DesignPatterns.StructuralPatterns.Decorator.BaseComponent;

namespace DesignPatterns.StructuralPatterns.Decorator.ConcreteComponent
{
    internal class BulgerianPizza : Pizza
    {
        public BulgerianPizza()
            : base("Bulgerian pizza")
        { }
        public override int GetCost() => 8;
    }
}