using System;
using DesignPatterns.GeneratingPatterns.FactorMethod.BaseCreator;
using DesignPatterns.GeneratingPatterns.FactorMethod.BaseProduct;
using DesignPatterns.GeneratingPatterns.FactorMethod.ConcreteProduct;

namespace DesignPatterns.GeneratingPatterns.FactorMethod.CreateArea
{
    class StoneHouseCreator : Creator
    {

        public StoneHouseCreator(string name) : base(name)
        {
        }

        public override House Create()
        {
            return new StoneHouse();
        }
    }
}
