using DesignPatterns.StructuralPatterns.Facade.Subsystems;

namespace DesignPatterns.StructuralPatterns.Facade.BaseFacade
{
    // Класс Фасада предоставляет простой интерфейс для сложной логики одной или
    // нескольких подсистем. Фасад делегирует запросы клиентов соответствующим
    // объектам внутри подсистемы. Фасад также отвечает за управление их
    // жизненным циклом. Все это защищает клиента от нежелательной сложности
    // подсистемы.
    public class Facade
    {
        protected Subsystem1 Subsystem1;
        
        protected Subsystem2 Subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            Subsystem1 = subsystem1;
            Subsystem2 = subsystem2;
        }
        
        // Методы Фасада удобны для быстрого доступа к сложной функциональности
        // подсистем. Однако клиенты получают только часть возможностей
        // подсистемы.
        public string Operation()
        {
            var result = "Facade initializes subsystems:\n";
            result += Subsystem1.operation1();
            result += Subsystem2.operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += Subsystem1.operationN();
            result += Subsystem2.operationZ();
            return result;
        }
    }
}