using System.Collections.Generic;

namespace LeGrandRestaurant
{
    public interface ICommande
	{
		public double Montant { get; set; }
		public List<Plat> ListePlat { get; set; }

		public double GetMontant();
		public void SetListPLat(List<Plat> plats);
		public List<Plat> GetListePlats();
	}
}
