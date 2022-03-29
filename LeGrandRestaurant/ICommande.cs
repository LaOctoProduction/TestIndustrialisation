using System.Collections.Generic;
using System.Linq;

namespace LeGrandRestaurant
{
    public interface ICommande
	{
		public double Montant
		{
			get { return ListePlat.Sum(u => u.Prix); }
		}

		public List<Plat> ListePlat { get; set; }

		public bool IsNourriture { get; set; }
		public bool IsBoisson { get; set; }

		public void SetListPLat(List<Plat> plats);
		public List<Plat> GetListePlats();
	}
}
