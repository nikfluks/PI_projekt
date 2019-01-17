namespace RadionicaZaVozila
{
    partial class FrmNoviPopravak
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboRezervniDio = new System.Windows.Forms.ComboBox();
            this.rezervniDioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboVozilo = new System.Windows.Forms.ComboBox();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajRezervniDio = new System.Windows.Forms.Button();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumPopravka = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboZaposlenik = new System.Windows.Forms.ComboBox();
            this.dtZaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRadionicaVozila = new RadionicaZaVozila.dsRadionicaVozila();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKilometraza = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dgvPopisUsluga = new System.Windows.Forms.DataGridView();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaUslugeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtZaposlenikTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtZaposlenikTableAdapter();
            this.dgvPopisStavkiServisneKnjizice = new System.Windows.Forms.DataGridView();
            this.sifraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisnaKnjizicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katalogServisneKnjiziceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervniDioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtZaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisUsluga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaUslugeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisStavkiServisneKnjizice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogServisneKnjiziceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.4958F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.5042F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Controls.Add(this.comboRezervniDio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboVozilo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDodajRezervniDio, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDodajVozilo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpDatumPopravka, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboZaposlenik, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtKilometraza, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 253);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.31183F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.68817F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 209);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboRezervniDio
            // 
            this.comboRezervniDio.DataSource = this.rezervniDioBindingSource;
            this.comboRezervniDio.DisplayMember = "naziv";
            this.comboRezervniDio.FormattingEnabled = true;
            this.comboRezervniDio.Location = new System.Drawing.Point(94, 3);
            this.comboRezervniDio.Name = "comboRezervniDio";
            this.comboRezervniDio.Size = new System.Drawing.Size(121, 21);
            this.comboRezervniDio.TabIndex = 10;
            this.comboRezervniDio.ValueMember = "sifra";
            // 
            // rezervniDioBindingSource
            // 
            this.rezervniDioBindingSource.DataSource = typeof(RadionicaZaVozila.RezervniDio);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vozilo";
            // 
            // comboVozilo
            // 
            this.comboVozilo.DataSource = this.voziloBindingSource;
            this.comboVozilo.DisplayMember = "naziv";
            this.comboVozilo.FormattingEnabled = true;
            this.comboVozilo.Location = new System.Drawing.Point(94, 44);
            this.comboVozilo.Name = "comboVozilo";
            this.comboVozilo.Size = new System.Drawing.Size(121, 21);
            this.comboVozilo.TabIndex = 11;
            this.comboVozilo.ValueMember = "sifra";
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataSource = typeof(RadionicaZaVozila.Vozilo);
            // 
            // btnDodajRezervniDio
            // 
            this.btnDodajRezervniDio.Location = new System.Drawing.Point(233, 3);
            this.btnDodajRezervniDio.Name = "btnDodajRezervniDio";
            this.btnDodajRezervniDio.Size = new System.Drawing.Size(75, 23);
            this.btnDodajRezervniDio.TabIndex = 14;
            this.btnDodajRezervniDio.Text = "Dodaj";
            this.btnDodajRezervniDio.UseVisualStyleBackColor = true;
            this.btnDodajRezervniDio.Click += new System.EventHandler(this.btnDodajRezervniDio_Click);
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(233, 44);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(75, 23);
            this.btnDodajVozilo.TabIndex = 15;
            this.btnDodajVozilo.Text = "Dodaj";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rezervni dio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum popravka";
            // 
            // dtpDatumPopravka
            // 
            this.dtpDatumPopravka.Location = new System.Drawing.Point(94, 173);
            this.dtpDatumPopravka.Name = "dtpDatumPopravka";
            this.dtpDatumPopravka.Size = new System.Drawing.Size(121, 20);
            this.dtpDatumPopravka.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zaposlenik";
            // 
            // comboZaposlenik
            // 
            this.comboZaposlenik.DataSource = this.dtZaposlenikBindingSource;
            this.comboZaposlenik.DisplayMember = "PunoImePrezime";
            this.comboZaposlenik.Enabled = false;
            this.comboZaposlenik.FormattingEnabled = true;
            this.comboZaposlenik.Location = new System.Drawing.Point(94, 132);
            this.comboZaposlenik.Name = "comboZaposlenik";
            this.comboZaposlenik.Size = new System.Drawing.Size(121, 21);
            this.comboZaposlenik.TabIndex = 12;
            this.comboZaposlenik.ValueMember = "OIB";
            // 
            // dtZaposlenikBindingSource
            // 
            this.dtZaposlenikBindingSource.DataMember = "dtZaposlenik";
            this.dtZaposlenikBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // dsRadionicaVozila
            // 
            this.dsRadionicaVozila.DataSetName = "dsRadionicaVozila";
            this.dsRadionicaVozila.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kilometraža";
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(94, 89);
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(121, 20);
            this.txtKilometraza.TabIndex = 17;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(109, 490);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(121, 23);
            this.btnSpremi.TabIndex = 1;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // dgvPopisUsluga
            // 
            this.dgvPopisUsluga.AllowUserToAddRows = false;
            this.dgvPopisUsluga.AllowUserToDeleteRows = false;
            this.dgvPopisUsluga.AutoGenerateColumns = false;
            this.dgvPopisUsluga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisUsluga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.dgvPopisUsluga.DataSource = this.vrstaUslugeBindingSource;
            this.dgvPopisUsluga.Location = new System.Drawing.Point(12, 38);
            this.dgvPopisUsluga.Name = "dgvPopisUsluga";
            this.dgvPopisUsluga.ReadOnly = true;
            this.dgvPopisUsluga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisUsluga.Size = new System.Drawing.Size(345, 180);
            this.dgvPopisUsluga.TabIndex = 2;
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            this.sifraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstaUslugeBindingSource
            // 
            this.vrstaUslugeBindingSource.DataSource = typeof(RadionicaZaVozila.VrstaUsluge);
            // 
            // dtZaposlenikTableAdapter
            // 
            this.dtZaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // dgvPopisStavkiServisneKnjizice
            // 
            this.dgvPopisStavkiServisneKnjizice.AllowUserToAddRows = false;
            this.dgvPopisStavkiServisneKnjizice.AllowUserToDeleteRows = false;
            this.dgvPopisStavkiServisneKnjizice.AutoGenerateColumns = false;
            this.dgvPopisStavkiServisneKnjizice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisStavkiServisneKnjizice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.servisnaKnjizicaDataGridViewTextBoxColumn});
            this.dgvPopisStavkiServisneKnjizice.DataSource = this.katalogServisneKnjiziceBindingSource;
            this.dgvPopisStavkiServisneKnjizice.Location = new System.Drawing.Point(382, 38);
            this.dgvPopisStavkiServisneKnjizice.Name = "dgvPopisStavkiServisneKnjizice";
            this.dgvPopisStavkiServisneKnjizice.ReadOnly = true;
            this.dgvPopisStavkiServisneKnjizice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisStavkiServisneKnjizice.Size = new System.Drawing.Size(312, 217);
            this.dgvPopisStavkiServisneKnjizice.TabIndex = 3;
            // 
            // sifraDataGridViewTextBoxColumn1
            // 
            this.sifraDataGridViewTextBoxColumn1.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn1.HeaderText = "Šifra";
            this.sifraDataGridViewTextBoxColumn1.Name = "sifraDataGridViewTextBoxColumn1";
            this.sifraDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn1.Width = 150;
            // 
            // servisnaKnjizicaDataGridViewTextBoxColumn
            // 
            this.servisnaKnjizicaDataGridViewTextBoxColumn.DataPropertyName = "ServisnaKnjizica";
            this.servisnaKnjizicaDataGridViewTextBoxColumn.HeaderText = "ServisnaKnjizica";
            this.servisnaKnjizicaDataGridViewTextBoxColumn.Name = "servisnaKnjizicaDataGridViewTextBoxColumn";
            this.servisnaKnjizicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.servisnaKnjizicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // katalogServisneKnjiziceBindingSource
            // 
            this.katalogServisneKnjiziceBindingSource.DataSource = typeof(RadionicaZaVozila.KatalogServisneKnjizice);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dodavanje usluge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dodavanje stavke servisne knjižice";
            // 
            // FrmNoviPopravak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 536);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPopisStavkiServisneKnjizice);
            this.Controls.Add(this.dgvPopisUsluga);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmNoviPopravak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi popravak";
            this.Load += new System.EventHandler(this.FrmNoviPopravak_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmNoviPopravak_HelpRequested);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervniDioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtZaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisUsluga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaUslugeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisStavkiServisneKnjizice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogServisneKnjiziceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DataGridView dgvPopisUsluga;
        private System.Windows.Forms.BindingSource vrstaUslugeBindingSource;
        private System.Windows.Forms.ComboBox comboRezervniDio;
        private System.Windows.Forms.ComboBox comboVozilo;
        private System.Windows.Forms.ComboBox comboZaposlenik;
        private System.Windows.Forms.DateTimePicker dtpDatumPopravka;
        private System.Windows.Forms.BindingSource rezervniDioBindingSource;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private dsRadionicaVozila dsRadionicaVozila;
        private System.Windows.Forms.BindingSource dtZaposlenikBindingSource;
        private dsRadionicaVozilaTableAdapters.dtZaposlenikTableAdapter dtZaposlenikTableAdapter;
        private System.Windows.Forms.Button btnDodajRezervniDio;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvPopisStavkiServisneKnjizice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKilometraza;
        private System.Windows.Forms.BindingSource katalogServisneKnjiziceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisnaKnjizicaDataGridViewTextBoxColumn;
    }
}