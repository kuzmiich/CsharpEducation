using System.Data.SqlClient;

namespace DesignPatterns.FluentBuilder.Component
{
    public class SingletonSqlConnection
    {
        private string _server;
        private string _databaseName;
        private int? _userId;
        private int? _password;

        private SingletonSqlConnection()
        {
        }
        
        public SingletonSqlConnection ForServer(string name)
        {
            _server = name;
            return this;
        }
        
        public SingletonSqlConnection ForDatabase(string name)
        {
            _databaseName = name;
            return this;
        }


        public SingletonSqlConnection AsUser(int? id = null)
        {
            _userId = id;
            return this;
        }

        public SingletonSqlConnection WithPassword(int? password = null)
        {
            _password = password;
            return this;
        }

        public static SingletonSqlConnection CreateConnection() => new ();
        
        public SqlConnection Connection()
        {
            var userId = _userId.HasValue ? _userId.Value.ToString() : string.Empty;
            var password = _password.HasValue ? _password.Value.ToString() : string.Empty;
            var connection = new SqlConnection($"Server={_server};Database={_databaseName};User Id={userId};Password={password}");
            connection.Open();
            
            return connection;
        }

    }
}