using System;
namespace DesignPatterns.StructuralPatterns.Facade.Client
{
    internal class User
    {
        // Клиентский код работает со сложными подсистемами через простой
        // интерфейс, предоставляемый Фасадом. Когда фасад управляет жизненным
        // циклом подсистемы, клиент может даже не знать о существовании
        // подсистемы. Такой подход позволяет держать сложность под контролем.
        public static void ClientCode(BaseFacade.Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }

}