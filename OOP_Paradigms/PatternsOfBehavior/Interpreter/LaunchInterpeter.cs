using OOP_Paradigms;
using System;

namespace OOP_Patterns.PatternsOfBehavior.Interpreter
{
    class LaunchInterpeter : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            Console.WriteLine("В каких случаях используется паттерн Interpreter:\n" +
                "");
        }
    }
}
