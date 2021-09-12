namespace DesignPatterns.FluentBuilder.Component.InterfaceMethod
{
    public interface IPasswordStage
    {
        IConnectionInitializerStage WithPassword(int password);
    }
}