using System;
using System.Data.SqlClient;

namespace JCS2.Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ! .NET Framework !
            // TODO show server explorer

            // Works only on my machine => connection needs to be initialized manually.
            var fileConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\School\JCS2\JCS2-2022\src\JCS2.Database\db.mdf;Integrated Security=True;Connect Timeout=30";

            var query1 = new SqlCommand("SELECT * FROM students");

            //ExecuteQuery(fileConnectionString, query1);

            var query2 = new SqlCommand("SELECT * FROM students WHERE Rocnik = @yearParam");
            query2.Parameters.AddWithValue("yearParam", 3);

            //ExecuteQuery(fileConnectionString, query2);
        }

        private static void ExecuteQuery(string connectionString, SqlCommand sqlCommand)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    sqlCommand.Connection = conn;
                    using (SqlDataReader dr = sqlCommand.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine($"{dr[0]}, {dr[1]}, {dr[2]}");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}
