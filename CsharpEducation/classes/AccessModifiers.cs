using ConsoleApp1.interfaces;
using System;

namespace Education.classes
{
    class AccessModifiers : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine();
        }
    }
    public class Test1
    {
        public void a() { }
        private void b() { }
        protected void c() { }
        internal void d() { }
        protected internal void e() { }
        private protected void f() { }
    }
    /*private class Test2 {}
    protected class Test3 { }*/
    internal class Test4 { }
    /*private protected class Test5 {}
    protected internal class Test6 {}
    */
}
