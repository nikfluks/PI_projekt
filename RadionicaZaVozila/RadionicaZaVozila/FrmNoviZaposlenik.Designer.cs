namespace RadionicaZaVozila
{
    partial class FrmNoviZaposlenik
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
            this.lblOIB = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblDatumZaposlenja = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblPonovljena = new System.Windows.Forms.Label();
            this.lblMjesto = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPonovljena = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.btnDodajMjesto = new System.Windows.Forms.Button();
            this.btnSpremiZaposlenika = new System.Windows.Forms.Button();
            this.comboMjesto = new System.Windows.Forms.ComboBox();
            this.mjestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDatumZaposlenja = new System.Windows.Forms.DateTimePicker();
            this.comboAutoservis = new System.Windows.Forms.ComboBox();
            this.autoservisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAutoservis = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoservisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOIB.Location = new System.Drawing.Point(4, 0);
            this.lblOIB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(31, 38);
            this.lblOIB.TabIndex = 0;
            this.lblOIB.Text = "OIB";
            this.lblOIB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblIme.Location = new System.Drawing.Point(4, 38);
            this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 38);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";
            this.lblIme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPrezime.Location = new System.Drawing.Point(4, 76);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 38);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime";
            this.lblPrezime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatumZaposlenja
            // 
            this.lblDatumZaposlenja.AutoSize = true;
            this.lblDatumZaposlenja.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDatumZaposlenja.Location = new System.Drawing.Point(4, 152);
            this.lblDatumZaposlenja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatumZaposlenja.Name = "lblDatumZaposlenja";
            this.lblDatumZaposlenja.Size = new System.Drawing.Size(121, 41);
            this.lblDatumZaposlenja.TabIndex = 3;
            this.lblDatumZaposlenja.Text = "Datum zaposlenja";
            this.lblDatumZaposlenja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(544, 0);
            this.lblKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(99, 38);
            this.lblKorisnickoIme.TabIndex = 4;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            this.lblKorisnickoIme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLozinka.Location = new System.Drawing.Point(544, 38);
            this.lblLozinka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(57, 38);
            this.lblLozinka.TabIndex = 5;
            this.lblLozinka.Text = "Lozinka";
            this.lblLozinka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPonovljena
            // 
            this.lblPonovljena.AutoSize = true;
            this.lblPonovljena.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPonovljena.Location = new System.Drawing.Point(544, 76);
            this.lblPonovljena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPonovljena.Name = "lblPonovljena";
            this.lblPonovljena.Size = new System.Drawing.Size(126, 38);
            this.lblPonovljena.TabIndex = 6;
            this.lblPonovljena.Text = "Ponovljena lozinka";
            this.lblPonovljena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMjesto
            // 
            this.lblMjesto.AutoSize = true;
            this.lblMjesto.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMjesto.Location = new System.Drawing.Point(4, 114);
            this.lblMjesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMjesto.Name = "lblMjesto";
            this.lblMjesto.Size = new System.Drawing.Size(49, 38);
            this.lblMjesto.TabIndex = 7;
            this.lblMjesto.Text = "Mjesto";
            this.lblMjesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOIB
            // 
            this.txtOIB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOIB.Location = new System.Drawing.Point(163, 4);
            this.txtOIB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(151, 22);
            this.txtOIB.TabIndex = 8;
            // 
            // txtIme
            // 
            this.txtIme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIme.Location = new System.Drawing.Point(163, 42);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(151, 22);
            this.txtIme.TabIndex = 9;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrezime.Location = new System.Drawing.Point(163, 80);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(151, 22);
            this.txtPrezime.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.407407F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel1.Controls.Add(this.txtPonovljena, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblOIB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLozinka, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPrezime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtKorisnickoIme, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIme, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIme, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPrezime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtOIB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMjesto, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPonovljena, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDatumZaposlenja, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLozinka, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblKorisnickoIme, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDodajMjesto, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSpremiZaposlenika, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboMjesto, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpDatumZaposlenja, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboAutoservis, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAutoservis, 4, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 27);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 193);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // txtPonovljena
            // 
            this.txtPonovljena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPonovljena.Location = new System.Drawing.Point(703, 80);
            this.txtPonovljena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPonovljena.Name = "txtPonovljena";
            this.txtPonovljena.PasswordChar = '*';
            this.txtPonovljena.Size = new System.Drawing.Size(152, 22);
            this.txtPonovljena.TabIndex = 16;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLozinka.Location = new System.Drawing.Point(703, 42);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(152, 22);
            this.txtLozinka.TabIndex = 15;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(703, 4);
            this.txtKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(152, 22);
            this.txtKorisnickoIme.TabIndex = 14;
            // 
            // btnDodajMjesto
            // 
            this.btnDodajMjesto.Location = new System.Drawing.Point(322, 118);
            this.btnDodajMjesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajMjesto.Name = "btnDodajMjesto";
            this.btnDodajMjesto.Size = new System.Drawing.Size(100, 28);
            this.btnDodajMjesto.TabIndex = 17;
            this.btnDodajMjesto.Text = "Dodaj";
            this.btnDodajMjesto.UseVisualStyleBackColor = true;
            this.btnDodajMjesto.Click += new System.EventHandler(this.btnDodajMjesto_Click);
            // 
            // btnSpremiZaposlenika
            // 
            this.btnSpremiZaposlenika.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSpremiZaposlenika.Location = new System.Drawing.Point(755, 156);
            this.btnSpremiZaposlenika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpremiZaposlenika.Name = "btnSpremiZaposlenika";
            this.btnSpremiZaposlenika.Size = new System.Drawing.Size(100, 33);
            this.btnSpremiZaposlenika.TabIndex = 18;
            this.btnSpremiZaposlenika.Text = "Spremi";
            this.btnSpremiZaposlenika.UseVisualStyleBackColor = true;
            this.btnSpremiZaposlenika.Click += new System.EventHandler(this.btnSpremiZaposlenika_Click);
            // 
            // comboMjesto
            // 
            this.comboMjesto.DataSource = this.mjestoBindingSource;
            this.comboMjesto.DisplayMember = "naziv";
            this.comboMjesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboMjesto.FormattingEnabled = true;
            this.comboMjesto.Location = new System.Drawing.Point(163, 118);
            this.comboMjesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboMjesto.Name = "comboMjesto";
            this.comboMjesto.Size = new System.Drawing.Size(151, 24);
            this.comboMjesto.TabIndex = 19;
            this.comboMjesto.ValueMember = "postanskiBroj";
            // 
            // mjestoBindingSource
            // 
            this.mjestoBindingSource.DataSource = typeof(RadionicaZaVozila.Mjesto);
            // 
            // dtpDatumZaposlenja
            // 
            this.dtpDatumZaposlenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDatumZaposlenja.Location = new System.Drawing.Point(163, 156);
            this.dtpDatumZaposlenja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            this.dtpDatumZaposlenja.Size = new System.Drawing.Size(151, 22);
            this.dtpDatumZaposlenja.TabIndex = 20;
            // 
            // comboAutoservis
            // 
            this.comboAutoservis.DataSource = this.autoservisBindingSource;
            this.comboAutoservis.DisplayMember = "naziv";
            this.comboAutoservis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboAutoservis.FormattingEnabled = true;
            this.comboAutoservis.Location = new System.Drawing.Point(703, 118);
            this.comboAutoservis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboAutoservis.Name = "comboAutoservis";
            this.comboAutoservis.Size = new System.Drawing.Size(152, 24);
            this.comboAutoservis.TabIndex = 21;
            this.comboAutoservis.ValueMember = "OIB";
            // 
            // autoservisBindingSource
            // 
            this.autoservisBindingSource.DataSource = typeof(RadionicaZaVozila.Autoservis);
            // 
            // lblAutoservis
            // 
            this.lblAutoservis.AutoSize = true;
            this.lblAutoservis.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAutoservis.Location = new System.Drawing.Point(544, 114);
            this.lblAutoservis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutoservis.Name = "lblAutoservis";
            this.lblAutoservis.Size = new System.Drawing.Size(74, 38);
            this.lblAutoservis.TabIndex = 22;
            this.lblAutoservis.Text = "Autoservis";
            this.lblAutoservis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmNoviZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 250);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(927, 297);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(927, 297);
            this.Name = "FrmNoviZaposlenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi zaposlenik";
            this.Load += new System.EventHandler(this.FrmNoviZaposlenik_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmNoviZaposlenik_HelpRequested);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoservisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblDatumZaposlenja;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblPonovljena;
        private System.Windows.Forms.Label lblMjesto;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPonovljena;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Button btnDodajMjesto;
        private System.Windows.Forms.Button btnSpremiZaposlenika;
        private System.Windows.Forms.ComboBox comboMjesto;
        private System.Windows.Forms.DateTimePicker dtpDatumZaposlenja;
        private System.Windows.Forms.BindingSource mjestoBindingSource;
        private System.Windows.Forms.ComboBox comboAutoservis;
        private System.Windows.Forms.BindingSource autoservisBindingSource;
        private System.Windows.Forms.Label lblAutoservis;
    }
}