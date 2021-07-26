using DesignPatterns.GeneratingPatterns.FactorMethod.BaseCreator;
using DesignPatterns.GeneratingPatterns.FactorMethod.BaseProduct;
using DesignPatterns.GeneratingPatterns.FactorMethod.Products;

namespace DesignPatterns.GeneratingPatterns.FactorMethod.CreateArea
{
    class WoodHouseCreator : Creator
    {
        public WoodHouseCreator(string name) : base(name)
        {

        }
        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
