using Education.interfaces;
using System;

namespace Education.classes.Basics
{
    class DelegateActionPredicateFunc : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("------ Делегаты Action, Predicate и Func ------");
            Console.WriteLine("Делегат Action представляет из себя обобщенный делегат, имеющий перегрузку до 16 параметров.");
            Console.WriteLine("Делегат Predicate используется для сопоставления входного значения некоторому условию.");
            Console.WriteLine("Делегат Func, наиболее распространен, т.к. его можно модифицировать различными входными параметрами" +
                              "и выходными параметрами с модификаторами in out.Также имеет 16 перегрузок");
            

        }
    }
}
