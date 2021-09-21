using DataAccessLayer;
using System;
using System.Data;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //SqlConnectionStringBuilder bldr = new SqlConnectionStringBuilder();
            //bldr.DataSource = @"(localdb)\mssqllocaldb";
            //bldr.InitialCatalog = "ContosoUniversity";
            //bldr.IntegratedSecurity = true;

            string connectionString = @"Data source=(localdb)\mssqllocaldb;Initial Catalog=ContosoUniversity;Integrated Security=true;";

            IDbConnection conn = DataContext.GetConnection(connectionString);
            conn.Open();        

            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Student";
            IDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(2) + " " + reader.GetString(1));
            }
        }
    }
}
