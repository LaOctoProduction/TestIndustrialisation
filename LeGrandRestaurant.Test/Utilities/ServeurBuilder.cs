using System.Collections.Generic;

namespace LeGrandRestaurant.Test.Utilities
{
    internal class ServeurBuilder
    {
        private readonly IList<ICommande> _commandeRepository;

        public ServeurBuilder(bool isIntegration = false)
        {
            _commandeRepository = isIntegration ? new DatabaseCommandeRepository() : new List<ICommande>();
        }

        public Serveur Build() => new (_commandeRepository);
    }
}
