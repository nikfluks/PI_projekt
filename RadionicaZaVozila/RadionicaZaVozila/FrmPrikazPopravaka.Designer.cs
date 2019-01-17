namespace RadionicaZaVozila
{
    partial class FrmPrikazPopravaka
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPrikazUslugaPoPopravku = new System.Windows.Forms.DataGridView();
            this.dtVrstaUslugeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRadionicaVozila = new RadionicaZaVozila.dsRadionicaVozila();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPrikazPopravaka = new System.Windows.Forms.DataGridView();
            this.dtPopravakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIzradiRacun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtVrstaUslugeTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtVrstaUslugeTableAdapter();
            this.dtPopravakTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtPopravakTableAdapter();
            this.dtKatalogServisneKnjiziceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtKatalogServisneKnjiziceTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtKatalogServisneKnjiziceTableAdapter();
            this.sifraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijednostKMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazUslugaPoPopravku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVrstaUslugeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazPopravaka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPopravakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKatalogServisneKnjiziceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 21);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj novi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPrikazUslugaPoPopravku
            // 
            this.dgvPrikazUslugaPoPopravku.AllowUserToAddRows = false;
            this.dgvPrikazUslugaPoPopravku.AllowUserToDeleteRows = false;
            this.dgvPrikazUslugaPoPopravku.AutoGenerateColumns = false;
            this.dgvPrikazUslugaPoPopravku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazUslugaPoPopravku.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.dgvPrikazUslugaPoPopravku.DataSource = this.dtVrstaUslugeBindingSource;
            this.dgvPrikazUslugaPoPopravku.Location = new System.Drawing.Point(12, 370);
            this.dgvPrikazUslugaPoPopravku.Name = "dgvPrikazUslugaPoPopravku";
            this.dgvPrikazUslugaPoPopravku.ReadOnly = true;
            this.dgvPrikazUslugaPoPopravku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikazUslugaPoPopravku.Size = new System.Drawing.Size(322, 150);
            this.dgvPrikazUslugaPoPopravku.TabIndex = 2;
            // 
            // dtVrstaUslugeBindingSource
            // 
            this.dtVrstaUslugeBindingSource.DataMember = "dtVrstaUsluge";
            this.dtVrstaUslugeBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // dsRadionicaVozila
            // 
            this.dsRadionicaVozila.DataSetName = "dsRadionicaVozila";
            this.dsRadionicaVozila.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prikaz popravaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prikaz usluga za odabrani popravak";
            // 
            // dgvPrikazPopravaka
            // 
            this.dgvPrikazPopravaka.AllowUserToAddRows = false;
            this.dgvPrikazPopravaka.AllowUserToDeleteRows = false;
            this.dgvPrikazPopravaka.AutoGenerateColumns = false;
            this.dgvPrikazPopravaka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazPopravaka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraDataGridViewTextBoxColumn,
            this.dioDataGridViewTextBoxColumn,
            this.autoDataGridViewTextBoxColumn,
            this.radnikDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn});
            this.dgvPrikazPopravaka.DataSource = this.dtPopravakBindingSource;
            this.dgvPrikazPopravaka.Location = new System.Drawing.Point(12, 87);
            this.dgvPrikazPopravaka.Name = "dgvPrikazPopravaka";
            this.dgvPrikazPopravaka.ReadOnly = true;
            this.dgvPrikazPopravaka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikazPopravaka.Size = new System.Drawing.Size(726, 229);
            this.dgvPrikazPopravaka.TabIndex = 5;
            this.dgvPrikazPopravaka.SelectionChanged += new System.EventHandler(this.dgvPrikazPopravaka_SelectionChanged);
            // 
            // dtPopravakBindingSource
            // 
            this.dtPopravakBindingSource.DataMember = "dtPopravak";
            this.dtPopravakBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // btnIzradiRacun
            // 
            this.btnIzradiRacun.Location = new System.Drawing.Point(111, 21);
            this.btnIzradiRacun.Name = "btnIzradiRacun";
            this.btnIzradiRacun.Size = new System.Drawing.Size(75, 23);
            this.btnIzradiRacun.TabIndex = 6;
            this.btnIzradiRacun.Text = "Izradi račun";
            this.btnIzradiRacun.UseVisualStyleBackColor = true;
            this.btnIzradiRacun.Click += new System.EventHandler(this.btnIzradiRacun_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraDataGridViewTextBoxColumn2,
            this.nazivDataGridViewTextBoxColumn1,
            this.vrijednostKMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dtKatalogServisneKnjiziceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(354, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(384, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prikaz stavki servisne knjižice za odabrani popravak";
            // 
            // dtVrstaUslugeTableAdapter
            // 
            this.dtVrstaUslugeTableAdapter.ClearBeforeFill = true;
            // 
            // dtPopravakTableAdapter
            // 
            this.dtPopravakTableAdapter.ClearBeforeFill = true;
            // 
            // dtKatalogServisneKnjiziceBindingSource
            // 
            this.dtKatalogServisneKnjiziceBindingSource.DataMember = "dtKatalogServisneKnjizice";
            this.dtKatalogServisneKnjiziceBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // dtKatalogServisneKnjiziceTableAdapter
            // 
            this.dtKatalogServisneKnjiziceTableAdapter.ClearBeforeFill = true;
            // 
            // sifraDataGridViewTextBoxColumn1
            // 
            this.sifraDataGridViewTextBoxColumn1.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn1.HeaderText = "Šifra";
            this.sifraDataGridViewTextBoxColumn1.Name = "sifraDataGridViewTextBoxColumn1";
            this.sifraDataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.cijenaDataGridViewTextBoxColumn.Width = 75;
            // 
            // sifraDataGridViewTextBoxColumn2
            // 
            this.sifraDataGridViewTextBoxColumn2.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn2.HeaderText = "Šifra";
            this.sifraDataGridViewTextBoxColumn2.Name = "sifraDataGridViewTextBoxColumn2";
            this.sifraDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn1.Width = 150;
            // 
            // vrijednostKMDataGridViewTextBoxColumn
            // 
            this.vrijednostKMDataGridViewTextBoxColumn.DataPropertyName = "vrijednostKM";
            this.vrijednostKMDataGridViewTextBoxColumn.HeaderText = "Kilometraža";
            this.vrijednostKMDataGridViewTextBoxColumn.Name = "vrijednostKMDataGridViewTextBoxColumn";
            this.vrijednostKMDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrijednostKMDataGridViewTextBoxColumn.Width = 85;
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "Sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            this.sifraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dioDataGridViewTextBoxColumn
            // 
            this.dioDataGridViewTextBoxColumn.DataPropertyName = "Dio";
            this.dioDataGridViewTextBoxColumn.HeaderText = "Dio";
            this.dioDataGridViewTextBoxColumn.Name = "dioDataGridViewTextBoxColumn";
            this.dioDataGridViewTextBoxColumn.ReadOnly = true;
            this.dioDataGridViewTextBoxColumn.Width = 150;
            // 
            // autoDataGridViewTextBoxColumn
            // 
            this.autoDataGridViewTextBoxColumn.DataPropertyName = "Auto";
            this.autoDataGridViewTextBoxColumn.HeaderText = "Auto";
            this.autoDataGridViewTextBoxColumn.Name = "autoDataGridViewTextBoxColumn";
            this.autoDataGridViewTextBoxColumn.ReadOnly = true;
            this.autoDataGridViewTextBoxColumn.Width = 150;
            // 
            // radnikDataGridViewTextBoxColumn
            // 
            this.radnikDataGridViewTextBoxColumn.DataPropertyName = "Radnik";
            this.radnikDataGridViewTextBoxColumn.HeaderText = "Radnik";
            this.radnikDataGridViewTextBoxColumn.Name = "radnikDataGridViewTextBoxColumn";
            this.radnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.radnikDataGridViewTextBoxColumn.Width = 150;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumDataGridViewTextBoxColumn.Width = 110;
            // 
            // FrmPrikazPopravaka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzradiRacun);
            this.Controls.Add(this.dgvPrikazPopravaka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPrikazUslugaPoPopravku);
            this.Controls.Add(this.btnDodaj);
            this.Name = "FrmPrikazPopravaka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz popravaka";
            this.Load += new System.EventHandler(this.FrmPrikazPopravaka_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmPrikazPopravaka_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazUslugaPoPopravku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVrstaUslugeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazPopravaka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPopravakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKatalogServisneKnjiziceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPrikazUslugaPoPopravku;
        private System.Windows.Forms.BindingSource dtVrstaUslugeBindingSource;
        private dsRadionicaVozila dsRadionicaVozila;
        private dsRadionicaVozilaTableAdapters.dtVrstaUslugeTableAdapter dtVrstaUslugeTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPrikazPopravaka;
        private System.Windows.Forms.BindingSource dtPopravakBindingSource;
        private dsRadionicaVozilaTableAdapters.dtPopravakTableAdapter dtPopravakTableAdapter;
        private System.Windows.Forms.Button btnIzradiRacun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource dtKatalogServisneKnjiziceBindingSource;
        private dsRadionicaVozilaTableAdapters.dtKatalogServisneKnjiziceTableAdapter dtKatalogServisneKnjiziceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijednostKMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
    }
}