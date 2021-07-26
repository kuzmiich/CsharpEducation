using DesignPatterns.GeneratingPatterns.Builder.Product;

namespace DesignPatterns.GeneratingPatterns.Builder.ProductBuilder
{
    abstract class BreadBuilder
    {
        public Bread Bread { get; set; }
        public abstract void SetSalt();
        public abstract void SetFlour();
        public abstract void SetAdditive();
    }
}
