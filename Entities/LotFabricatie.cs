using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    internal class LotFabricatie : ICloneable, IComparable<LotFabricatie>
    {
        private int idLot;
        private DateTime dataFabricatie;
        private List<Produs> produse;
        private double cantitateTotala;

        public int IdLot { get => idLot; set => idLot = value; }
        public DateTime DataFabricatie { get => dataFabricatie; set => dataFabricatie = value; }
        public List<Produs> Produse { get => produse; set => produse = value; }
        public double CantitateTotala { get => cantitateTotala; }

        // Constructor implicit
        public LotFabricatie()
        {
            idLot = 0;
            dataFabricatie = DateTime.Now;
            produse = new List<Produs>();
            cantitateTotala = 0;
        }

        // Constructor cu parametri
        public LotFabricatie(int idLot, DateTime dataFabricatie, List<Produs> produse)
        {
            this.idLot = idLot;
            this.dataFabricatie = dataFabricatie;
            this.produse = produse ?? new List<Produs>();
            this.cantitateTotala = produse.Sum(p => p.Cant);
        }

        // Metoda de adăugare a unui produs în lot
        public void AdaugaProdus(Produs p)
        {
            if (p != null)
            {
                produse.Add(p);
                cantitateTotala += p.Cant;
            }
        }

        // Suprascrierea metodei ToString pentru un format mai clar
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------");
            sb.AppendLine($" Lot ID: {idLot}");
            sb.AppendLine($"Data fabricație: {dataFabricatie.ToShortDateString()}");
            sb.AppendLine($"Cantitate totală: {cantitateTotala} kg");
            sb.AppendLine("Produse incluse:");

            if (produse.Count > 0)
            {
                foreach (var p in produse)
                {
                    sb.AppendLine($"  - {p.NumeProdus} ({p.Cant} kg)");
                }
            }
            else
            {
                sb.AppendLine("   Fără produse în acest lot.");
            }

            sb.AppendLine("------------------------------");
            return sb.ToString();
        }

        // Implementare ICloneable
        public object Clone()
        {
            return new LotFabricatie(this.idLot, this.dataFabricatie, new List<Produs>(this.produse));
        }

        // Implementare IComparable<LotFabricatie>
        public int CompareTo(LotFabricatie other)
        {
            if (other == null) return 1;
            return this.cantitateTotala.CompareTo(other.cantitateTotala);
        }
    }
}
