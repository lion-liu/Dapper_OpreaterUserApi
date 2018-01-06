using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WebApiTest.IDal;

namespace WebApiTest.Dal
{
    public class DbFactory : IDbFactory
    {
        readonly string _connectionString;

        public DbFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection Create(bool open = true)
        {
            var connection = new MySqlConnection(_connectionString);
            if(open)
            {
                connection.Open();
            }

            return connection;
        }
    }
}