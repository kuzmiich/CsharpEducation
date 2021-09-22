using DesignPatterns;
using System;

namespace OOP_Patterns.PatternsOfBehavior.TemplateMethod
{
    class LaunchTemplateMethod : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            Console.WriteLine("В каких случаях используется паттерн Template Method:\n" +
                "");
        }
    }
}
