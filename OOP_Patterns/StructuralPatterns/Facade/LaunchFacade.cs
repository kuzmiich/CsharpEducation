using DesignPatterns.StructuralPatterns.Facade.Client;
using DesignPatterns.StructuralPatterns.Facade.Subsystems;

namespace DesignPatterns.StructuralPatterns.Facade
{
    public class LaunchFacade : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            var subsystem1 = new Subsystem1();
            var subsystem2 = new Subsystem2();
            
            var facade = new BaseFacade.Facade(subsystem1, subsystem2);
            
            User.ClientCode(facade);
        }
    }
}