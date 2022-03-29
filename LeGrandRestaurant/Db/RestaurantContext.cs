using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGrandRestaurant.Db
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(string connStr) : base(connStr)
        {
        }

        public DbSet<ICommande> Commandes { get; set; }
        public DbSet<Plat> Plats { get; set; }
    }
}
