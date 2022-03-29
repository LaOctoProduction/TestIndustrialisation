using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace LeGrandRestaurant
{
    public class CommandeNourriture : ICommande
    {
        public double Montant
        {
            get { return ListePlat.Sum(u => u.Prix); }
        }

        public List<Plat> ListePlat { get; set; } = new List<Plat>();

        public bool IsBoisson { get; set; } = false;
        public bool IsNourriture { get; set; } = true;

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
