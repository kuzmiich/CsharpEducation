using System;
using DesignPatterns.GeneratingPatterns.Builder.ProductBuilder;
using DesignPatterns.GeneratingPatterns.Builder.ProductComponent;

namespace DesignPatterns.GeneratingPatterns.Builder.ConcreteProduct.VariousBreadBuilder
{
    class WheatBreadBuilder : BreadBuilder
    {
        public override void SetFlour()
        {
            Bread.Flour = new Flour { Type = "Wheat flour 2 grade" };
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }

        public override void SetAdditive()
        {
            Bread.Additives = new Additive { Name = "Perfect additives" };
        }
    }
}
