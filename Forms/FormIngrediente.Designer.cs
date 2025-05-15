namespace ProiectPAW.Forms
{
	partial class FormIngrediente
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.MateriePrima = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Cantitate = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.btnConfirm = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MateriePrima,
            this.Cantitate});
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(300, 74);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// MateriePrima
			// 
			this.MateriePrima.HeaderText = "MateriePrima";
			this.MateriePrima.MinimumWidth = 6;
			this.MateriePrima.Name = "MateriePrima";
			this.MateriePrima.Width = 125;
			// 
			// Cantitate
			// 
			this.Cantitate.HeaderText = "Cantitate";
			this.Cantitate.MinimumWidth = 6;
			this.Cantitate.Name = "Cantitate";
			this.Cantitate.Width = 125;
			// 
			// btnConfirm
			// 
			this.btnConfirm.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirm.Location = new System.Drawing.Point(296, 148);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(135, 56);
			this.btnConfirm.TabIndex = 1;
			this.btnConfirm.Text = "Adauga";
			this.btnConfirm.UseVisualStyleBackColor = true;
			// 
			// FormIngrediente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(720, 280);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FormIngrediente";
			this.Text = "Ingrediente";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewComboBoxColumn MateriePrima;
		private System.Windows.Forms.DataGridViewComboBoxColumn Cantitate;
		private System.Windows.Forms.Button btnConfirm;
	}
}