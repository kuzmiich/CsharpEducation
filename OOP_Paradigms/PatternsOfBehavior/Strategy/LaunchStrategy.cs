using OOP_Paradigms.PatternsOfBehavior.Strategy.BaseCar;
using OOP_Paradigms.PatternsOfBehavior.Strategy.ConcreteCar;
using System;

namespace OOP_Paradigms.PatternsOfBehavior.Strategy
{
    class LaunchStrategy : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            Console.WriteLine();

            Car auto = new Car(4, "Volvo", new MotoCar());
            auto.Move();
            auto.Movable = new Truck();
            auto.Move();
        }
    }
}
