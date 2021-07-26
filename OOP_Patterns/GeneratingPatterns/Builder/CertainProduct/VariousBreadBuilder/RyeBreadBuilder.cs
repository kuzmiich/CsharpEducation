using DesignPatterns.GeneratingPatterns.Builder.ProductComponent;

namespace DesignPatterns.GeneratingPatterns.Builder.ProductBuilder.VariousBreadBuilder
{
    class RyeBreadBuilder : BreadBuilder
    {
        public override void SetFlour()
        {
            Bread.Flour = new Flour { Type = "Rye flour 1 grade" };
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }

        public override void SetAdditive()
        {
            Bread.Additives = new Additive { Name = "Default additives" };
        }
    }
}
