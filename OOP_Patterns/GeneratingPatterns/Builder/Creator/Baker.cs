using OOP_Paradigms.GeneratingPatterns.Builder.Product;
using OOP_Paradigms.GeneratingPatterns.Builder.ProductBuilder;

namespace OOP_Paradigms.GeneratingPatterns.Builder.Creator
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
