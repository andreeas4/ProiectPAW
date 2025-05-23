﻿using ProiectPAW.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
		private void AfiseazaProdusInListView(Produs p)
		{
			p.CalculeazaCostProductie();
			double pretFinal = p.CalculeazaPretFinal(20);
			double costMediu = p.CostMediu;

			string ingredienteStr = p.ingrediente.Count > 0
				? string.Join(", ", p.ingrediente.Select(i => i.Materie.nume))
				: "Fără ingrediente";

			ListViewItem item = new ListViewItem(p.CodProdus.ToString());
			item.SubItems.Add(p.NumeProdus);
			item.SubItems.Add(p.Pret.ToString("0.00"));
			item.SubItems.Add(p.Cant.ToString("0.00"));
			item.SubItems.Add(p.DataProductie.ToShortDateString());
			item.SubItems.Add(ingredienteStr);
			item.SubItems.Add(pretFinal.ToString("0.00"));
			item.SubItems.Add(costMediu.ToString("0.00"));

			// Prevent duplicates by checking CodProdus
			if (!ProduseLv.Items.Cast<ListViewItem>().Any(i => i.Text == p.CodProdus.ToString()))
			{
				ProduseLv.Items.Add(item);
			}
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

			if (!double.TryParse(PretTb.Text, out double pret) || pret <= 0)
			{
				errorProvider1.SetError(PretTb, "Introduceți un preț valid!");
				valid = false;
			}

			if (!double.TryParse(CantitateTb.Text, out double cantitate) || cantitate <= 0)
			{
				errorProvider1.SetError(CantitateTb, "Introduceți o cantitate validă!");
				valid = false;
			}

			if (!valid)
				return;

			try
			{
				string nume = NumeProdusTb.Text;
				DateTime dataSelectata = DataProductiePicker.Value;

				Produs p = new Produs(codProdus, nume, pret, cantitate, dataSelectata, ingredienteSelectate);

				DataManager.Instance.AdaugaProdus(p);
				produse.Add(p);
				p.CalculeazaPretFinal(20);
				p.CalculeazaCostProductie();
				// Add only the new product to ListView
				AfiseazaProdusInListView(p);

				CalculPretFinalTb.Text = p.CalculeazaPretFinal(20).ToString("0.00");
				CostMediuTb.Text = p.CostMediu.ToString("0.00");

				MessageBox.Show($"Ai adăugat: {p}", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Clear input fields and ingredient lists
				NumeProdusTb.Clear();
				CodprodusTb.Clear();
				PretTb.Clear();
				CantitateTb.Clear();
				ingredienteSelectate.Clear();
				DataManager.Instance.IngredienteSelectate.Clear();

				System.Diagnostics.Debug.WriteLine($"Added Produs: {p.NumeProdus}, Cod: {p.CodProdus}");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AdaugaIngredienteButton_Click(object sender, EventArgs e)
		{
			FormIngrediente form = new FormIngrediente();

			if (form.ShowDialog() == DialogResult.OK)
			{
				ingredienteSelectate = DataManager.Instance.IngredienteSelectate;

			}

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void stergeProdusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ProduseLv.SelectedItems.Count > 0)
			{
				ListViewItem item = ProduseLv.SelectedItems[0];
				int codProdus = int.Parse(item.SubItems[0].Text);

				
				Produs produsDeSters = DataManager.Instance.Produse.FirstOrDefault(p => p.CodProdus == codProdus);


				if (produsDeSters != null)
					DataManager.Instance.Produse.Remove(produsDeSters);

				
				Produs localProdus = produse.FirstOrDefault(p => p.CodProdus == codProdus);
				if (localProdus != null)
					produse.Remove(localProdus);

				ProduseLv.Items.Remove(item);
			}
			else
			{
				MessageBox.Show("Selectați un produs din listă!(codul)");
			}
		}

		private void editareProdusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ProduseLv.SelectedItems.Count == 0)
			{
				MessageBox.Show("Selectați un produs pentru editare.");
				return;
			}

			var item = ProduseLv.SelectedItems[0];

			CodprodusTb.Text = item.SubItems[0].Text;
			NumeProdusTb.Text = item.SubItems[1].Text;
			PretTb.Text = item.SubItems[2].Text;
			CantitateTb.Text = item.SubItems[3].Text;
			DataProductiePicker.Value = DateTime.Parse(item.SubItems[4].Text);

			
			
			SalveazaModificariButton.Visible = true;
		}

		private void SalveazaModificariButton_Click(object sender, EventArgs e)
		{
			if (ProduseLv.SelectedItems.Count == 0)
			{
				MessageBox.Show("Selectează un produs pentru a-l edita.");
				return;
			}

			ListViewItem item = ProduseLv.SelectedItems[0];
			int codOriginal = int.Parse(item.SubItems[0].Text);

			Produs produs = produse.FirstOrDefault(p => p.CodProdus == codOriginal);
			if (produs == null) return;

		
			produs.NumeProdus = NumeProdusTb.Text;
			produs.Pret = double.Parse(PretTb.Text);
			produs.Cant = double.Parse(CantitateTb.Text);
			produs.DataProductie = DataProductiePicker.Value;

			
			Produs produsDM = DataManager.Instance.Produse.FirstOrDefault(p => p.CodProdus == codOriginal);
			if (produsDM != null)
			{
				produsDM.NumeProdus = produs.NumeProdus;
				produsDM.Pret = produs.Pret;
				produsDM.Cant = produs.Cant;
				produsDM.DataProductie = produs.DataProductie;
			}
			double pretFinal = produs.CalculeazaPretFinal(20);
			produs.CalculeazaCostProductie();
			double costMediu = produs.CostMediu;
			item.SubItems[1].Text = produs.NumeProdus;
			item.SubItems[2].Text = produs.Pret.ToString("0.00");
			item.SubItems[3].Text = produs.Cant.ToString();
			item.SubItems[4].Text = produs.DataProductie.ToShortDateString();
			item.SubItems[5].Text = pretFinal.ToString("0.00");
			item.SubItems[6].Text = costMediu.ToString("0.00");
			MessageBox.Show("Produsul a fost actualizat cu succes!");
		}

		private void FormProduse_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.S) // Ctrl + S
			{
				if (SalveazaModificariButton.Visible) // doar dacă butonul e vizibil
				{
					SalveazaModificariButton.PerformClick();
					e.Handled = true;
				}
			}
		}

		private void salveazaProduseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Salvează produsele";
			saveFileDialog.Filter = "Fișiere text (*.txt)|*.txt";
			saveFileDialog.FileName = "produse.txt"; // nume sugerat

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false))
					{
						sw.WriteLine("CodProdus;NumeProdus;Pret;Cantitate;DataProductie");

						foreach (Produs p in DataManager.Instance.Produse)
						{
							sw.WriteLine($"{p.CodProdus};{p.NumeProdus};{p.Pret};{p.Cant};{p.DataProductie.ToShortDateString()}");
						}
					}

					MessageBox.Show("Produsele au fost salvate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Eroare la salvarea fișierului:\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		private void CalculPretFinalTb_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void FormProduse_Load(object sender, EventArgs e)
		{

		}
	}
}
