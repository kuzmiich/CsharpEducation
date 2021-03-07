using OOP_Paradigms.GeneratingPatterns.Builder;
using OOP_Paradigms.GeneratingPatterns.FactorMethod;
using OOP_Paradigms.GeneratingPatterns.Prototype;
using OOP_Paradigms.GeneratingPatterns.Singleton;
using System;

namespace OOP_Paradigms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Порождающие паттерны:\n" +
                "-Factory method\n" +
                "-Abstract factory\n" +
                "-Singletone\n" +
                "-Prototype\n" +
                "-Builder");
            LaunchAbstractMethod factoryMethod = new LaunchAbstractMethod();
            LaunchAbstractMethod abstractFactory = new LaunchAbstractMethod();
            LaunchSingleton singletone = new LaunchSingleton();
            LaunchPrototype prototype = new LaunchPrototype();
            LaunchBuilder builder = new LaunchBuilder();

            factoryMethod.OutPatternInfo();

            abstractFactory.OutPatternInfo();

            singletone.OutPatternInfo();

            prototype.OutPatternInfo();

            builder.OutPatternInfo();
        }
    }
}
