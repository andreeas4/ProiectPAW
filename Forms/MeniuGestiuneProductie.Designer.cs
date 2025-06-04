namespace ProiectPAW
{
    partial class MeniuGestiuneProductie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeniuGestiuneProductie));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.meniu = new System.Windows.Forms.Label();
            this.MateriePrimaButton = new System.Windows.Forms.Button();
            this.ProduseButton = new System.Windows.Forms.Button();
            this.StatisticiButton = new System.Windows.Forms.Button();
            this.ImportaDate = new System.Windows.Forms.Button();
            this.ExportaDate = new System.Windows.Forms.Button();
            this.logo1 = new ProiectPAW.Logo();
            this.logo2 = new ProiectPAW.Logo();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.logo2);
            this.panel1.Controls.Add(this.logo1);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.meniu);
            this.panel1.Location = new System.Drawing.Point(-10, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 194);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(1149, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 41);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "x";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // meniu
            // 
            this.meniu.AutoSize = true;
            this.meniu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.meniu.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meniu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.meniu.Location = new System.Drawing.Point(332, 66);
            this.meniu.Name = "meniu";
            this.meniu.Size = new System.Drawing.Size(549, 75);
            this.meniu.TabIndex = 1;
            this.meniu.Text = "GESTIUNE PRODUCTIE";
            this.meniu.Click += new System.EventHandler(this.meniu_Click);
            // 
            // MateriePrimaButton
            // 
            this.MateriePrimaButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MateriePrimaButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.MateriePrimaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MateriePrimaButton.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MateriePrimaButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MateriePrimaButton.Location = new System.Drawing.Point(55, 303);
            this.MateriePrimaButton.Name = "MateriePrimaButton";
            this.MateriePrimaButton.Padding = new System.Windows.Forms.Padding(1);
            this.MateriePrimaButton.Size = new System.Drawing.Size(319, 111);
            this.MateriePrimaButton.TabIndex = 2;
            this.MateriePrimaButton.Text = "MATERIE PRIMA";
            this.MateriePrimaButton.UseVisualStyleBackColor = false;
            this.MateriePrimaButton.Click += new System.EventHandler(this.MateriePrimaButton_Click);
            // 
            // ProduseButton
            // 
            this.ProduseButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ProduseButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.ProduseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProduseButton.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProduseButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProduseButton.Location = new System.Drawing.Point(815, 303);
            this.ProduseButton.Name = "ProduseButton";
            this.ProduseButton.Padding = new System.Windows.Forms.Padding(1);
            this.ProduseButton.Size = new System.Drawing.Size(319, 111);
            this.ProduseButton.TabIndex = 4;
            this.ProduseButton.Text = "PRODUSE";
            this.ProduseButton.UseVisualStyleBackColor = false;
            this.ProduseButton.Click += new System.EventHandler(this.ProduseButton_Click);
            // 
            // StatisticiButton
            // 
            this.StatisticiButton.Font = new System.Drawing.Font("Impact", 19.8F);
            this.StatisticiButton.Location = new System.Drawing.Point(472, 311);
            this.StatisticiButton.Name = "StatisticiButton";
            this.StatisticiButton.Size = new System.Drawing.Size(259, 94);
            this.StatisticiButton.TabIndex = 5;
            this.StatisticiButton.Text = "Statistici";
            this.StatisticiButton.UseVisualStyleBackColor = true;
            this.StatisticiButton.Click += new System.EventHandler(this.StatisticiButton_Click);
            // 
            // ImportaDate
            // 
            this.ImportaDate.BackColor = System.Drawing.Color.MidnightBlue;
            this.ImportaDate.Font = new System.Drawing.Font("SimSun-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportaDate.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ImportaDate.Location = new System.Drawing.Point(265, 478);
            this.ImportaDate.Name = "ImportaDate";
            this.ImportaDate.Size = new System.Drawing.Size(271, 38);
            this.ImportaDate.TabIndex = 6;
            this.ImportaDate.Text = "Importa Date";
            this.ImportaDate.UseVisualStyleBackColor = false;
            this.ImportaDate.Click += new System.EventHandler(this.ImportaDate_Click);
            // 
            // ExportaDate
            // 
            this.ExportaDate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ExportaDate.Font = new System.Drawing.Font("SimSun-ExtB", 10.2F, System.Drawing.FontStyle.Bold);
            this.ExportaDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExportaDate.Location = new System.Drawing.Point(656, 476);
            this.ExportaDate.Name = "ExportaDate";
            this.ExportaDate.Size = new System.Drawing.Size(283, 40);
            this.ExportaDate.TabIndex = 7;
            this.ExportaDate.Text = "Exporta Date";
            this.ExportaDate.UseVisualStyleBackColor = false;
            this.ExportaDate.Click += new System.EventHandler(this.ExportaDate_Click);
            // 
            // logo1
            // 
            this.logo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo1.BackgroundImage")));
            this.logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo1.Location = new System.Drawing.Point(32, 75);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(109, 101);
            this.logo1.TabIndex = 3;
            // 
            // logo2
            // 
            this.logo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo2.BackgroundImage")));
            this.logo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo2.Location = new System.Drawing.Point(1064, 77);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(113, 99);
            this.logo2.TabIndex = 4;
            // 
            // MeniuGestiuneProductie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1191, 595);
            this.Controls.Add(this.ExportaDate);
            this.Controls.Add(this.ImportaDate);
            this.Controls.Add(this.StatisticiButton);
            this.Controls.Add(this.ProduseButton);
            this.Controls.Add(this.MateriePrimaButton);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeniuGestiuneProductie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuGestiuneProductie";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label meniu;
        private System.Windows.Forms.Button MateriePrimaButton;
        private System.Windows.Forms.Button ProduseButton;
        private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button StatisticiButton;
        private System.Windows.Forms.Button ImportaDate;
        private System.Windows.Forms.Button ExportaDate;
        private Logo logo2;
        private Logo logo1;
    }
}