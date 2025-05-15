using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProiectPAW
{
    public partial class FormMateriePrima : Form
    {
        List<Materieprima> materiiPrime = new List<Materieprima>();
        public FormMateriePrima()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMateriePrima_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (SolidRb.Checked)
            {
                
                VascozitateLb.Visible = false;
                vascozitateTb.Visible = false;
            }
            else
            {
                
                VascozitateLb.Visible = true;
                vascozitateTb.Visible = true;
            }
        }

        private void LichidRb_CheckedChanged(object sender, EventArgs e)
        {
            if (LichidRb.Checked)
            {
                
                DensitateLb.Visible = false;
                densitateTb.Visible = false;
            }
            else
            {
                
                DensitateLb.Visible = true;
                densitateTb.Visible = true;
            }
        }
       

        private void AdaugaMateriePrima_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(numeTb.Text))
            {
                errorProvider1.SetError(numeTb, "Introduceți numele!");
                valid = false;
            }

            if (!int.TryParse(costTb.Text, out int cost))
            {
                errorProvider1.SetError(costTb, "Introduceți un cost valid!");
                valid = false;
            }

            int densitate = 0, vascozitate = 0;

            if (SolidRb.Checked)
            {
                if (!int.TryParse(densitateTb.Text, out densitate))
                {
                    errorProvider1.SetError(densitateTb, "Introduceți o densitate validă!");
                    valid = false;
                }
            }

            if (LichidRb.Checked)
            {
                if (!int.TryParse(vascozitateTb.Text, out vascozitate))
                {
                    errorProvider1.SetError(vascozitateTb, "Introduceți o vâscozitate validă!");
                    valid = false;
                }
            }

            if (umCb.SelectedItem == null)
            {
                errorProvider1.SetError(umCb, "Alegeți unitatea de măsură!");
                valid = false;
            }

            if (!valid)
                return; // Ieșim dacă sunt erori

            try
            {
                string nume = numeTb.Text;
                string um = umCb.SelectedItem.ToString();
                Materieprima m;

                if (SolidRb.Checked)
                {
                    m = new MateriePrimaSolida(nume, um, cost, densitate);
                }
                else
                {
                    m = new MateriePrimaLichida(nume, um, cost, vascozitate);
                }

				DataManager.Instance.AdaugaMateriePrima(m);
				MessageBox.Show($"Ai adăugat: {m}");
                MateriiPrimeLb.Items.Add(m.ToString());

                // Curățăm câmpurile
                numeTb.Clear();
                costTb.Clear();
                densitateTb.Clear();
                vascozitateTb.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare: {ex.Message}");
            }

        }

        private void MateriiPrimeLb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void editareToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
