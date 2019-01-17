namespace RadionicaZaVozila
{
    partial class FrmPrikazVlasnikaVozila
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
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.dgvPopisKlijenata = new System.Windows.Forms.DataGridView();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRodenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postanskiBrojMjestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mjestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlasnikVozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisKlijenata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikVozilaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(21, 25);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(83, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj novog";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(136, 25);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(83, 23);
            this.btnIzmjeni.TabIndex = 1;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // dgvPopisKlijenata
            // 
            this.dgvPopisKlijenata.AllowUserToAddRows = false;
            this.dgvPopisKlijenata.AllowUserToDeleteRows = false;
            this.dgvPopisKlijenata.AutoGenerateColumns = false;
            this.dgvPopisKlijenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisKlijenata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oIBDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.datumRodenjaDataGridViewTextBoxColumn,
            this.spolDataGridViewTextBoxColumn,
            this.postanskiBrojMjestaDataGridViewTextBoxColumn,
            this.mjestoDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn});
            this.dgvPopisKlijenata.DataSource = this.vlasnikVozilaBindingSource;
            this.dgvPopisKlijenata.Location = new System.Drawing.Point(21, 83);
            this.dgvPopisKlijenata.Name = "dgvPopisKlijenata";
            this.dgvPopisKlijenata.ReadOnly = true;
            this.dgvPopisKlijenata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisKlijenata.Size = new System.Drawing.Size(651, 203);
            this.dgvPopisKlijenata.TabIndex = 3;
            this.dgvPopisKlijenata.SelectionChanged += new System.EventHandler(this.dgvPopisKlijenata_SelectionChanged);
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumRodenjaDataGridViewTextBoxColumn
            // 
            this.datumRodenjaDataGridViewTextBoxColumn.DataPropertyName = "datumRodenja";
            this.datumRodenjaDataGridViewTextBoxColumn.HeaderText = "Datum rođenja";
            this.datumRodenjaDataGridViewTextBoxColumn.Name = "datumRodenjaDataGridViewTextBoxColumn";
            this.datumRodenjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "Spol";
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            this.spolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postanskiBrojMjestaDataGridViewTextBoxColumn
            // 
            this.postanskiBrojMjestaDataGridViewTextBoxColumn.DataPropertyName = "postanskiBrojMjesta";
            this.postanskiBrojMjestaDataGridViewTextBoxColumn.DataSource = this.mjestoBindingSource;
            this.postanskiBrojMjestaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.postanskiBrojMjestaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.postanskiBrojMjestaDataGridViewTextBoxColumn.HeaderText = "Mjesto";
            this.postanskiBrojMjestaDataGridViewTextBoxColumn.Name = "postanskiBrojMjestaDataGridViewTextBoxColumn";
            this.postanskiBrojMjestaDataGridViewTextBoxColumn.ReadOnly = true;
            this.postanskiBrojMjestaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.postanskiBrojMjestaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.postanskiBrojMjestaDataGridViewTextBoxColumn.ValueMember = "postanskiBroj";
            // 
            // mjestoBindingSource
            // 
            this.mjestoBindingSource.DataSource = typeof(RadionicaZaVozila.Mjesto);
            // 
            // mjestoDataGridViewTextBoxColumn
            // 
            this.mjestoDataGridViewTextBoxColumn.DataPropertyName = "Mjesto";
            this.mjestoDataGridViewTextBoxColumn.HeaderText = "Mjesto";
            this.mjestoDataGridViewTextBoxColumn.Name = "mjestoDataGridViewTextBoxColumn";
            this.mjestoDataGridViewTextBoxColumn.ReadOnly = true;
            this.mjestoDataGridViewTextBoxColumn.Visible = false;
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "Vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "Vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.ReadOnly = true;
            this.voziloDataGridViewTextBoxColumn.Visible = false;
            // 
            // vlasnikVozilaBindingSource
            // 
            this.vlasnikVozilaBindingSource.DataSource = typeof(RadionicaZaVozila.VlasnikVozila);
            // 
            // FrmPrikazVlasnikaVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 298);
            this.Controls.Add(this.dgvPopisKlijenata);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnDodaj);
            this.Name = "FrmPrikazVlasnikaVozila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz vlasnika vozila";
            this.Load += new System.EventHandler(this.FrmPopisKlijenata_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmPrikazVlasnikaVozila_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisKlijenata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikVozilaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.DataGridView dgvPopisKlijenata;
        private System.Windows.Forms.BindingSource vlasnikVozilaBindingSource;
        private System.Windows.Forms.BindingSource mjestoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRodenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn postanskiBrojMjestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
    }
}