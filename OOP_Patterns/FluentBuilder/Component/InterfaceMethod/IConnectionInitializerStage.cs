using System.Data.SqlClient;

namespace DesignPatterns.FluentBuilder.Component.InterfaceMethod
{
    public interface IConnectionInitializerStage
    {
        SqlConnection Connection();
    }
}