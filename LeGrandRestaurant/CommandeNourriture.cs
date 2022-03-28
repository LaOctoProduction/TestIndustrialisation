using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace LeGrandRestaurant
{
    public class CommandeNourriture : ICommande
    {
        public double Montant { get; set; } = 0.0f;
        public List<Plat> ListePlat { get; set; } = new List<Plat>();

        public List<Plat> GetListePlats()
        {
            return ListePlat;
        }

        public double GetMontant()
        {
            return ListePlat.Sum(r => r.Prix);
        }

        public void SetListPLat(List<Plat> plats)
        {
            ListePlat.AddRange(plats);
        }
    }
}
