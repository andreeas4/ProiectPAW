using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public abstract class Materieprima
    {
        protected Materieprima(string nume, string um, double cost)
        {
           
            this.nume = nume;
            this.um = um;
            this.cost = cost; //cost per um
        }

        public int IDMateriePrima { get; set; } // ID unic pentru fiecare materie primă
        public string nume { get; set; }
        public string um { get; set; }
        public double cost { get; set; }

        public abstract string Tip { get; } // Lichida / Solida

        public abstract string DescriereMateriePrima();
        public override string ToString()
        {
            return DescriereMateriePrima();
        }
    }
}
