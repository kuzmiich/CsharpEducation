using System;
using DesignPatterns.FluentBuilder.Component;

namespace DesignPatterns.FluentBuilder
{
    public class LaunchFluentBuilder : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            var connectionSingleton = SingletonSqlConnection.CreateConnection()
                .ForServer("database")
                .ForDatabase("server")
                .AsUser()
                .WithPassword()
                .Connection();
            
            var connectionDynamic = new DynamicSqlConnection()
                .ForServer("database")
                .ForDatabase("server")
                .AsUser(1)
                .WithPassword(12345678)
                .Connection();
            
            var connectionInitializer = InterfaceSqlConnection
                .CreateConnection(config =>
                {
                    config.ConnectionName = "Connection name";
                })
                .ForServer("server")
                .ForDatabase("database")
                .AsUser(1)
                .WithPassword(12345678);
            Console.WriteLine(connectionInitializer);
        }
    }
}