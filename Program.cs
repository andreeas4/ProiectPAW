using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            /* Creăm ingrediente solide și lichide
             MateriePrimaSolida zahar = new MateriePrimaSolida
             {
                 nume = "Zahar",
                 cantitate = 100,
                 um = "g"
             };

             MateriePrimaLichida ulei = new MateriePrimaLichida
             {
                 nume = "Ulei de floarea soarelui",
                 cantitate = 50,
                 um = "ml",
                 vascozitate = 50
             };

             // Creăm un produs care conține aceste ingrediente
             List<Materieprima> listaIngrediente = new List<Materieprima> { zahar, ulei };

             Produs produs = new Produs(1, "Prajitura", 20.5, 2, DateTime.Now, listaIngrediente);

             // Afișăm produsul folosind ToString()
             Console.WriteLine(produs);

             // Testăm clonarea produsului
             Produs produsClonat = (Produs)produs.Clone();
             Console.WriteLine("Clona produsului:");
             Console.WriteLine(produsClonat);

             // Creăm un alt produs pentru comparare
             Produs altProdus = new Produs(2, "Tort", 40, 1, DateTime.Now, listaIngrediente);

             // Comparăm produsele după valoare (cantitate * preț)
             int comparare = produs.CompareTo(altProdus);
             if (comparare < 0)
                 Console.WriteLine($"{produs.NumeProdus} are o valoare mai mică decât {altProdus.NumeProdus}");
             else if (comparare > 0)
                 Console.WriteLine($"{produs.NumeProdus} are o valoare mai mare decât {altProdus.NumeProdus}");
             else
                 Console.WriteLine($"{produs.NumeProdus} și {altProdus.NumeProdus} au aceeași valoare");

             // Creăm un lot de fabricație și adăugăm produsele
             List<Produs> produse = new List<Produs> { produs, altProdus };
             LotFabricatie lot = new LotFabricatie(1001, DateTime.Now, produse);

             // Afișăm informațiile despre lotul de fabricație
             Console.WriteLine("\nInformații despre lotul de fabricație:");
             Console.WriteLine(lot);

             // Adăugăm un produs suplimentar în lot
             Produs p4 = new Produs(4, "Chec", 15.0, 2, DateTime.Now, listaIngrediente);
             lot.AdaugaProdus(p4);

             // Afișăm din nou informațiile despre lot după adăugarea produsului
             Console.WriteLine("\nDupă adăugarea unui nou produs:");
             Console.WriteLine(lot);

             Console.ReadKey();*/


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MeniuGestiuneProductie());


        }
           
    }
}
