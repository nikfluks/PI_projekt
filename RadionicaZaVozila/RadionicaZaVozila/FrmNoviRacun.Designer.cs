namespace RadionicaZaVozila
{
    partial class FrmNoviRacun
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPopravak = new System.Windows.Forms.ComboBox();
            this.dtComboPopravakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRadionicaVozila = new RadionicaZaVozila.dsRadionicaVozila();
            this.comboZaposlenik = new System.Windows.Forms.ComboBox();
            this.dtZaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboAutoservis = new System.Windows.Forms.ComboBox();
            this.autoservisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dtComboPopravakTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtComboPopravakTableAdapter();
            this.dtZaposlenikTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtZaposlenikTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtComboPopravakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtZaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoservisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.18533F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.81467F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboPopravak, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboZaposlenik, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboAutoservis, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpDatum, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 37);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.35065F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.64935F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 202);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popravak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zaposlenik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autoservis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum";
            // 
            // comboPopravak
            // 
            this.comboPopravak.DataSource = this.dtComboPopravakBindingSource;
            this.comboPopravak.DisplayMember = "Podaci";
            this.comboPopravak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboPopravak.FormattingEnabled = true;
            this.comboPopravak.Location = new System.Drawing.Point(101, 4);
            this.comboPopravak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboPopravak.Name = "comboPopravak";
            this.comboPopravak.Size = new System.Drawing.Size(240, 24);
            this.comboPopravak.TabIndex = 4;
            this.comboPopravak.ValueMember = "SifraPopravka";
            // 
            // dtComboPopravakBindingSource
            // 
            this.dtComboPopravakBindingSource.DataMember = "dtComboPopravak";
            this.dtComboPopravakBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // dsRadionicaVozila
            // 
            this.dsRadionicaVozila.DataSetName = "dsRadionicaVozila";
            this.dsRadionicaVozila.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboZaposlenik
            // 
            this.comboZaposlenik.DataSource = this.dtZaposlenikBindingSource;
            this.comboZaposlenik.DisplayMember = "PunoImePrezime";
            this.comboZaposlenik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboZaposlenik.Enabled = false;
            this.comboZaposlenik.FormattingEnabled = true;
            this.comboZaposlenik.Location = new System.Drawing.Point(101, 55);
            this.comboZaposlenik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboZaposlenik.Name = "comboZaposlenik";
            this.comboZaposlenik.Size = new System.Drawing.Size(240, 24);
            this.comboZaposlenik.TabIndex = 5;
            this.comboZaposlenik.ValueMember = "OIB";
            // 
            // dtZaposlenikBindingSource
            // 
            this.dtZaposlenikBindingSource.DataMember = "dtZaposlenik";
            this.dtZaposlenikBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // comboAutoservis
            // 
            this.comboAutoservis.DataSource = this.autoservisBindingSource;
            this.comboAutoservis.DisplayMember = "naziv";
            this.comboAutoservis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboAutoservis.FormattingEnabled = true;
            this.comboAutoservis.Location = new System.Drawing.Point(101, 107);
            this.comboAutoservis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboAutoservis.Name = "comboAutoservis";
            this.comboAutoservis.Size = new System.Drawing.Size(240, 24);
            this.comboAutoservis.TabIndex = 6;
            this.comboAutoservis.ValueMember = "OIB";
            // 
            // autoservisBindingSource
            // 
            this.autoservisBindingSource.DataSource = typeof(RadionicaZaVozila.Autoservis);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDatum.Location = new System.Drawing.Point(101, 157);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(240, 22);
            this.dtpDatum.TabIndex = 7;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(255, 261);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(125, 28);
            this.btnSpremi.TabIndex = 1;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // dtComboPopravakTableAdapter
            // 
            this.dtComboPopravakTableAdapter.ClearBeforeFill = true;
            // 
            // dtZaposlenikTableAdapter
            // 
            this.dtZaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNoviRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 321);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmNoviRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi račun";
            this.Load += new System.EventHandler(this.FrmNoviRacun_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmNoviRacun_HelpRequested);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtComboPopravakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtZaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoservisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPopravak;
        private System.Windows.Forms.ComboBox comboZaposlenik;
        private System.Windows.Forms.ComboBox comboAutoservis;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnSpremi;
        private dsRadionicaVozila dsRadionicaVozila;
        private System.Windows.Forms.BindingSource dtComboPopravakBindingSource;
        private dsRadionicaVozilaTableAdapters.dtComboPopravakTableAdapter dtComboPopravakTableAdapter;
        private System.Windows.Forms.BindingSource dtZaposlenikBindingSource;
        private dsRadionicaVozilaTableAdapters.dtZaposlenikTableAdapter dtZaposlenikTableAdapter;
        private System.Windows.Forms.BindingSource autoservisBindingSource;
    }
}