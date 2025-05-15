using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
		
		private void btnConfirm_Click(object sender, EventArgs e)
		{
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnConfirm_Click_1(object sender, EventArgs e)
		{
			IngredienteSelectate.Clear();

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells["MateriePrima"].Value is Materieprima materie &&
					double.TryParse(Convert.ToString(row.Cells["Cantitate"].Value), out double cantitate) &&
					cantitate > 0)
				{
					IngredienteSelectate.Add(new IngredientProdus(materie, cantitate));
				}
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void FormIngrediente_Load_1(object sender, EventArgs e)
		{
			var colMaterie = new DataGridViewComboBoxColumn
			{
				HeaderText = "Materie Primă",
				Name = "MateriePrima",
				DataSource = DataManager.Instance.MateriiPrime,
				DisplayMember = "Nume",
				ValueMember = null // clasa directă
			};

			var colCant = new DataGridViewTextBoxColumn
			{
				HeaderText = "Cantitate",
				Name = "Cantitate"
			};

			dataGridView1.Columns.Add(colMaterie);
			dataGridView1.Columns.Add(colCant);
		}
	}
}
