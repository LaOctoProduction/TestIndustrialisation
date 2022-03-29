using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGrandRestaurant
{
    public class Plat
    {
        public string Nom;
        public double Prix;

        public Plat(string nom, double prix)
        {
            this.Nom = nom;
            this.Prix = prix;
        }
    }
}
