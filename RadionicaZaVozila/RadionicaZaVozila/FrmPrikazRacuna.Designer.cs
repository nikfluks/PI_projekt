namespace RadionicaZaVozila
{
    partial class FrmPrikazRacuna
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
            this.dgvPrikazRacuna = new System.Windows.Forms.DataGridView();
            this.sifraRacunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podaciOPopravkuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRacunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivAutoservisaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podaciOZaposlenikuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRacunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRadionicaVozila = new RadionicaZaVozila.dsRadionicaVozila();
            this.btnNoviRacun = new System.Windows.Forms.Button();
            this.dtRacunTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtRacunTableAdapter();
            this.btnIzradiIzvjestaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRacunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrikazRacuna
            // 
            this.dgvPrikazRacuna.AllowUserToAddRows = false;
            this.dgvPrikazRacuna.AllowUserToDeleteRows = false;
            this.dgvPrikazRacuna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrikazRacuna.AutoGenerateColumns = false;
            this.dgvPrikazRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazRacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraRacunaDataGridViewTextBoxColumn,
            this.podaciOPopravkuDataGridViewTextBoxColumn,
            this.datumRacunaDataGridViewTextBoxColumn,
            this.nazivAutoservisaDataGridViewTextBoxColumn,
            this.podaciOZaposlenikuDataGridViewTextBoxColumn});
            this.dgvPrikazRacuna.DataSource = this.dtRacunBindingSource;
            this.dgvPrikazRacuna.Location = new System.Drawing.Point(12, 53);
            this.dgvPrikazRacuna.Name = "dgvPrikazRacuna";
            this.dgvPrikazRacuna.ReadOnly = true;
            this.dgvPrikazRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikazRacuna.Size = new System.Drawing.Size(550, 230);
            this.dgvPrikazRacuna.TabIndex = 0;
            // 
            // sifraRacunaDataGridViewTextBoxColumn
            // 
            this.sifraRacunaDataGridViewTextBoxColumn.DataPropertyName = "SifraRacuna";
            this.sifraRacunaDataGridViewTextBoxColumn.HeaderText = "Šifra računa";
            this.sifraRacunaDataGridViewTextBoxColumn.Name = "sifraRacunaDataGridViewTextBoxColumn";
            this.sifraRacunaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // podaciOPopravkuDataGridViewTextBoxColumn
            // 
            this.podaciOPopravkuDataGridViewTextBoxColumn.DataPropertyName = "PodaciOPopravku";
            this.podaciOPopravkuDataGridViewTextBoxColumn.HeaderText = "Popravak";
            this.podaciOPopravkuDataGridViewTextBoxColumn.Name = "podaciOPopravkuDataGridViewTextBoxColumn";
            this.podaciOPopravkuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumRacunaDataGridViewTextBoxColumn
            // 
            this.datumRacunaDataGridViewTextBoxColumn.DataPropertyName = "DatumRacuna";
            this.datumRacunaDataGridViewTextBoxColumn.HeaderText = "Datum računa";
            this.datumRacunaDataGridViewTextBoxColumn.Name = "datumRacunaDataGridViewTextBoxColumn";
            this.datumRacunaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivAutoservisaDataGridViewTextBoxColumn
            // 
            this.nazivAutoservisaDataGridViewTextBoxColumn.DataPropertyName = "NazivAutoservisa";
            this.nazivAutoservisaDataGridViewTextBoxColumn.HeaderText = "Naziv autoservisa";
            this.nazivAutoservisaDataGridViewTextBoxColumn.Name = "nazivAutoservisaDataGridViewTextBoxColumn";
            this.nazivAutoservisaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // podaciOZaposlenikuDataGridViewTextBoxColumn
            // 
            this.podaciOZaposlenikuDataGridViewTextBoxColumn.DataPropertyName = "PodaciOZaposleniku";
            this.podaciOZaposlenikuDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.podaciOZaposlenikuDataGridViewTextBoxColumn.Name = "podaciOZaposlenikuDataGridViewTextBoxColumn";
            this.podaciOZaposlenikuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtRacunBindingSource
            // 
            this.dtRacunBindingSource.DataMember = "dtRacun";
            this.dtRacunBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // dsRadionicaVozila
            // 
            this.dsRadionicaVozila.DataSetName = "dsRadionicaVozila";
            this.dsRadionicaVozila.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNoviRacun
            // 
            this.btnNoviRacun.Location = new System.Drawing.Point(12, 12);
            this.btnNoviRacun.Name = "btnNoviRacun";
            this.btnNoviRacun.Size = new System.Drawing.Size(150, 23);
            this.btnNoviRacun.TabIndex = 1;
            this.btnNoviRacun.Text = "Kreiraj novi račun";
            this.btnNoviRacun.UseVisualStyleBackColor = true;
            this.btnNoviRacun.Click += new System.EventHandler(this.btnNoviRacun_Click);
            // 
            // dtRacunTableAdapter
            // 
            this.dtRacunTableAdapter.ClearBeforeFill = true;
            // 
            // btnIzradiIzvjestaj
            // 
            this.btnIzradiIzvjestaj.Location = new System.Drawing.Point(197, 12);
            this.btnIzradiIzvjestaj.Name = "btnIzradiIzvjestaj";
            this.btnIzradiIzvjestaj.Size = new System.Drawing.Size(96, 23);
            this.btnIzradiIzvjestaj.TabIndex = 2;
            this.btnIzradiIzvjestaj.Text = "Izradi izvještaj";
            this.btnIzradiIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzradiIzvjestaj.Click += new System.EventHandler(this.btnIzradiIzvjestaj_Click);
            // 
            // FrmPrikazRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 300);
            this.Controls.Add(this.btnIzradiIzvjestaj);
            this.Controls.Add(this.btnNoviRacun);
            this.Controls.Add(this.dgvPrikazRacuna);
            this.Name = "FrmPrikazRacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz računa";
            this.Load += new System.EventHandler(this.FrmPrikazRacuna_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmPrikazRacuna_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRacunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikazRacuna;
        private System.Windows.Forms.Button btnNoviRacun;
        private dsRadionicaVozila dsRadionicaVozila;
        private System.Windows.Forms.BindingSource dtRacunBindingSource;
        private dsRadionicaVozilaTableAdapters.dtRacunTableAdapter dtRacunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraRacunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podaciOPopravkuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRacunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivAutoservisaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podaciOZaposlenikuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnIzradiIzvjestaj;
    }
}