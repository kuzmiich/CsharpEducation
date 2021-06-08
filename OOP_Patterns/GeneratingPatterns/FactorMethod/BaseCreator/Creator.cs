using OOP_Paradigms.GeneratingPatterns.FactorMethod.BaseProduct;

namespace OOP_Paradigms.GeneratingPatterns.FactorMethod.BaseCreator
{
    // абстрактный класс строительной компании
    abstract class Creator
    {
        public string Name { get; private set; }

        public Creator(string name)
        {
            Name = name;
        }
        // фабричный метод
        abstract public House Create();
    }
}
