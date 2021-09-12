using System;
using DesignPatterns.FluentBuilder.Component;

namespace DesignPatterns.FluentBuilder
{
    public class LaunchFluentBuilder : ILaunchPattern
    {
        public void OutPatternInfo()
        {
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