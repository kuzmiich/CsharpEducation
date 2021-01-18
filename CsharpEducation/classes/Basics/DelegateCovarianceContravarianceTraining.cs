using Education.interfaces;
using System;

namespace Education.classes.Basics
{
    class UnitTest
    {
        public uint Number { get; set; }
        public string Condition { get; set; }

        public UnitTest(uint number, string condition)
        {
            Number = number;
            Condition = condition;
        }
        public virtual string TestCondition()
        {
            return $"{Number}.{Condition}?";
        }
    }
    class TestClass : UnitTest
    {
        public string Answer { get; private set; }
        public TestClass(uint number, string condition, string answer) : base(number, condition)
        {
            Answer = answer;
        }
        public override string TestCondition()
        {
            return $"{Number}.{Condition}?";
        }
        public string TestAnswer()
        {
            return $"Answer - {Answer}";
        }
    }

    class DelegateCovarianceContravarianceTraining : ITask
    {
        delegate UnitTest TestGenerator(uint name, string testCondition, string answer);
        delegate void TestClassInfo(TestClass testClass);

        public static void OutTask()
        {
            Console.WriteLine("----Ковариантность и Контравариантность----");
            Console.WriteLine("Ковариантность делегата предполагает, что возвращаемым типом может быть более производный тип.");
            Console.WriteLine("Контрвариантность делегата предполагает, что типом параметра может быть более универсальный тип.");

            Console.WriteLine("Пример ковариантности");
            TestGenerator testGenerator;
            testGenerator = BuildTest; // ковариантность
            UnitTest test = testGenerator(1, "1+1=", "2");
            TestClass testNormal = (TestClass)testGenerator(1, "1+1=", "2");

            Console.WriteLine("Базовый класс имеет в себе только 2 поля и 1 метод:");
            Console.WriteLine(test.Number);
            Console.WriteLine(test.Condition);
            Console.WriteLine(test.TestCondition());
            Console.WriteLine("Наследуемый класс имеет в себе 3 поля и 2 метода:");
            Console.WriteLine(testNormal.Number);
            Console.WriteLine(testNormal.Condition);
            Console.WriteLine(testNormal.Answer);
            Console.WriteLine(testNormal.TestCondition());
            Console.WriteLine(testNormal.TestAnswer());

            Console.WriteLine("Пример контравариантности");
            TestClassInfo info = TestInfo;
            info(testNormal);
        }
        private static TestClass BuildTest(uint testNumber, string testCondition, string testAnswer)
        {
            return new TestClass(testNumber, testCondition, testAnswer);
        }
        private static void TestInfo(UnitTest test)
        {
            Console.WriteLine(test.TestCondition());
        }
    }
}
