namespace ProiectPAW
{
    partial class FormProduse
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitButton = new System.Windows.Forms.Button();
			this.AdaugaIngredienteButton = new System.Windows.Forms.Button();
			this.CodprodusTb = new System.Windows.Forms.TextBox();
			this.NumeProdusTb = new System.Windows.Forms.TextBox();
			this.CantitateTb = new System.Windows.Forms.TextBox();
			this.PretTb = new System.Windows.Forms.TextBox();
			this.DataProductiePicker = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.CalculPretFinalTb = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.AdaugaProdus = new System.Windows.Forms.Button();
			this.ProduseLv = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.panel1.Controls.Add(this.AdaugaProdus);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.CalculPretFinalTb);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.DataProductiePicker);
			this.panel1.Controls.Add(this.PretTb);
			this.panel1.Controls.Add(this.CantitateTb);
			this.panel1.Controls.Add(this.NumeProdusTb);
			this.panel1.Controls.Add(this.CodprodusTb);
			this.panel1.Controls.Add(this.AdaugaIngredienteButton);
			this.panel1.Location = new System.Drawing.Point(-2, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(470, 565);
			this.panel1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editareToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1163, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// editareToolStripMenuItem
			// 
			this.editareToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
			this.editareToolStripMenuItem.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold);
			this.editareToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
			this.editareToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
			this.editareToolStripMenuItem.Text = "Editare";
			// 
			// ExitButton
			// 
			this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ExitButton.Location = new System.Drawing.Point(1087, -2);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 30);
			this.ExitButton.TabIndex = 2;
			this.ExitButton.Text = "X";
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// AdaugaIngredienteButton
			// 
			this.AdaugaIngredienteButton.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold);
			this.AdaugaIngredienteButton.Location = new System.Drawing.Point(77, 309);
			this.AdaugaIngredienteButton.Name = "AdaugaIngredienteButton";
			this.AdaugaIngredienteButton.Size = new System.Drawing.Size(239, 50);
			this.AdaugaIngredienteButton.TabIndex = 0;
			this.AdaugaIngredienteButton.Text = "Adauga ingrediente";
			this.AdaugaIngredienteButton.UseVisualStyleBackColor = true;
			this.AdaugaIngredienteButton.Click += new System.EventHandler(this.AdaugaIngredienteButton_Click);
			// 
			// CodprodusTb
			// 
			this.CodprodusTb.Location = new System.Drawing.Point(168, 85);
			this.CodprodusTb.Name = "CodprodusTb";
			this.CodprodusTb.Size = new System.Drawing.Size(58, 22);
			this.CodprodusTb.TabIndex = 1;
			// 
			// NumeProdusTb
			// 
			this.NumeProdusTb.Location = new System.Drawing.Point(168, 126);
			this.NumeProdusTb.Name = "NumeProdusTb";
			this.NumeProdusTb.Size = new System.Drawing.Size(243, 22);
			this.NumeProdusTb.TabIndex = 2;
			// 
			// CantitateTb
			// 
			this.CantitateTb.Location = new System.Drawing.Point(168, 214);
			this.CantitateTb.Name = "CantitateTb";
			this.CantitateTb.Size = new System.Drawing.Size(58, 22);
			this.CantitateTb.TabIndex = 3;
			// 
			// PretTb
			// 
			this.PretTb.Location = new System.Drawing.Point(168, 167);
			this.PretTb.Name = "PretTb";
			this.PretTb.Size = new System.Drawing.Size(58, 22);
			this.PretTb.TabIndex = 4;
			// 
			// DataProductiePicker
			// 
			this.DataProductiePicker.Location = new System.Drawing.Point(168, 257);
			this.DataProductiePicker.Name = "DataProductiePicker";
			this.DataProductiePicker.Size = new System.Drawing.Size(243, 22);
			this.DataProductiePicker.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Console", 10.2F);
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(41, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Cod Produs";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Lucida Console", 10.2F);
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(33, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Nume Produs";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Lucida Console", 10.2F);
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(103, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Pret";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Lucida Console", 10.2F);
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(53, 217);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Cantitate";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Lucida Console", 10.2F);
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(3, 262);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "Data Productie";
			// 
			// CalculPretFinalTb
			// 
			this.CalculPretFinalTb.Location = new System.Drawing.Point(320, 389);
			this.CalculPretFinalTb.Name = "CalculPretFinalTb";
			this.CalculPretFinalTb.ReadOnly = true;
			this.CalculPretFinalTb.Size = new System.Drawing.Size(91, 22);
			this.CalculPretFinalTb.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Lucida Console", 10.2F);
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(14, 392);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(268, 17);
			this.label6.TabIndex = 12;
			this.label6.Text = "Pretul final al produsului";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// AdaugaProdus
			// 
			this.AdaugaProdus.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold);
			this.AdaugaProdus.Location = new System.Drawing.Point(77, 451);
			this.AdaugaProdus.Name = "AdaugaProdus";
			this.AdaugaProdus.Size = new System.Drawing.Size(239, 38);
			this.AdaugaProdus.TabIndex = 13;
			this.AdaugaProdus.Text = "Adauga";
			this.AdaugaProdus.UseVisualStyleBackColor = true;
			this.AdaugaProdus.Click += new System.EventHandler(this.AdaugaProdus_Click);
			// 
			// ProduseLv
			// 
			this.ProduseLv.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ProduseLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.ProduseLv.Font = new System.Drawing.Font("Cascadia Code", 7.8F);
			this.ProduseLv.HideSelection = false;
			this.ProduseLv.Location = new System.Drawing.Point(496, 56);
			this.ProduseLv.Name = "ProduseLv";
			this.ProduseLv.Size = new System.Drawing.Size(645, 389);
			this.ProduseLv.TabIndex = 3;
			this.ProduseLv.UseCompatibleStateImageBehavior = false;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Cod";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Nume";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Pret";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Cantitate";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Data";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Ingrediente";
			// 
			// FormProduse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1163, 679);
			this.Controls.Add(this.ProduseLv);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormProduse";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormProduse";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button AdaugaIngredienteButton;
		private System.Windows.Forms.TextBox PretTb;
		private System.Windows.Forms.TextBox CantitateTb;
		private System.Windows.Forms.TextBox NumeProdusTb;
		private System.Windows.Forms.TextBox CodprodusTb;
		private System.Windows.Forms.DateTimePicker DataProductiePicker;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox CalculPretFinalTb;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button AdaugaProdus;
		private System.Windows.Forms.ListView ProduseLv;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
	}
}