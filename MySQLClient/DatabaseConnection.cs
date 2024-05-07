using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySQLClient
{
    public class DatabaseConnection
    {
        private DatabaseConnection(){}

        private static MySqlConnection _connection = null;
        private static readonly object _lock = new object();
        /// <summary>
        /// Database singleton, returns current connection
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection GetConnection()
        {
            if (_connection == null)
            {
                lock (_lock)
                {
                    if (_connection == null)
                    {
                        _connection = new MySqlConnection("Database = Maturita; DataSource = localhost; UserId = root;");;
                    }
                }
            }
            return _connection;
        }

    }
}
