using LeGrandRestaurant.Db;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using NFluent;

namespace LeGrandRestaurant.Test.Db
{
    public class DbConnectorTest
    {
        [Fact(DisplayName = "Verification que la connexion à la base de donnée peut être effectuée correctement")]
        public void DBMySQLUtilsTest()
        {
            string? result = "";

            MySqlConnection conn = DbConnector.GetConnection();

            conn.Open();

            result = DbConnector.Restaurant(conn);

            conn.Close();
            conn.Dispose();

            Check.
                That(result).IsEqualTo("OK");
        }
    }
}
