namespace RadionicaZaVozila
{
    partial class FrmNoviVlasnikVozila
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDodajMjesto = new System.Windows.Forms.Button();
            this.comboMjesto = new System.Windows.Forms.ComboBox();
            this.mjestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.comboSpol = new System.Windows.Forms.ComboBox();
            this.dtpDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OIB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum rođenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mjesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Spol";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.48498F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.51502F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.Controls.Add(this.btnDodajMjesto, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboMjesto, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtIme, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPrezime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtOIB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboSpol, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpDatumRodenja, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.61728F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.38272F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(401, 268);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnDodajMjesto
            // 
            this.btnDodajMjesto.Location = new System.Drawing.Point(277, 224);
            this.btnDodajMjesto.Name = "btnDodajMjesto";
            this.btnDodajMjesto.Size = new System.Drawing.Size(75, 23);
            this.btnDodajMjesto.TabIndex = 7;
            this.btnDodajMjesto.Text = "Dodaj";
            this.btnDodajMjesto.UseVisualStyleBackColor = true;
            this.btnDodajMjesto.Click += new System.EventHandler(this.btnDodajMjesto_Click);
            // 
            // comboMjesto
            // 
            this.comboMjesto.DataSource = this.mjestoBindingSource;
            this.comboMjesto.DisplayMember = "naziv";
            this.comboMjesto.FormattingEnabled = true;
            this.comboMjesto.Location = new System.Drawing.Point(111, 224);
            this.comboMjesto.Name = "comboMjesto";
            this.comboMjesto.Size = new System.Drawing.Size(146, 21);
            this.comboMjesto.TabIndex = 6;
            this.comboMjesto.ValueMember = "postanskiBroj";
            // 
            // mjestoBindingSource
            // 
            this.mjestoBindingSource.DataSource = typeof(RadionicaZaVozila.Mjesto);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(111, 88);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(146, 20);
            this.txtIme.TabIndex = 3;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(111, 46);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(146, 20);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(111, 3);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(146, 20);
            this.txtOIB.TabIndex = 1;
            // 
            // comboSpol
            // 
            this.comboSpol.FormattingEnabled = true;
            this.comboSpol.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.comboSpol.Location = new System.Drawing.Point(111, 177);
            this.comboSpol.Name = "comboSpol";
            this.comboSpol.Size = new System.Drawing.Size(146, 21);
            this.comboSpol.TabIndex = 5;
            // 
            // dtpDatumRodenja
            // 
            this.dtpDatumRodenja.Location = new System.Drawing.Point(111, 131);
            this.dtpDatumRodenja.Name = "dtpDatumRodenja";
            this.dtpDatumRodenja.Size = new System.Drawing.Size(146, 20);
            this.dtpDatumRodenja.TabIndex = 4;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(157, 321);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(89, 23);
            this.btnSpremi.TabIndex = 7;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // FrmNoviVlasnikVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 369);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmNoviVlasnikVozila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi vlasnik vozila";
            this.Load += new System.EventHandler(this.FrmNoviKlijent_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmNoviVlasnikVozila_HelpRequested);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboMjesto;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.BindingSource mjestoBindingSource;
        private System.Windows.Forms.ComboBox comboSpol;
        private System.Windows.Forms.DateTimePicker dtpDatumRodenja;
        private System.Windows.Forms.Button btnDodajMjesto;
    }
}