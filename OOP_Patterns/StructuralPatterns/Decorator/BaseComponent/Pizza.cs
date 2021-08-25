namespace DesignPatterns.StructuralPatterns.Decorator.BaseComponent
{
    internal abstract class Pizza
    {
        protected Pizza(string name)
        {
            Name = name;
        }
        public string Name { get; protected set; }
        
        public abstract int GetCost();
    }
}