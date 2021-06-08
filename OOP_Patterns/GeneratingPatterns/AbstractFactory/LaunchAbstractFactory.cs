using OOP_Paradigms.GeneratingPatterns.AbstractFactory.Client;
using OOP_Paradigms.GeneratingPatterns.AbstractFactory.ConcreteFactory;
using OOP_Paradigms.GeneratingPatterns.FactorMethod.BaseProduct;
using System;

namespace OOP_Paradigms.GeneratingPatterns.FactorMethod
{
    class LaunchAbstractFactory : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            Console.WriteLine(
                "Когда нужно использовать паттерн абстрактный метод:\n" +
                "-Когда система не должна зависеть от способа создания и компоновки новых объектов\n" +
                "-Когда создаваемые объекты должны использоваться ВМЕСТЕ и являются взаимосвязанными\n"
            );

            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero voin = new Hero(new VoinFactory());
            voin.Hit();
            voin.Run();

            Hero archer = new Hero(new ArcherFactory());
            archer.Hit();
            archer.Run();
        }
    }
}
