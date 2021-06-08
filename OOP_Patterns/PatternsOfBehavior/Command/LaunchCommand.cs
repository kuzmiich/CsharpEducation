using OOP_Paradigms;
using System;

namespace OOP_Patterns.PatternsOfBehavior.Command
{
    class LaunchCommand : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            Console.WriteLine("В каких случаях используется паттерн Command:\n" +
                "");
        }
    }
}
