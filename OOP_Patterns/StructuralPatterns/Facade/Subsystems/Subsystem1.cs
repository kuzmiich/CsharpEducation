namespace DesignPatterns.StructuralPatterns.Facade.Subsystems
{
    // Подсистема может принимать запросы либо от фасада, либо от клиента
    // напрямую. В любом случае, для Подсистемы Фасад – это еще один клиент, и
    // он не является частью Подсистемы.
    public class Subsystem1
    {
        public string operation1()
        {
            return "Subsystem1: Ready!\n";
        }

        public string operationN()
        {
            return "Subsystem1: Go!\n";
        }
    }
}