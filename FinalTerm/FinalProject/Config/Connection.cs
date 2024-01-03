using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Config
{
    public static class Connection
    {
        private static readonly string connectionString = @"Data Source=PHONYY\DANGMINHPHONG;Initial Catalog=database;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

    }
}
