using DesignPatterns;
using System;

namespace OOP_Patterns.PatternsOfBehavior.Visitor
{
    class LaunchVisitor : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            Console.WriteLine("В каких случаях используется паттерн Visitor:\n" +
                "");
        }
    }
}
