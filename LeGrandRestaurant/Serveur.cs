using System.Collections.Generic;

namespace LeGrandRestaurant
{
    public class Serveur
    {
        public IEnumerable<ICommande> CommandesPrises => _commandesPrises;

        private readonly IList<ICommande> _commandesPrises;

        public Serveur(IList<ICommande> commandeRepository)
        {
            _commandesPrises = commandeRepository;
        }

        public void PrendreCommande(ICommande commande)
        {
            if (commande is CommandeNourriture || commande is CommandeBoissons)
                _commandesPrises.Add(commande);
        }
    }
}
