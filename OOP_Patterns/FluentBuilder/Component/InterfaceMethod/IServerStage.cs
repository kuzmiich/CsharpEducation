namespace DesignPatterns.FluentBuilder.Component.InterfaceMethod
{
    public interface IServerStage
    {
        IDatabaseStage ForServer(string name);
    }
}