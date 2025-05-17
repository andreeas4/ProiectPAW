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

		const int marg = 30;

		Graphics gr;

		Color culoare = Color.Blue;

		Font font = new Font(FontFamily.GenericSansSerif, 10);

		public FormStatistici()
		{
			InitializeComponent();
		}

		private void FormStatistici_Load(object sender, EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine($"FormStatistici_Load: Produse count: {DataManager.Instance.Produse.Count}");
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
				Rectangle dreptRosu = new Rectangle(
					panel1.ClientRectangle.X + marg,
					panel1.ClientRectangle.Y + 2 * marg,
					panel1.ClientRectangle.Width - 2 * marg,
					panel1.ClientRectangle.Height - 3 * marg);

				Pen pen = new Pen(Color.Black, 3); // Changed from Red to Black
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

				// Removed DrawLine loop to eliminate lines between bars
			}
		}

		private void incaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			costuriMedii.Clear();
			numeProduse.Clear();

			foreach (Produs p in DataManager.Instance.Produse)
			{
				p.CalculeazaCostProductie();
				costuriMedii.Add(p.CostMediu);
				numeProduse.Add(p.NumeProdus);
				System.Diagnostics.Debug.WriteLine($"Produs: {p.NumeProdus}, CostMediu: {p.CostMediu}");
			}

			vb = true;
			panel1.Invalidate();

			if (costuriMedii.Count == 0)
			{
				MessageBox.Show("Nu există produse pentru afișarea graficului. Adăugați produse mai întâi.", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void printToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				PrintDocument pd = new PrintDocument();
				pd.PrintPage += new PrintPageEventHandler(PrintGraphPage);
				PrintPreviewDialog preview = new PrintPreviewDialog();
				preview.Document = pd;
				preview.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Eroare la previzualizarea imprimării: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void PrintGraphPage(object sender, PrintPageEventArgs e)
		{
			// Capture panel1 as a bitmap
			Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
			panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));

			// Draw bitmap to printer graphics
			e.Graphics.DrawImage(bmp, e.MarginBounds);
			bmp.Dispose();
		}
	}
}
