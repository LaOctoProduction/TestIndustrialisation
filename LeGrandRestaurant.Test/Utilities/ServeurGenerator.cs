using System.Collections.Generic;

namespace LeGrandRestaurant.Test.Utilities
{
    internal class ServeurGenerator
    {
        private readonly ServeurBuilder _builder;

        public ServeurGenerator(bool isIntegration = false)
        {
            _builder = new ServeurBuilder (isIntegration);
        }

        public IEnumerable<Serveur> Generate(int nombre)
        {
            for (var i = 0; i < nombre; i++)
            {
                yield return _builder.Build();
            }
        }
    }
}
