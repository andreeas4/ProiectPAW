using ProiectPAW.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class FormProduse : Form
    { 
        List<Produs> produse = new List<Produs>();
		private List<IngredientProdus> ingredienteSelectate = new List<IngredientProdus>();
		public FormProduse()
        {
            InitializeComponent();
        }

		private void ExitButton_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void AdaugaProdus_Click(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			bool valid = true;
			if (!int.TryParse(CodprodusTb.Text, out int codProdus))
			{
				errorProvider1.SetError(CodprodusTb, "Introduceți un cod valid!");
				valid = false;
			}

			if (string.IsNullOrWhiteSpace(NumeProdusTb.Text))
			{
				errorProvider1.SetError(NumeProdusTb, "Introduceți numele produsului!");
				valid = false;
			}

			if (!Double.TryParse(PretTb.Text, out double pret))
			{
				errorProvider1.SetError(PretTb, "Introduceți un pret valid!");
				valid = false;
			}
			if (!Double.TryParse(CantitateTb.Text, out double cantitate))
			{
				errorProvider1.SetError(CantitateTb, "Introduceți o cantitate!");
				valid = false;
			}
		
			

			if (!valid)
				return; // Ieșim dacă sunt erori

			try
			{
				string nume = NumeProdusTb.Text;
				DateTime dataSelectata = DataProductiePicker.Value;

				Produs p = new Produs(codProdus, nume, pret, cantitate, dataSelectata, ingredienteSelectate);

				DataManager.Instance.AdaugaProdus(p);
				MessageBox.Show($"Ai adăugat: {p}");

				// Afișare în ListView
				
				var item = new ListViewItem(p.CodProdus.ToString());
				item.SubItems.Add(p.NumeProdus);
				item.SubItems.Add(p.Pret.ToString("0.00"));
				item.SubItems.Add(p.Cant.ToString("0.00"));
				item.SubItems.Add(p.DataProductie.ToShortDateString());
				item.SubItems.Add(string.Join(", ", p.ingrediente.Select(i => i.ToString())));

				ProduseLv.Items.Add(item);

				// Resetare
				NumeProdusTb.Clear();
				CodprodusTb.Clear();
				PretTb.Clear();
				CantitateTb.Clear();
				//listBoxIngrediente.Items.Clear();
				ingredienteSelectate.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Eroare: {ex.Message}");
			}
		}

		private void AdaugaIngredienteButton_Click(object sender, EventArgs e)
		{
			FormIngrediente form = new FormIngrediente();

			if (form.ShowDialog() == DialogResult.OK)
			{
				ingredienteSelectate = form.IngredienteSelectate;

				// Poți afișa în listă sau doar salva
				//listBoxIngrediente.Items.Clear();
				//foreach (var ing in ingredienteSelectate)
				//{
				//	listBoxIngrediente.Items.Add(ing.ToString());
				//}
			}

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
