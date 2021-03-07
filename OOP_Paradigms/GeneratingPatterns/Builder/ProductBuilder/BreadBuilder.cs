using OOP_Paradigms.GeneratingPatterns.Builder.Product;

namespace OOP_Paradigms.GeneratingPatterns.Builder.ProductBuilder
{
    abstract class BreadBuilder
    {
        public Bread Bread { get; set; }
        public abstract void SetSalt();
        public abstract void SetFlour();
        public abstract void SetAdditive();
    }
}
