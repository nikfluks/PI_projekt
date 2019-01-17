namespace RadionicaZaVozila
{
    partial class FrmNovoVozilo
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
            this.numGodinaProizvodnje = new System.Windows.Forms.NumericUpDown();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblGodinaProizvodnje = new System.Windows.Forms.Label();
            this.lblRegistracijskaOznaka = new System.Windows.Forms.Label();
            this.lblVlasnik = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtRegistracijskaOznaka = new System.Windows.Forms.TextBox();
            this.comboVlasniciVozila = new System.Windows.Forms.ComboBox();
            this.dtVlasnikVozilaIOIBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRadionicaVozila = new RadionicaZaVozila.dsRadionicaVozila();
            this.btnDodajNovogVlasnika = new System.Windows.Forms.Button();
            this.vlasnikVozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.dtVoziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtVoziloTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtVoziloTableAdapter();
            this.dtVlasnikVozilaIOIBTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtVlasnikVozilaIOIBTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGodinaProizvodnje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVlasnikVozilaIOIBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikVozilaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVoziloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel1.Controls.Add(this.numGodinaProizvodnje, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNaziv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGodinaProizvodnje, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRegistracijskaOznaka, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblVlasnik, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNaziv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRegistracijskaOznaka, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboVlasniciVozila, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDodajNovogVlasnika, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 34);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 172);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numGodinaProizvodnje
            // 
            this.numGodinaProizvodnje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGodinaProizvodnje.Location = new System.Drawing.Point(161, 47);
            this.numGodinaProizvodnje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numGodinaProizvodnje.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numGodinaProizvodnje.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numGodinaProizvodnje.Name = "numGodinaProizvodnje";
            this.numGodinaProizvodnje.Size = new System.Drawing.Size(227, 22);
            this.numGodinaProizvodnje.TabIndex = 10;
            this.numGodinaProizvodnje.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNaziv.Location = new System.Drawing.Point(4, 0);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(43, 43);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv";
            this.lblNaziv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGodinaProizvodnje
            // 
            this.lblGodinaProizvodnje.AutoSize = true;
            this.lblGodinaProizvodnje.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGodinaProizvodnje.Location = new System.Drawing.Point(4, 43);
            this.lblGodinaProizvodnje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            this.lblGodinaProizvodnje.Size = new System.Drawing.Size(131, 43);
            this.lblGodinaProizvodnje.TabIndex = 1;
            this.lblGodinaProizvodnje.Text = "Godina proizvodnje";
            this.lblGodinaProizvodnje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRegistracijskaOznaka
            // 
            this.lblRegistracijskaOznaka.AutoSize = true;
            this.lblRegistracijskaOznaka.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRegistracijskaOznaka.Location = new System.Drawing.Point(4, 86);
            this.lblRegistracijskaOznaka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistracijskaOznaka.Name = "lblRegistracijskaOznaka";
            this.lblRegistracijskaOznaka.Size = new System.Drawing.Size(146, 43);
            this.lblRegistracijskaOznaka.TabIndex = 2;
            this.lblRegistracijskaOznaka.Text = "Registracijska oznaka";
            this.lblRegistracijskaOznaka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVlasnik
            // 
            this.lblVlasnik.AutoSize = true;
            this.lblVlasnik.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblVlasnik.Location = new System.Drawing.Point(4, 129);
            this.lblVlasnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVlasnik.Name = "lblVlasnik";
            this.lblVlasnik.Size = new System.Drawing.Size(53, 43);
            this.lblVlasnik.TabIndex = 3;
            this.lblVlasnik.Text = "Vlasnik";
            this.lblVlasnik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNaziv.Location = new System.Drawing.Point(161, 4);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(227, 22);
            this.txtNaziv.TabIndex = 4;
            // 
            // txtRegistracijskaOznaka
            // 
            this.txtRegistracijskaOznaka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRegistracijskaOznaka.Location = new System.Drawing.Point(161, 90);
            this.txtRegistracijskaOznaka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegistracijskaOznaka.Name = "txtRegistracijskaOznaka";
            this.txtRegistracijskaOznaka.Size = new System.Drawing.Size(227, 22);
            this.txtRegistracijskaOznaka.TabIndex = 6;
            // 
            // comboVlasniciVozila
            // 
            this.comboVlasniciVozila.DataSource = this.dtVlasnikVozilaIOIBBindingSource;
            this.comboVlasniciVozila.DisplayMember = "PunoImeIPrezime";
            this.comboVlasniciVozila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboVlasniciVozila.FormattingEnabled = true;
            this.comboVlasniciVozila.Location = new System.Drawing.Point(161, 133);
            this.comboVlasniciVozila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboVlasniciVozila.Name = "comboVlasniciVozila";
            this.comboVlasniciVozila.Size = new System.Drawing.Size(227, 24);
            this.comboVlasniciVozila.TabIndex = 7;
            this.comboVlasniciVozila.ValueMember = "OIB";
            // 
            // dtVlasnikVozilaIOIBBindingSource
            // 
            this.dtVlasnikVozilaIOIBBindingSource.DataMember = "dtVlasnikVozilaIOIB";
            this.dtVlasnikVozilaIOIBBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // dsRadionicaVozila
            // 
            this.dsRadionicaVozila.DataSetName = "dsRadionicaVozila";
            this.dsRadionicaVozila.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDodajNovogVlasnika
            // 
            this.btnDodajNovogVlasnika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDodajNovogVlasnika.Location = new System.Drawing.Point(396, 133);
            this.btnDodajNovogVlasnika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajNovogVlasnika.Name = "btnDodajNovogVlasnika";
            this.btnDodajNovogVlasnika.Size = new System.Drawing.Size(164, 35);
            this.btnDodajNovogVlasnika.TabIndex = 8;
            this.btnDodajNovogVlasnika.Text = "Dodaj novog vlasnika";
            this.btnDodajNovogVlasnika.UseVisualStyleBackColor = true;
            this.btnDodajNovogVlasnika.Click += new System.EventHandler(this.btnDodajNovogVlasnika_Click);
            // 
            // vlasnikVozilaBindingSource
            // 
            this.vlasnikVozilaBindingSource.DataSource = typeof(RadionicaZaVozila.VlasnikVozila);
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(260, 226);
            this.btnDodajVozilo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(100, 28);
            this.btnDodajVozilo.TabIndex = 1;
            this.btnDodajVozilo.Text = "Dodaj";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // dtVoziloBindingSource
            // 
            this.dtVoziloBindingSource.DataMember = "dtVozilo";
            this.dtVoziloBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // dtVoziloTableAdapter
            // 
            this.dtVoziloTableAdapter.ClearBeforeFill = true;
            // 
            // dtVlasnikVozilaIOIBTableAdapter
            // 
            this.dtVlasnikVozilaIOIBTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNovoVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 288);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmNovoVozilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo vozilo";
            this.Load += new System.EventHandler(this.FrmNovoVozilo_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmNovoVozilo_HelpRequested);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGodinaProizvodnje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVlasnikVozilaIOIBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikVozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVoziloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblGodinaProizvodnje;
        private System.Windows.Forms.Label lblRegistracijskaOznaka;
        private System.Windows.Forms.Label lblVlasnik;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtRegistracijskaOznaka;
        private System.Windows.Forms.ComboBox comboVlasniciVozila;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.BindingSource vlasnikVozilaBindingSource;
        private dsRadionicaVozila dsRadionicaVozila;
        private System.Windows.Forms.BindingSource dtVoziloBindingSource;
        private dsRadionicaVozilaTableAdapters.dtVoziloTableAdapter dtVoziloTableAdapter;
        private System.Windows.Forms.BindingSource dtVlasnikVozilaIOIBBindingSource;
        private dsRadionicaVozilaTableAdapters.dtVlasnikVozilaIOIBTableAdapter dtVlasnikVozilaIOIBTableAdapter;
        private System.Windows.Forms.Button btnDodajNovogVlasnika;
        private System.Windows.Forms.NumericUpDown numGodinaProizvodnje;
    }
}