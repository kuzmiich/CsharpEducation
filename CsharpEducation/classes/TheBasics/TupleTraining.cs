using Education.interfaces;
using System;
using System.Linq;

namespace Education.classes.TheBasics
{
    /// <summary>
    /// 
    /// </summary>
    class TupleTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("Работа с tuple");
            var tuple1 = (5, 10);
            Console.WriteLine(tuple1.Item1); // 5
            Console.WriteLine(tuple1.Item2); // 10
            tuple1.Item1 += 26;
            tuple1.Item1 = 10;
            Console.WriteLine(tuple1.Item1); // 31
            Console.WriteLine(tuple1.Item2); // 10
            //
            var tuple2 = (count: 5, sum: 10);
            Console.WriteLine(tuple2.count);//10
            Console.WriteLine(tuple2.sum);//5
            //
            var tuple3 = GetValues();
            Console.WriteLine(tuple3.Item1); // 1
            Console.WriteLine(tuple3.Item2); // 3
            //
            var tuple4 = GetNamedValues(new int[]{ 1,2,3,4,5,6,7});
            Console.WriteLine(tuple4.count);
            Console.WriteLine(tuple4.sum);
        }
        private static (int, int) GetValues()
        {
            var result = (1, 3);
            return result;
        }
        private static (int sum, int count) GetNamedValues(int[] arr)
        {
            var result = (sum: 0, count: 0);
            result.sum = arr.Sum();
            result.count = arr.Length;
            return result;
        }
    }
}
