using System;
using System.Data.SqlClient;
using DesignPatterns.FluentBuilder.Component.InterfaceMethod;

namespace DesignPatterns.FluentBuilder.Component
{
    public class InterfaceSqlConnection : 
        IServerStage, IDatabaseStage, IUserStage, IPasswordStage, IConnectionInitializerStage
    {
        private string _server;
        private string _databaseName;
        private int _userId;
        private int _password;

        private InterfaceSqlConnection()
        {
        }
        
        public static IServerStage CreateConnection(Action<ConnectionConfiguration> configuration)
        {
            var config = new ConnectionConfiguration();
            configuration?.Invoke(config);
            return new InterfaceSqlConnection();
        }
        public IServerStage CreateConnection()
        {
            return this;
        }
        public IDatabaseStage ForServer(string name)
        {
            _server = name;
            return this;
        }
        
        public IUserStage ForDatabase(string name)
        {
            _databaseName = name;
            return this;
        }


        public IPasswordStage AsUser(int id)
        {
            _userId = id;
            return this;
        }

        public IConnectionInitializerStage WithPassword(int password)
        {
            _password = password;
            return this;
        }
        

        public SqlConnection Connection()
        {
            var connection = new SqlConnection($"Server={_server};Database={_databaseName};User Id={_userId};" +
                                               $"Password={_password}");
            connection.Open();
            return connection;
        }
    }
}