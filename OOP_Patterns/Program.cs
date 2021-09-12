using OOP_Patterns.PatternsOfBehavior.Observer;
using System;
using DesignPatterns.FluentBuilder;
using DesignPatterns.GeneratingPatterns.Builder;
using DesignPatterns.GeneratingPatterns.FactorMethod;
using DesignPatterns.GeneratingPatterns.Prototype;
using DesignPatterns.GeneratingPatterns.Singleton;
using DesignPatterns.PatternsOfBehavior.Strategy;
using DesignPatterns.StructuralPatterns.Decorator;
using DesignPatterns.StructuralPatterns.Facade;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(
                "Порождающие паттерны(Generating patterns):\n" +
                "-Factory method\n" +
                "-Abstract factory\n" +
                "-Singletone\n" +
                "-Prototype\n" +
                "-Builder\n" +
                $"{string.Empty.PadLeft(50, '-')}\n" +
                "Паттерны поведения(PatternsOfBehavior):\n" +
                "Strategy\n" +
                "Observer\n" +
                "Command\n" +
                "Template method\n" +
                "Iterator\n" +
                "State\n" +
                "Chain of resposibility\n" +
                "Interpreter\n" +
                "Memento\n" +
                "Visitor\n" +
                $"{string.Empty.PadLeft(50, '-')}\n" +
                "Структурные паттерны:\n" +
                "Decorator\n" +
                "Adapter\n" +
                "Facede\n" +
                "Composite\n" +
                "Deputy\n" +
                "Bridge\n" +
                "Flyweight\n" +
                $"{string.Empty.PadLeft(50, '-')}\n");

            ILaunchPattern[] patternArray =
            {
                /*new LaunchFactoryMethod(),
                new LaunchAbstractFactory(),
                new LaunchSingleton(),
                new LaunchPrototype(),
                new LaunchBuilder(),
                new LaunchStrategy(),
                new LaunchObserver(),
                new LaunchDecorator(),
                new LaunchFacade(),
                new LaunchFluentBuilder(),*/
                new LaunchFluentBuilder()
            };

            try
            {
                foreach (var pattern in patternArray)
                {
                    pattern.OutPatternInfo();
                }
            }
            catch(ApplicationException ex)
            {
                Console.WriteLine($"Error, {ex}");
            }
        }
    }
}
