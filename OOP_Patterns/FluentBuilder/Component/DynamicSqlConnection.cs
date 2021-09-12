using System.Data.SqlClient;

namespace DesignPatterns.FluentBuilder.Component
{
    public class DynamicSqlConnection
    {
        private string _server;
        private string _databaseName;
        private int _userId;
        private int _password;

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


        public DynamicSqlConnection AsUser(int id)
        {
            _userId = id;
            return this;
        }

        public DynamicSqlConnection WithPassword(int password)
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