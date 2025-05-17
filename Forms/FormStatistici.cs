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
	public partial class FormStatistici : Form
	{
		double[] vect = new double[30];
		int nrElem = 0;

		bool vb = false;

		const int marg = 10;

		Graphics gr;

		Color culoare = Color.Blue;

		Font font = new Font(FontFamily.GenericSansSerif, 12);

		public FormStatistici()
		{
			InitializeComponent();
		}

		private void FormStatistici_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
