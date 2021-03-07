using OOP_Paradigms.GeneratingPatterns.FactorMethod;
using System;

namespace OOP_Paradigms.GeneratingPatterns.Singleton
{
    class LaunchSingleton : LaunchPattern
    {
        public override void OutPatternInfo()
        {
            Console.WriteLine(
                "Одиночка (Singleton, Синглтон) - порождающий паттерн, который гарантирует,\n" +
                "что для определенного класса будет создан только один объект, а также предоставит к этому объекту точку доступа.\n");
            Computer comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.OS.Name);

            // у нас не получится изменить ОС, так как объект уже создан    
            comp.OS = OS.getInstance("Windows 10");
            Console.WriteLine(comp.OS.Name);
        }
    }
}
