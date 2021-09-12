namespace DesignPatterns.FluentBuilder.Component.InterfaceMethod
{
    public interface IUserStage
    {
        IPasswordStage AsUser(int userId);
    }
}