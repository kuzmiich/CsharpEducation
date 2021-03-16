using OOP_Paradigms.GeneratingPatterns.Builder;
using OOP_Paradigms.GeneratingPatterns.FactorMethod;
using OOP_Paradigms.GeneratingPatterns.Prototype;
using OOP_Paradigms.GeneratingPatterns.Singleton;
using OOP_Paradigms.PatternsOfBehavior.Strategy;
using OOP_Patterns.PatternsOfBehavior.Observer;
using System;

namespace OOP_Paradigms
{
    class Program
    {
        static void Main(string[] args)
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
                new LaunchFactoryMethod(),
                new LaunchAbstractFactory(),
                new LaunchSingleton(),
                new LaunchPrototype(),
                new LaunchBuilder(),
                new LaunchStrategy(),
                new LaunchObserver(),
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
