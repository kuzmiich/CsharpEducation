using Education.interfaces;
using System;

namespace Education.classes.Basics
{
    class Test
    {
        public string Number { get; set; }
        public string Condition { get; set; }

        public Test(string number, string condition)
        {
            Number = number;
            Condition = condition;
        }
    }
    class TestClass : Test
    {
        public string Answer { get; private set; }
        public TestClass(string number, string condition, string answer) : base(number, condition)
        {
            Answer = answer;
        }
        public override string ToString()
        {
            return $"{Number}.{Condition}?";
        }
        public string TestAnswer()
        {
            return $"Answer : {Answer}";
        }
    }

    class DelegateCovarianceContravarianceTraining : ITask
    {
        delegate Test TestGenerator(string name, string testCondition, string answer);
        public static void OutTask()
        {
            Console.WriteLine("----Ковариантность и Контравариантность----");
            Console.WriteLine("Ковариантность делегата предполагает, что возвращаемым типом может быть более производный тип.");
            Console.WriteLine("Контрвариантность делегата предполагает, что типом параметра может быть более универсальный тип.");

            TestGenerator testGenerator;
            testGenerator = BuildTest; // ковариантность
            Test test = testGenerator("1.Test", "1+1=", "2");
            Console.WriteLine(test.Number);
            Console.WriteLine(test.Condition);
            Console.WriteLine(test.ToString());
        }
        private static TestClass BuildTest(string testName, string testCondition, string answer)
        {
            return new TestClass(testName, testCondition, answer);
        }
    }
}
