using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviasales.Security
{
    internal class RolesForLoginForm
    {
        public static string currentRole;

        public void GetRole(string login, string pass)
        {
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source = PEKARNYA\SQLEXPRESS; Initial Catalog = UsersDB; Integrated Security = True;App=Agent;Asynchronous Processing=true"))
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                string check2 = $"select UserRole from Persons where UserLogin = '{login}' and UserPassword = '{pass}'";
                SqlCommand cmd2 = new SqlCommand(check2, sqlConnection);
                string role = (string)cmd2.ExecuteScalar();
                currentRole = role;
            }

        }
    }
}
