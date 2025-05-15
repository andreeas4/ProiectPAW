namespace ProiectPAW
{
    partial class FormMateriePrima
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
			this.VascozitateLb = new System.Windows.Forms.Label();
			this.DensitateLb = new System.Windows.Forms.Label();
			this.vascozitateTb = new System.Windows.Forms.TextBox();
			this.densitateTb = new System.Windows.Forms.TextBox();
			this.AdaugaMateriePrima = new System.Windows.Forms.Button();
			this.umCb = new System.Windows.Forms.ComboBox();
			this.costLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.umlabel = new System.Windows.Forms.Label();
			this.Nume = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lichidRadioBox = new System.Windows.Forms.Label();
			this.solidRadioButton = new System.Windows.Forms.Label();
			this.LichidRb = new System.Windows.Forms.RadioButton();
			this.SolidRb = new System.Windows.Forms.RadioButton();
			this.costTb = new System.Windows.Forms.TextBox();
			this.numeTb = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.MateriiPrimeLb = new System.Windows.Forms.ListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Controls.Add(this.VascozitateLb);
			this.panel1.Controls.Add(this.DensitateLb);
			this.panel1.Controls.Add(this.vascozitateTb);
			this.panel1.Controls.Add(this.densitateTb);
			this.panel1.Controls.Add(this.AdaugaMateriePrima);
			this.panel1.Controls.Add(this.umCb);
			this.panel1.Controls.Add(this.costLabel);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.umlabel);
			this.panel1.Controls.Add(this.Nume);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.costTb);
			this.panel1.Controls.Add(this.numeTb);
			this.panel1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(-4, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(451, 571);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// VascozitateLb
			// 
			this.VascozitateLb.AutoSize = true;
			this.VascozitateLb.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.VascozitateLb.Location = new System.Drawing.Point(67, 325);
			this.VascozitateLb.Name = "VascozitateLb";
			this.VascozitateLb.Size = new System.Drawing.Size(106, 15);
			this.VascozitateLb.TabIndex = 14;
			this.VascozitateLb.Text = "Vascozitate";
			// 
			// DensitateLb
			// 
			this.DensitateLb.AutoSize = true;
			this.DensitateLb.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.DensitateLb.Location = new System.Drawing.Point(85, 325);
			this.DensitateLb.Name = "DensitateLb";
			this.DensitateLb.Size = new System.Drawing.Size(88, 15);
			this.DensitateLb.TabIndex = 13;
			this.DensitateLb.Text = "Densitate";
			// 
			// vascozitateTb
			// 
			this.vascozitateTb.Location = new System.Drawing.Point(186, 322);
			this.vascozitateTb.Name = "vascozitateTb";
			this.vascozitateTb.Size = new System.Drawing.Size(100, 22);
			this.vascozitateTb.TabIndex = 12;
			// 
			// densitateTb
			// 
			this.densitateTb.Location = new System.Drawing.Point(186, 322);
			this.densitateTb.Name = "densitateTb";
			this.densitateTb.Size = new System.Drawing.Size(100, 22);
			this.densitateTb.TabIndex = 11;
			// 
			// AdaugaMateriePrima
			// 
			this.AdaugaMateriePrima.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.AdaugaMateriePrima.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.AdaugaMateriePrima.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.AdaugaMateriePrima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.AdaugaMateriePrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AdaugaMateriePrima.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AdaugaMateriePrima.Location = new System.Drawing.Point(94, 424);
			this.AdaugaMateriePrima.Name = "AdaugaMateriePrima";
			this.AdaugaMateriePrima.Size = new System.Drawing.Size(298, 38);
			this.AdaugaMateriePrima.TabIndex = 9;
			this.AdaugaMateriePrima.Text = "Adauga";
			this.AdaugaMateriePrima.UseVisualStyleBackColor = false;
			this.AdaugaMateriePrima.Click += new System.EventHandler(this.AdaugaMateriePrima_Click);
			// 
			// umCb
			// 
			this.umCb.FormattingEnabled = true;
			this.umCb.Items.AddRange(new object[] {
            "mL",
            "L",
            "g",
            "kg"});
			this.umCb.Location = new System.Drawing.Point(186, 203);
			this.umCb.Name = "umCb";
			this.umCb.Size = new System.Drawing.Size(57, 23);
			this.umCb.TabIndex = 8;
			this.umCb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// costLabel
			// 
			this.costLabel.AutoSize = true;
			this.costLabel.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.costLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.costLabel.Location = new System.Drawing.Point(104, 268);
			this.costLabel.Name = "costLabel";
			this.costLabel.Size = new System.Drawing.Size(70, 15);
			this.costLabel.TabIndex = 7;
			this.costLabel.Text = "Cost/um";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(94, 264);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "label2";
			// 
			// umlabel
			// 
			this.umlabel.AutoSize = true;
			this.umlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.umlabel.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.umlabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.umlabel.Location = new System.Drawing.Point(133, 206);
			this.umlabel.Name = "umlabel";
			this.umlabel.Size = new System.Drawing.Size(28, 17);
			this.umlabel.TabIndex = 5;
			this.umlabel.Text = "UM";
			// 
			// Nume
			// 
			this.Nume.AutoSize = true;
			this.Nume.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Nume.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.Nume.Location = new System.Drawing.Point(115, 145);
			this.Nume.Name = "Nume";
			this.Nume.Size = new System.Drawing.Size(48, 17);
			this.Nume.TabIndex = 4;
			this.Nume.Text = "Nume";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lichidRadioBox);
			this.panel2.Controls.Add(this.solidRadioButton);
			this.panel2.Controls.Add(this.LichidRb);
			this.panel2.Controls.Add(this.SolidRb);
			this.panel2.Location = new System.Drawing.Point(94, 72);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(298, 47);
			this.panel2.TabIndex = 3;
			// 
			// lichidRadioBox
			// 
			this.lichidRadioBox.AutoSize = true;
			this.lichidRadioBox.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lichidRadioBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lichidRadioBox.Location = new System.Drawing.Point(137, 16);
			this.lichidRadioBox.Name = "lichidRadioBox";
			this.lichidRadioBox.Size = new System.Drawing.Size(46, 19);
			this.lichidRadioBox.TabIndex = 3;
			this.lichidRadioBox.Text = "Lichid";
			// 
			// solidRadioButton
			// 
			this.solidRadioButton.AutoSize = true;
			this.solidRadioButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.solidRadioButton.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.solidRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.solidRadioButton.Location = new System.Drawing.Point(38, 16);
			this.solidRadioButton.Name = "solidRadioButton";
			this.solidRadioButton.Size = new System.Drawing.Size(41, 19);
			this.solidRadioButton.TabIndex = 2;
			this.solidRadioButton.Text = "Solid";
			// 
			// LichidRb
			// 
			this.LichidRb.AutoSize = true;
			this.LichidRb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LichidRb.Location = new System.Drawing.Point(111, 13);
			this.LichidRb.Name = "LichidRb";
			this.LichidRb.Size = new System.Drawing.Size(135, 19);
			this.LichidRb.TabIndex = 1;
			this.LichidRb.Text = "radioButton2";
			this.LichidRb.UseVisualStyleBackColor = true;
			this.LichidRb.CheckedChanged += new System.EventHandler(this.LichidRb_CheckedChanged);
			// 
			// SolidRb
			// 
			this.SolidRb.AutoSize = true;
			this.SolidRb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.SolidRb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SolidRb.ForeColor = System.Drawing.Color.Black;
			this.SolidRb.Location = new System.Drawing.Point(13, 13);
			this.SolidRb.Name = "SolidRb";
			this.SolidRb.Size = new System.Drawing.Size(135, 19);
			this.SolidRb.TabIndex = 0;
			this.SolidRb.Text = "radioButton1";
			this.SolidRb.UseVisualStyleBackColor = false;
			this.SolidRb.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// costTb
			// 
			this.costTb.Location = new System.Drawing.Point(186, 265);
			this.costTb.Name = "costTb";
			this.costTb.Size = new System.Drawing.Size(228, 22);
			this.costTb.TabIndex = 2;
			// 
			// numeTb
			// 
			this.numeTb.Location = new System.Drawing.Point(186, 142);
			this.numeTb.Name = "numeTb";
			this.numeTb.Size = new System.Drawing.Size(228, 22);
			this.numeTb.TabIndex = 0;
			this.numeTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// MateriiPrimeLb
			// 
			this.MateriiPrimeLb.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.MateriiPrimeLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.MateriiPrimeLb.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MateriiPrimeLb.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.MateriiPrimeLb.FormattingEnabled = true;
			this.MateriiPrimeLb.HorizontalScrollbar = true;
			this.MateriiPrimeLb.ItemHeight = 17;
			this.MateriiPrimeLb.Location = new System.Drawing.Point(495, 41);
			this.MateriiPrimeLb.MultiColumn = true;
			this.MateriiPrimeLb.Name = "MateriiPrimeLb";
			this.MateriiPrimeLb.Size = new System.Drawing.Size(466, 493);
			this.MateriiPrimeLb.TabIndex = 1;
			this.MateriiPrimeLb.SelectedIndexChanged += new System.EventHandler(this.MateriiPrimeLb_SelectedIndexChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editareToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1088, 28);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
			// 
			// editareToolStripMenuItem
			// 
			this.editareToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.editareToolStripMenuItem.CheckOnClick = true;
			this.editareToolStripMenuItem.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editareToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
			this.editareToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
			this.editareToolStripMenuItem.Text = "Editare";
			this.editareToolStripMenuItem.MouseHover += new System.EventHandler(this.editareToolStripMenuItem_MouseHover);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlText;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(1011, -1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(77, 28);
			this.button1.TabIndex = 6;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormMateriePrima
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1088, 534);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.MateriiPrimeLb);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMateriePrima";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMateriePrima";
			this.Load += new System.EventHandler(this.FormMateriePrima_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox costTb;
        private System.Windows.Forms.TextBox numeTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label lichidRadioBox;
        private System.Windows.Forms.Label solidRadioButton;
        private System.Windows.Forms.RadioButton LichidRb;
        private System.Windows.Forms.RadioButton SolidRb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label umlabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.ComboBox umCb;
        private System.Windows.Forms.Button AdaugaMateriePrima;
        private System.Windows.Forms.Label VascozitateLb;
        private System.Windows.Forms.Label DensitateLb;
        private System.Windows.Forms.TextBox vascozitateTb;
        private System.Windows.Forms.TextBox densitateTb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox MateriiPrimeLb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
		private System.Windows.Forms.Button button1;
	}
}