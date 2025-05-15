using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Constructorul privat pentru singleton
        private DataManager()
        {
            MateriiPrime = new List<Materieprima>();
            Produse = new List<Produs>();
            LoturiFabricatie = new List<LotFabricatie>();
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

        // Metodă pentru adăugarea unei materii prime
        public void AdaugaMateriePrima(Materieprima materiePrima)
        {
            if (materiePrima != null)
            {
                MateriiPrime.Add(materiePrima);
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
    }
}
