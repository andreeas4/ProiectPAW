using ProiectPAW.BazaDeDate;
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
    public partial class MeniuGestiuneProductie : Form
    {
        public MeniuGestiuneProductie()
        {
            InitializeComponent();
        }

        private void MateriePrimaButton_Click(object sender, EventArgs e)
        {
            FormMateriePrima formMateriePrima = new FormMateriePrima();
            formMateriePrima.ShowDialog();
        }

        private void LotProduseButton_Click(object sender, EventArgs e)
        {
           

        }

        private void ProduseButton_Click(object sender, EventArgs e)
        { 
            FormProduse formProduse = new FormProduse();
            formProduse.ShowDialog();
        }

        private void meniu_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void StatisticiButton_Click(object sender, EventArgs e)
		{
			FormStatistici formStatistici = new FormStatistici();
			formStatistici.ShowDialog();
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImportaDate_Click(object sender, EventArgs e)
        {
            try
            {
                LegaturaBD.IncarcaMaterii();
                MessageBox.Show("Datele au fost încărcate din baza de date.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ExportaDate_Click(object sender, EventArgs e)
        {

            try
            {
                LegaturaBD.SalveazaTot();
                MessageBox.Show("Datele au fost salvate în baza de date.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
