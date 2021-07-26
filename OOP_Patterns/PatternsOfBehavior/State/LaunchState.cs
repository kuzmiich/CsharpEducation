using DesignPatterns;
using System;

namespace OOP_Patterns.PatternsOfBehavior.State
{
    class LaunchState : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            Console.WriteLine("В каких случаях используется паттерн State:\n" +
                "");
        }
    }
}
