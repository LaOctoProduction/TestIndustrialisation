using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGrandRestaurant.Db
{
    public class CommandeManager
    {
        public CommandeManager()
        {
        }

        public void Create(ICommande commande)
        {
            var conn = DbConnector.GetConnection();
            var cmd = new MySqlConnector.MySqlCommand();

            cmd.CommandText = "INSERT commandes (montant, is_nourriture, is_boisson) VALUES (@montant, @is_nourriture, @is_boisson)";
            cmd.Connection = conn;
            cmd.Parameters.Add("montant", DbType.Double).Value = commande.Montant;
            cmd.Parameters.Add("is_nourriture", DbType.Boolean).Value = commande.IsNourriture;
            cmd.Parameters.Add("is_boisson", DbType.Boolean).Value = commande.IsBoisson;

            foreach (var item in commande.ListePlat)
            {
                Create(item);
            }

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public void Create(Plat plat)
        {
            var conn = DbConnector.GetConnection();
            var cmd = new MySqlConnector.MySqlCommand();

            cmd.CommandText = "INSERT plat (nom, prix) VALUES (@nom, @prix)";
            cmd.Connection = conn;
            cmd.Parameters.Add("nom", DbType.String).Value = plat.Nom;
            cmd.Parameters.Add("prix", DbType.Double).Value = plat.Prix;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public void Clear()
        {
            var conn = DbConnector.GetConnection();
            var cmd = new MySqlConnector.MySqlCommand();

            cmd.CommandText = "TRUNCATE TABLE commandes; TRUNCATE TABLE plats;";
            cmd.Connection = conn;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public List<ICommande> Get()
        {
            List<ICommande> data = new List<ICommande>();
            try
            {
                var conn = DbConnector.GetConnection();
                var cmd = new MySqlConnector.MySqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM commandes";

                conn.Open();

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ICommande command;

                        int id = reader.GetInt32(reader.GetOrdinal("id"));
                        double montant = reader.GetDouble(reader.GetOrdinal("montant"));
                        bool isNourriture = reader.GetBoolean(reader.GetOrdinal("is_nourriture"));
                        bool isBoisson = reader.GetBoolean(reader.GetOrdinal("is_boisson"));

                        if (isNourriture)
                            command = new CommandeNourriture();
                        else
                            command = new CommandeBoissons();

                        var conn2 = DbConnector.GetConnection();
                        var cmd2 = new MySqlConnector.MySqlCommand();

                        cmd2.Connection = conn2;
                        cmd2.CommandText = "SELECT * FROM plats WHERE id = @id";
                        cmd2.Parameters.Add("@id", DbType.String).Value = id;

                        List<Plat> plats = new List<Plat>();

                        conn2.Open();

                        using (DbDataReader reader2 = cmd2.ExecuteReader())
                            while (reader2.Read())
                            {
                                var nom = reader2.GetString(reader2.GetOrdinal("nom"));
                                var prix = reader2.GetDouble(reader2.GetOrdinal("prix"));

                                plats.Add(new Plat(nom, prix));
                            }

                        command.SetListPLat(plats);
                        data.Add(command);

                        conn2.Close();
                        conn2.Dispose();
                    }
                }

                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                throw;
            }
            return data;
        }
    }
}
