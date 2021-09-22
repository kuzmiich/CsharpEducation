using System.Data.SqlClient;

namespace DesignPatterns.FluentBuilder.Component
{
    public class DynamicSqlConnection
    {
        private string _server;
        private string _databaseName;
        private int? _userId;
        private int? _password;

        public DynamicSqlConnection ForServer(string name)
        {
            _server = name;
            return this;
        }
        
        public DynamicSqlConnection ForDatabase(string name)
        {
            _databaseName = name;
            return this;
        }


        public DynamicSqlConnection AsUser(int? id = null)
        {
            _userId = id;
            return this;
        }

        public DynamicSqlConnection WithPassword(int? password = null)
        {
            _password = password;
            return this;
        }

        public SqlConnection Connection()
        {
            var id = _userId.HasValue ? _userId.Value.ToString() : string.Empty;
            var password = _password.HasValue ? _password.Value.ToString() : string.Empty;
            var connection = new SqlConnection($"Server={_server};Database={_databaseName};User Id={id};" +
                                                                     $"Password={password}");
            connection.Open();
            
            return connection;
        }
    }
}