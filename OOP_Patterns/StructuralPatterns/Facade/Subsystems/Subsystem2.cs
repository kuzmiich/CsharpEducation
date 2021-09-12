namespace DesignPatterns.StructuralPatterns.Facade.Subsystems
{
    // Некоторые фасады могут работать с разными подсистемами одновременно.
    public class Subsystem2
    {
        public static string Operation1() => "Subsystem2: Get ready!\n";

        public static string OperationZ() => "Subsystem2: Fire!\n";
    }
}