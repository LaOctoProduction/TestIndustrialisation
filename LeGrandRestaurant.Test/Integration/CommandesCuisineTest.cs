using LeGrandRestaurant.Test.Utilities;
using Xunit;
using NFluent;


namespace LeGrandRestaurant.Test.Integration
{
    public class CommandesCuisineTest
    {
        [Fact(DisplayName = "ÉTANT DONNE un serveur dans un restaurant " +
                            "QUAND il prend une commande de nourriture " +
                            "ALORS cette commande apparaît dans la liste de tâches de la cuisine de ce restaurant")]
        public void CommandeNourriture()
        {
            // ÉTANT DONNE un serveur dans un restaurant
            var serveur = new ServeurBuilder(true).Build();
            var restaurant = new Restaurant(serveur);

            var commande = new CommandeNourriture();

            // QUAND il prend une commande de nourriture
            serveur.PrendreCommande(commande);

            // ALORS cette commande apparaît dans la liste de tâches de la cuisine de ce restaurant
            var listeTâches = restaurant.ListeTâchesCuisine;
            Check.
                That(listeTâches).
                Contains(commande);
        }

        [Fact(DisplayName = "ÉTANT DONNE un serveur dans un restaurant " +
                            "QUAND il prend une commande de boissons " +
                            "ALORS cette commande n'apparaît pas dans la liste de tâches de la cuisine de ce restaurant")] 
        public void CommandeBoissons()
        {
            // ÉTANT DONNE un serveur dans un restaurant
            var serveur = new ServeurBuilder(true).Build();
            var restaurant = new Restaurant(serveur);
            var commande = new CommandeBoissons();

            // QUAND il prend une commande de boissons
            serveur.PrendreCommande(commande);

            // ALORS cette commande n'apparaît pas dans la liste de tâches de la cuisine de ce restaurant
            var listeTâches = restaurant.ListeTâchesCuisine;
            Check.
                That(listeTâches).
                Not.Contains(commande);
        }
    }
}
