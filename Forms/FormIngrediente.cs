using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ProiectPAW.Forms
{
	public partial class FormIngrediente : Form
	{
		public List<IngredientProdus> IngredienteSelectate { get; private set; } = new List<IngredientProdus>();
		public FormIngrediente()
		{
			InitializeComponent();
		}
		
		

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnConfirm_Click_1(object sender, EventArgs e)
		{
			
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.IsNewRow) continue; // Sari peste rândul gol


				MessageBox.Show(row.Cells[0].Value.ToString());

				Materieprima materie = DataManager.HashMateriiPrime[row.Cells[0].Value.ToString()];



				if (materie == null)
				{
					MessageBox.Show("Selectați o materie primă validă.");
					return;
				}


				if (!double.TryParse(row.Cells[1].Value?.ToString(), out double cantitate))
				{
					MessageBox.Show("Introduceți o cantitate validă.");
					return;
				}
				IngredientProdus ingredient = new IngredientProdus(materie, cantitate);
				IngredienteSelectate.Add(ingredient);
				DataManager.Instance.AdaugaIngredient(ingredient);

			}
			
			this.DialogResult = DialogResult.OK;
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Ingrediente selectate:");

			foreach (var ing in DataManager.Instance.IngredienteSelectate)
			{
				sb.AppendLine($"- {ing.Materie.nume}: {ing.Cantitate} unități");
			}

			MessageBox.Show(sb.ToString(), "Listă Ingrediente", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		private void FormIngrediente_Load_1(object sender, EventArgs e)
		{
			var colMaterie = new DataGridViewComboBoxColumn
			{	HeaderText = "Materie Prima",
				DataSource = DataManager.Instance.MateriiPrime,
				DisplayMember = "Nume",
				ValueMember = null
			};
			
			
			dataGridView1.Columns.Add(colMaterie);

			DataGridViewTextBoxColumn colCant = new DataGridViewTextBoxColumn
			{
				HeaderText = "Cantitate",
				

			};
			
			dataGridView1.Columns.Add(colCant);

			
		}
	}
}
