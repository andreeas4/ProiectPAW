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
        public List<LotFabricatie> LoturiFabricatie { get; private set; }
		public List<IngredientProdus> IngredienteSelectate { get; private set; } = new List<IngredientProdus>();

		private static Dictionary<string, Materieprima> hashMateriiPrime = new Dictionary<string, Materieprima>();
		// Constructorul privat pentru singleton
		private DataManager()
        {
            MateriiPrime = new List<Materieprima>();
            Produse = new List<Produs>();
            LoturiFabricatie = new List<LotFabricatie>();
			IngredienteSelectate = new List<IngredientProdus>();

			

		}

        // Metoda pentru obținerea instanței unice a DataManager
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

		// Metodă pentru adăugarea unei materii prime
		public void AdaugaMateriePrima(Materieprima materiePrima)
        {
            if (materiePrima != null)
            {
                MessageBox.Show(materiePrima.ToString());
                MateriiPrime.Add(materiePrima);
                HashMateriiPrime.Add(materiePrima.nume, materiePrima);
			}
        }

        // Metodă pentru adăugarea unui produs
        public void AdaugaProdus(Produs produs)
        {
            if (produs != null)
            {
                Produse.Add(produs);
            }
        }

        // Metodă pentru adăugarea unui lot de fabricație
        public void AdaugaLotFabricatie(LotFabricatie lotFabricatie)
        {
            if (lotFabricatie != null)
            {
                LoturiFabricatie.Add(lotFabricatie);
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
