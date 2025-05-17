using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ProiectPAW.Forms;

namespace ProiectPAW
{
    internal class DataManager
    {
        // Instanță unică a clasei DataManager
        private static DataManager instance;

        // Listele pentru materii prime, produse și loturi de fabricație
        public List<Materieprima> MateriiPrime { get; private set; }
        public List<Produs> Produse { get; private set; }
        
		public List<IngredientProdus> IngredienteSelectate { get; private set; } = new List<IngredientProdus>();
        public List<Produs> ProduseSelectate { get; private set; } = new List<Produs>();

		private static Dictionary<string, Materieprima> hashMateriiPrime = new Dictionary<string, Materieprima>();
		private static Dictionary<(string,DateTime), Produs> hashProduse = new Dictionary<(string,DateTime), Produs>();
        
		private DataManager()
        {
            MateriiPrime = new List<Materieprima>();
            Produse = new List<Produs>();
			IngredienteSelectate = new List<IngredientProdus>();
			ProduseSelectate = new List<Produs>();
		}

     
        public static DataManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataManager();
                }
                return instance;
            }
        }

		public static Dictionary<string, Materieprima> HashMateriiPrime { get => hashMateriiPrime; set => hashMateriiPrime = value; }

		
		public void AdaugaMateriePrima(Materieprima materiePrima)
        {
            if (materiePrima != null)
            {
               
                MateriiPrime.Add(materiePrima);
                HashMateriiPrime.Add(materiePrima.nume, materiePrima);
			}
        }

		public static Dictionary<(string, DateTime), Produs> HashProduse
		{
			get => hashProduse;
			set => hashProduse = value;
		}

		public void AdaugaProdus(Produs produs)
        {
            if (produs != null)
            {
                Produse.Add(produs);
                hashProduse.Add((produs.NumeProdus, produs.DataProductie), produs);
			}
        }

        
        
		public void AdaugaIngredient(IngredientProdus ingredient)
		{
			if (ingredient != null)
			{
				IngredienteSelectate.Add(ingredient);
			}
		}
		public void StergeIngredient(IngredientProdus ingredient)
		{
			if (ingredient != null)
			{
				IngredienteSelectate.Remove(ingredient);
			}
		}
	}
}
