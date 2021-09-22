using System;

namespace DesignPatterns.GeneratingPatterns.Singleton
{
    class LaunchSingleton : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            Console.WriteLine(
                "Одиночка (Singleton, Синглтон) - порождающий паттерн, который гарантирует,\n" +
                "что для определенного класса будет создан только один объект, а также предоставит к этому объекту точку доступа.\n");
            var comp = new Computer();
            comp.Launch("Windows 8.1");

            Console.WriteLine(comp.OS.Name);

            // Не получится изменить ОС, так как объект уже создан    
            comp.OS = OS.GetInstance("Windows 10");
            Console.WriteLine(comp.OS.Name);
        }
    }
}
