using DesignPatterns.GeneratingPatterns.Builder.Product;
using DesignPatterns.GeneratingPatterns.Builder.ProductBuilder;

namespace DesignPatterns.GeneratingPatterns.Builder.Creator
{
    class Baker
    {
        public Bread Bake(BreadBuilder builder)
        {
            builder.Bread = new Bread();
            builder.SetFlour();
            builder.SetSalt();
            builder.SetAdditive();
            return builder.Bread;
        }
    }
}
