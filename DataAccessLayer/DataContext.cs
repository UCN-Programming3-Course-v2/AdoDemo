using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public static class DataContext
    {
        public static IDbConnection GetConnection(string connectionString)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            return conn;
        }
    }
}
