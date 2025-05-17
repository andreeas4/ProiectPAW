using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace ProiectPAW.Forms
{
	public partial class FormStatistici : Form
	{
		List<double> costuriMedii = new List<double>();
		List<string> numeProduse = new List<string>();

		int nrElem = 0;

		bool vb = false;

		const int marg = 20;

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

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			gr = e.Graphics;

			if (vb && costuriMedii != null && costuriMedii.Count > 0 && e.Graphics != null)
			{
				Rectangle dreptRosu = new Rectangle(panel1.ClientRectangle.X + marg,
					panel1.ClientRectangle.Y + 2 * marg,
					panel1.ClientRectangle.Width - 2 * marg,
					panel1.ClientRectangle.Height - 3 * marg);

				Pen pen = new Pen(Color.Red, 3);
				gr.DrawRectangle(pen, dreptRosu);

				double latime = dreptRosu.Width / costuriMedii.Count / 2;
				double distanta = (dreptRosu.Width - costuriMedii.Count * latime) / (costuriMedii.Count + 1);
				double vMax = costuriMedii.Max();

				Brush br = new SolidBrush(culoare);
				Font f = font;

				Rectangle[] recs = new Rectangle[costuriMedii.Count];
				for (int i = 0; i < costuriMedii.Count; i++)
				{
					recs[i] = new Rectangle(
						(int)(dreptRosu.X + (i + 1) * distanta + i * latime),
						(int)(dreptRosu.Y + dreptRosu.Height - costuriMedii[i] / vMax * dreptRosu.Height),
						(int)latime,
						(int)(costuriMedii[i] / vMax * dreptRosu.Height));

					gr.FillRectangle(br, recs[i]);

					gr.DrawString($"{costuriMedii[i]:0.00}", f, Brushes.Black,
						recs[i].X, recs[i].Y - f.Height);

					gr.DrawString(numeProduse[i], f, Brushes.Black,
						recs[i].X, dreptRosu.Bottom + 5);
				}

				for (int i = 0; i < costuriMedii.Count - 1; i++)
				{
					gr.DrawLine(pen,
						new Point(recs[i].X + recs[i].Width / 2, recs[i].Y),
						new Point(recs[i + 1].X + recs[i + 1].Width / 2, recs[i + 1].Y));
				}
			}
		}

		private void incaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			costuriMedii.Clear();
			numeProduse.Clear();

			foreach (Produs p in DataManager.Instance.Produse)
			{
				p.CalculeazaCostProductie(); // asigură-te că e calculat
				costuriMedii.Add(p.CostMediu);
				numeProduse.Add(p.NumeProdus);
			}

			vb = true;
			panel1.Invalidate(); // redesenează graficul
		}

	}
}
