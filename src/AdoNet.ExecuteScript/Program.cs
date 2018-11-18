using System;
using System.Data.SqlClient;
using System.IO;

namespace AdoNet.ExecuteScript
{
    class Program
    {
        static void Main(string[] args)
        {
            var connString = BuildConnectionString(args);
            var connection = new SqlConnection(connString);

            using (connection)
            {
                ExecuteScript(connection, @".\Max.sql");
            }
        }

        private static void ExecuteScript(SqlConnection connection, string path)
        {
            string query = File.ReadAllText(path);

            var command = connection.CreateCommand();
            command.CommandText = query;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Console.WriteLine("Script execution failed!");
            }

            Console.WriteLine("Script execution complete!");
        }

        private static string BuildConnectionString(string[] args)
        {
            var connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = args[0];
            connStringBuilder.InitialCatalog = args[1];
            connStringBuilder.IntegratedSecurity = true;

            return connStringBuilder.ToString();
        }
    }
}
