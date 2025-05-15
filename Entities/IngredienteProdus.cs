using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
   public class IngredientProdus
    {
        public Materieprima Materie { get; set; }  // Materia primă
        public double Cantitate { get; set; }      // Cantitatea folosită din materia primă

        public IngredientProdus(Materieprima materie, double cantitate)
        {
            Materie = materie;
            Cantitate = cantitate;
        }

		public override string ToString()
		{
			return base.ToString();
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
