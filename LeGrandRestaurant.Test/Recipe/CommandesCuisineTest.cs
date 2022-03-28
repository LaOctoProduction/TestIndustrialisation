using System.Linq;
using LeGrandRestaurant.Test.Utilities;
using Xunit;
using NFluent;


namespace LeGrandRestaurant.Test.Recipe
{
    public class CommandesCuisineTest
    {
        [Theory(DisplayName = "Simulation des commandes d'une soirée")]
        [InlineData(true)]
        [InlineData(false)]
        public void CommandeNourriture(bool isIntegration)
        {
            // ÉTANT DONNE des serveurs dans un restaurant
            var serveurs = new ServeurGenerator(isIntegration).Generate(8).ToArray();
            var restaurant = new Restaurant(serveurs);

            // QUAND ils prennent le rush de la soirée
            var commandes = Enumerable.Range(0, 120).Select(rang
                => rang % 3 == 0 ? (ICommande) new CommandeBoissons() : new CommandeNourriture())
                .ToArray();

            var noServeurEnCours = 0;
            foreach (var commande in commandes)
            {
                var serveurChoisi = serveurs[noServeurEnCours];
                serveurChoisi.PrendreCommande(commande);

                noServeurEnCours++;
                if (noServeurEnCours >= 8) noServeurEnCours = 0;
            }

            // ALORS cette commande apparaît dans la liste de tâches de la cuisine de ce restaurant
            var listeTâches = restaurant.ListeTâchesCuisine;
            Check.
                That(listeTâches).
                Contains(commandes);
        }
    }
}
