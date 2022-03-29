using System.Collections.Generic;
using System.Linq;

namespace LeGrandRestaurant
{
    public class CommandeBoissons : ICommande
    {
        public double Montant { 
            get { return ListePlat.Sum(u => u.Prix); }
        }

        public List<Plat> ListePlat { get; set; } = new List<Plat>();

        public bool IsBoisson { get; set; } = true;
        public bool IsNourriture { get; set; } = false;

        public List<Plat> GetListePlats()
        {
            return ListePlat;
        }

        public void SetListPLat(List<Plat> plats)
        {
            ListePlat.AddRange(plats);
        }
    }
}
