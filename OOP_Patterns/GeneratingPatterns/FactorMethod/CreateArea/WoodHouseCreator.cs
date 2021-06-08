using OOP_Paradigms.GeneratingPatterns.FactorMethod.BaseCreator;
using OOP_Paradigms.GeneratingPatterns.FactorMethod.BaseProduct;
using OOP_Paradigms.GeneratingPatterns.FactorMethod.Products;

namespace OOP_Paradigms.GeneratingPatterns.FactorMethod.CreateArea
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
