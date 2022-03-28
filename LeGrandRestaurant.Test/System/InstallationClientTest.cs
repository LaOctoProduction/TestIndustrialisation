using Xunit;
using NFluent;

namespace LeGrandRestaurant.Test.System
{
    public class InstallationClientTest
    {
        [Fact(DisplayName = "ÉTANT DONNE une table dans un restaurant ayant débuté son service " +
              "QUAND un client est affecté à une table " +
              "ALORS cette table n'est plus sur la liste des tables libres du restaurant")]
        public void AffectationClient()
        {
            // ÉTANT DONNE une table dans un restaurant ayant débuté son service
            var table = new Table();
            var restaurant = new Restaurant(table);
            restaurant.DébuterService();

            var client = new Client();

            // QUAND un client est affecté à une table
            table.Affecter(client);

            // ALORS cette table n'est plus sur la liste des tables libres du restaurant
            var tablesLibres = restaurant.TablesLibres;

            Check.That(tablesLibres).Not.Contains(table);
        }

        [Fact(DisplayName = "ÉTANT DONNE une table occupée par un client " +
                            "QUAND la table est libérée " +
                            "ALORS cette table appraît sur la liste des tables libres du restaurant")]
        public void DésaffectationClient()
        {
            // ÉTANT DONNE une table occupée par un client
            var table = new Table();
            var restaurant = new Restaurant(table);
            restaurant.DébuterService();

            var client = new Client();
            table.Affecter(client);

            // QUAND la table est libérée
            table.Libérer();

            // ALORS cette table apparaît sur la liste des tables libres du restaurant
            var tablesLibres = restaurant.TablesLibres;

            Check.
                That(tablesLibres).
                Contains(table);
        }
        
    }
}
