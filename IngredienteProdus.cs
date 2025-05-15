using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    internal class IngredientProdus
    {
        public Materieprima Materie { get; set; }  // Materia primă
        public double Cantitate { get; set; }      // Cantitatea folosită din materia primă

        public IngredientProdus(Materieprima materie, double cantitate)
        {
            Materie = materie;
            Cantitate = cantitate;
        }
	
	}
}
