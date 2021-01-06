using Education.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.classes
{
    class ObjectTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("Изучение тепа object, его полей и методов");
            object obj = new object();
            object obj1 = new object();
            object obj2 = new object();
            // Методы
            obj.ToString();
            obj.GetType();
            obj.Equals(obj1);
            obj.GetHashCode();
            object.Equals(obj1, obj2);
            object.ReferenceEquals(obj1, obj2);
            // поля
            Test test = new Test();

            foreach (var memb in test.GetType().GetFields())
            {
                Console.WriteLine(memb.Name);
            }
        }
        class Test
        {
            public Test()
            {

            }
        }
    }
}
