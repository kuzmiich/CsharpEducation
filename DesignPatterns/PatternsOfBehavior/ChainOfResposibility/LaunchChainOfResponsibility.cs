using DesignPatterns;
using System;

namespace OOP_Patterns.PatternsOfBehavior.ChainOfResposibility
{
    class LaunchChainOfResponsibility : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            Console.WriteLine("В каких случаях используется паттерн Chain Responsibility:\n" +
                "");
        }
    }
}
