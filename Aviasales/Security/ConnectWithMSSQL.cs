using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviasales.Security
{
    internal class ConnectWithMSSQL
    {
        SqlConnection conn = new SqlConnection(@"Data Source = PEKARNYA\SQLEXPRESS; Initial Catalog = UsersDB; Integrated Security = True;App=Agent;Asynchronous Processing=true");

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        public SqlConnection SqlConnectionState()
        {
            return conn;
        }
    }
}
