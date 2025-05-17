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
    public partial class FormLotFabricatie : Form

    {   List <LotFabricatie>loturi = new List<LotFabricatie>();
        List<Produs>produs = new List<Produs>();

		public FormLotFabricatie()
        {
            InitializeComponent();
        }

        private void FormLotFabricatie_Load(object sender, EventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void AdaugaLotButton_Click(object sender, EventArgs e)
		{

		}
	}
}
