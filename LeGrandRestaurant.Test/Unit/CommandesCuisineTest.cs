using LeGrandRestaurant.Test.Utilities;
using Xunit;
using NFluent;

namespace LeGrandRestaurant.Test.Unit
{
    public class CommandesCuisineTest
    {
        [Fact(DisplayName = "ÉTANT DONNE un serveur " +
                            "QUAND il prend une commande de nourriture" +
                            "ALORS cette commande est ajoutée a la liste des commandes qu'il prend")]
        public void PrendreCommandeNourriture_AjouteLaCommandeDansLaListeDuServeur()
        {
            //ETANT DONNE un serveur
            var serveur = new ServeurBuilder().Build();

            //QUAND il prend une commande
            var commande = new CommandeNourriture();

            //ALORS cette commande est ajoutée a sa liste
            serveur.PrendreCommande(commande);

            Check.
                That(serveur.CommandesPrises).
                Contains(commande);
        }


        [Fact(DisplayName = "ÉTANT DONNE un serveur " +
                           "QUAND il prend une commande de boisson" +
                           "ALORS cette commande est ajoutée a la liste des commandes qu'il prend")]
        public void PrendreCommandeBoissons_AjouteLaCommandeDansLaListeDuServeur()
        {
            //ETANT DONNE un serveur
            var serveur = new ServeurBuilder().Build();

            //QUAND il prend une commande
            var commande = new CommandeBoissons();

            //ALORS cette commande est ajoutée a sa liste
            serveur.PrendreCommande(commande);

            Check.
                That(serveur.CommandesPrises).
                Contains(commande);

        }
    }
}
