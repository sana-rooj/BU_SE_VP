using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseExample
{
    class DBOperation
    {
        protected MySqlConnection connection;
        string server = "localhost";
        string database = "studentdb";
        string uid = "root";
        string password = "root";
        string connectionstring;
        public bool IsConnected()
        {
            if (connection == null)
            {
                connectionstring = string.Format("host={0};database={1};UID={2};Password={3};SslMode=none", server, database, uid, password);
                connection = new MySqlConnection(connectionstring);
                connection.Open();                
            }
            return true;
        }
    }
}
