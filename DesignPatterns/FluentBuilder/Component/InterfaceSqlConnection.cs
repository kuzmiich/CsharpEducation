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
        private int? _userId;
        private int? _password;

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


        public IPasswordStage AsUser(int? id = null)
        {
            _userId = id;
            return this;
        }

        public IConnectionInitializerStage WithPassword(int? password = null)
        {
            _password = password;
            return this;
        }
        

        public SqlConnection Connection()
        {
            var userId = _userId.HasValue ? _userId.Value.ToString() : string.Empty;
            var password = _password.HasValue ? _password.Value.ToString() : string.Empty;
            var connection = new SqlConnection($"Server={_server};Database={_databaseName};User Id={userId};" +
                                               $"Password={password}");
            connection.Open();
            return connection;
        }
    }
}