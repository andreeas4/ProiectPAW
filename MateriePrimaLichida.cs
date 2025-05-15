using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    internal class MateriePrimaLichida : Materieprima
    {

        public double vascozitate { get; set; } // Minim 1 cP (apa), maxim 3000 cP (miere)


        public MateriePrimaLichida(string nume, string um, double cost, double vascozitate)
            : base(nume,um,cost) // Apelează constructorul clasei de bază Materieprima
        {
           
            this.vascozitate = vascozitate;
        }


        public override string DescriereMateriePrima()
        {
            return $"{nume} (Lichid), U.m: {um}, Vascozitate: {vascozitate} cP, Cost: {cost} lei/{um}";
        }


        public override bool Equals(object obj)
        {
            return obj is MateriePrimaLichida lichida &&
                   nume == lichida.nume &&
                  
                   um == lichida.um &&
                   cost == lichida.cost &&
                   vascozitate == lichida.vascozitate;
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
