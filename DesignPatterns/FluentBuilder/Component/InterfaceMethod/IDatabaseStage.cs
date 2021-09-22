namespace DesignPatterns.FluentBuilder.Component.InterfaceMethod
{
    public interface IDatabaseStage
    {
        IUserStage ForDatabase(string databaseName);
    }
}