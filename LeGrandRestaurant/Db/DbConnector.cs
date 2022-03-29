using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGrandRestaurant.Db
{
    public class DbConnector
    {
        public static MySqlConnection GetConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "restaurant";
            string username = "root";
            string password = "valkyria";

            return new MySqlConnection($"Server={host};Database={database};port={port};User Id={username};password={password}");
        }


        public static string? Restaurant(MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM `tests`";

            try
            {
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            return reader.GetString(reader.GetOrdinal("test"));
                        }
                    }
                }
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}
