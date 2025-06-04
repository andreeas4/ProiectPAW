using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    class Produs:IComparable,ICloneable,ICalculable
    {
       
        private int codProdus;
        private string numeProdus;
        private double pret;
        private double cant;
        private DateTime dataProductie;
		private double procentProfit = 20.0;
		public List<IngredientProdus> ingrediente;


        public string NumeProdus { get => numeProdus; set => numeProdus = value; }
        public int CodProdus { get => codProdus; set => codProdus = value; }
        public double Pret { get => pret; set => pret = value; }
        public double Cant { get => cant; set => cant = value; }
        public DateTime DataProductie { get => dataProductie; set => dataProductie = value; }

		private double costMediu;
		public double CostMediu { get => costMediu; }
		public Produs()
        {
            codProdus = 0;
            numeProdus = "Necunoscut";
            pret = 0.0f;
            cant = 0.0f;
            dataProductie = DateTime.MinValue;
            ingrediente = new List<IngredientProdus>();

        }
        public Produs(Produs produs)
        {
            this.codProdus= produs.codProdus;
            this.numeProdus= produs.numeProdus;
            this.pret = produs.pret;
            this.cant = produs.cant;
            this.DataProductie = produs.DataProductie;
            this.ingrediente = new List<IngredientProdus>(produs.ingrediente);

        }

        public Produs(int codProdus, string numeProdus, double pret, double cant, DateTime dataProductie, List<IngredientProdus> ingrediente)
        {
            this.codProdus = codProdus;
            this.numeProdus = numeProdus;
            this.pret = pret;
            this.cant = cant;
            this.dataProductie = dataProductie;
            this.ingrediente = new List<IngredientProdus>(ingrediente);

        }

        public void modificaDenumire(string denum)
        {
            numeProdus= denum;
        }
       
        public void AdaugaIngredient(IngredientProdus i)
        {
            if (i != null)
            {
                ingrediente.Add(i);
            }
        }
        public object Clone()
        {
            Produs clona = (Produs)this.MemberwiseClone();
            clona.ingrediente = new List<IngredientProdus>(this.ingrediente); // Copiere profundă a listei
            return clona;
        }


        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (!(obj is Produs)) throw new ArgumentException("Obiectul nu este un produs.");

            Produs otherProdus = (Produs)obj;

            double thisValue = this.cant * this.pret;
            double otherValue = otherProdus.cant * otherProdus.pret;

            return thisValue.CompareTo(otherValue);
        }
		public double CalculeazaPretFinal(double procentProfit)
		{
			double cantitate = this.Cant;
            double pret = this.Pret;
			double costTotal = ingrediente.Sum(i => i.Cantitate * i.Materie.cost);
			return costTotal +(pret*cantitate) *(1 + procentProfit / 100.0);
		}

		public void CalculeazaCostProductie()
		{
			costMediu = ingrediente.Sum(i => i.Materie.cost)+pret;
		}

		public override string ToString()
        {
            string ingredienteStr="";
            if (ingrediente.Count > 0)
            {
				foreach (var ing in ingrediente)
				{
					ingredienteStr += $"{ing.Materie.nume}: {ing.Cantitate} unități\n";
				}
			}
            else
            {
                ingredienteStr = "Fără ingrediente";
            }
            return $"------------------------------\n" +
           $" Produs: {numeProdus} \n" +
           $" Cod: {codProdus} \n" +
           $" Pret: {pret} lei \n" +
           $" Cantitate: {cant} kg \n" +
           $" Data Productie: {dataProductie.ToShortDateString()} \n" +
           $" Ingrediente:\n  - {ingredienteStr}\n" +
           $"------------------------------";
        }

       
    }
}
