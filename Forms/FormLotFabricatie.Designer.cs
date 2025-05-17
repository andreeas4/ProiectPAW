namespace ProiectPAW
{
    partial class FormLotFabricatie
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salveazaLotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.idLotTb = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.AdaugaProduseButton = new System.Windows.Forms.Button();
			this.CantitatieTotalaTb = new System.Windows.Forms.TextBox();
			this.AdaugaLotButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.AdaugaLotButton);
			this.panel1.Controls.Add(this.CantitatieTotalaTb);
			this.panel1.Controls.Add(this.AdaugaProduseButton);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.idLotTb);
			this.panel1.Location = new System.Drawing.Point(-3, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(417, 715);
			this.panel1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new System.Drawing.Point(1099, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(63, 30);
			this.button1.TabIndex = 1;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1162, 25);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fisierToolStripMenuItem
			// 
			this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaLotToolStripMenuItem});
			this.fisierToolStripMenuItem.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold);
			this.fisierToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
			this.fisierToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
			this.fisierToolStripMenuItem.Text = "Fisier";
			// 
			// salveazaLotToolStripMenuItem
			// 
			this.salveazaLotToolStripMenuItem.Font = new System.Drawing.Font("Lucida Console", 9.2F, System.Drawing.FontStyle.Bold);
			this.salveazaLotToolStripMenuItem.Name = "salveazaLotToolStripMenuItem";
			this.salveazaLotToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.salveazaLotToolStripMenuItem.Text = "Salveaza lot";
			// 
			// idLotTb
			// 
			this.idLotTb.Location = new System.Drawing.Point(137, 95);
			this.idLotTb.Name = "idLotTb";
			this.idLotTb.Size = new System.Drawing.Size(82, 22);
			this.idLotTb.TabIndex = 0;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Lucida Console", 10.2F);
			this.dateTimePicker1.Location = new System.Drawing.Point(32, 201);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(340, 24);
			this.dateTimePicker1.TabIndex = 1;
			// 
			// AdaugaProduseButton
			// 
			this.AdaugaProduseButton.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold);
			this.AdaugaProduseButton.Location = new System.Drawing.Point(32, 270);
			this.AdaugaProduseButton.Name = "AdaugaProduseButton";
			this.AdaugaProduseButton.Size = new System.Drawing.Size(340, 45);
			this.AdaugaProduseButton.TabIndex = 2;
			this.AdaugaProduseButton.Text = "Adauga produse";
			this.AdaugaProduseButton.UseVisualStyleBackColor = true;
			// 
			// CantitatieTotalaTb
			// 
			this.CantitatieTotalaTb.Location = new System.Drawing.Point(256, 400);
			this.CantitatieTotalaTb.Name = "CantitatieTotalaTb";
			this.CantitatieTotalaTb.ReadOnly = true;
			this.CantitatieTotalaTb.Size = new System.Drawing.Size(100, 22);
			this.CantitatieTotalaTb.TabIndex = 3;
			// 
			// AdaugaLotButton
			// 
			this.AdaugaLotButton.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold);
			this.AdaugaLotButton.Location = new System.Drawing.Point(103, 486);
			this.AdaugaLotButton.Name = "AdaugaLotButton";
			this.AdaugaLotButton.Size = new System.Drawing.Size(168, 51);
			this.AdaugaLotButton.TabIndex = 4;
			this.AdaugaLotButton.Text = "Adauga";
			this.AdaugaLotButton.UseVisualStyleBackColor = true;
			this.AdaugaLotButton.Click += new System.EventHandler(this.AdaugaLotButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Console", 10.2F);
			this.label1.ForeColor = System.Drawing.Color.Teal;
			this.label1.Location = new System.Drawing.Point(75, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Lucida Console", 10.2F);
			this.label2.ForeColor = System.Drawing.Color.Teal;
			this.label2.Location = new System.Drawing.Point(15, 165);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Data Lot";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Lucida Console", 10.2F);
			this.label3.ForeColor = System.Drawing.Color.Teal;
			this.label3.Location = new System.Drawing.Point(51, 403);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Cantitate totala";
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.Teal;
			this.listView1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(483, 54);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(547, 484);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// FormLotFabricatie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(1162, 699);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormLotFabricatie";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormLotFabricatie";
			this.Load += new System.EventHandler(this.FormLotFabricatie_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salveazaLotToolStripMenuItem;
		private System.Windows.Forms.TextBox idLotTb;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button AdaugaProduseButton;
		private System.Windows.Forms.Button AdaugaLotButton;
		private System.Windows.Forms.TextBox CantitatieTotalaTb;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView listView1;
	}
}