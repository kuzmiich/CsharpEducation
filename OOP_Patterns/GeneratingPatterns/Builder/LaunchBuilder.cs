using OOP_Paradigms.GeneratingPatterns.Builder.ConcreteProduct.VariousBreadBuilder;
using OOP_Paradigms.GeneratingPatterns.Builder.Creator;
using OOP_Paradigms.GeneratingPatterns.Builder.Product;
using OOP_Paradigms.GeneratingPatterns.Builder.ProductBuilder;
using OOP_Paradigms.GeneratingPatterns.Builder.ProductBuilder.VariousBreadBuilder;
using System;

namespace OOP_Paradigms.GeneratingPatterns.Builder
{
    class LaunchBuilder : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            Console.WriteLine(
                "Когда использовать паттерн Builder\n" +
                "-Когда процесс создания нового объекта не должен зависеть от того, из каких частей этот объект состоит\n" +
                "и как эти части связаны между собой\n" +
                "-Когда необходимо обеспечить получение различных вариаций объекта в процессе его создания");


            Baker baker = new Baker();

            BreadBuilder builder = new RyeBreadBuilder();

            Bread ryeBread = baker.Bake(builder);
            Console.WriteLine(ryeBread.ToString());

            builder = new WheatBreadBuilder();
            Bread wheatBread = baker.Bake(builder);
            Console.WriteLine(wheatBread.ToString());
        }
    }
}
