using Education.interfaces;
using System;

namespace Education.classes.TheBasics
{
    class AccessModifiers : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("Классы могут быть internal и public(по умолчанию internal)");
            Console.WriteLine("Методы могут иметь любые модификаторы доступа!");
            Console.WriteLine("По умолчанию классы и структуры имеют доступ internal");
            Console.WriteLine("Поля и методы по умолчанию имеют доступ private и их нельзя переопределить");
            Console.WriteLine("Во вложенных классах можно использовать 4 основных модификатора доступа");
            Console.WriteLine("Модификатор для блока set или get можно установить, если свойство имеет оба блока");
        }
    }
    public class Test1
    {
        // автосвойство
        public string Prop { get; set; }
        private string Prop1 { get; set; } = "Hello";

        private string prop2;
        public string Prop2
        {
            set
            {
                prop2 = value;
            }
            get
            {
                return prop2;
            }
        }
        public int a;
        private int b;
        protected int c;
        internal int d;
        private protected int e;
        protected internal int f;

        public void aM() { }
        private void bM() { }
        protected void cM() { }
        internal void dM() { }
        protected internal void eM() { }
        private protected void fM() { }

        public class A { }
        private class B { }
        protected class C { }
        internal class D { }
        /*
        private protected E {  }
        protected internal F {  }*/
    }
    /*private class Test2 {}
    protected class Test3 { }*/
    internal class Test4 { }
    /*private protected class Test5 {}
    protected internal class Test6 {}
    */
}
