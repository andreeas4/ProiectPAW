using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    internal class MateriePrimaSolida:Materieprima
    {
        public double densitate;

        public MateriePrimaSolida(string nume, string um, double cost, double densitate)
            : base(nume,um, cost)  // Apelăm constructorul clasei de bază
        {
            this.densitate = densitate;
        }


        public override string DescriereMateriePrima()
        {
            return $"{nume} (Solid), Unitate de masura {um}, Cost {cost}/{um}, Densitate {densitate}";
        }

        public override bool Equals(object obj)
        {
            return obj is MateriePrimaSolida solida &&
                   nume == solida.nume &&
     
                   um == solida.um &&
                   cost == solida.cost &&
                   densitate == solida.densitate;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
