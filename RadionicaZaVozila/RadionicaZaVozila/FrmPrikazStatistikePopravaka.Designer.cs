namespace RadionicaZaVozila
{
    partial class FrmPrikazStatistikePopravaka
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafickiPrikaz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.numGodina = new System.Windows.Forms.NumericUpDown();
            this.comboVozilo = new System.Windows.Forms.ComboBox();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dsRadionicaVozila = new RadionicaZaVozila.dsRadionicaVozila();
            this.dtStatistikaPopravkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtStatistikaPopravkaTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtStatistikaPopravkaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grafickiPrikaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGodina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStatistikaPopravkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grafickiPrikaz
            // 
            this.grafickiPrikaz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.grafickiPrikaz.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafickiPrikaz.Legends.Add(legend1);
            this.grafickiPrikaz.Location = new System.Drawing.Point(24, 87);
            this.grafickiPrikaz.Name = "grafickiPrikaz";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Kolicina";
            this.grafickiPrikaz.Series.Add(series1);
            this.grafickiPrikaz.Size = new System.Drawing.Size(550, 260);
            this.grafickiPrikaz.TabIndex = 0;
            this.grafickiPrikaz.Text = "chart1";
            this.grafickiPrikaz.Visible = false;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(338, 42);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // numGodina
            // 
            this.numGodina.Location = new System.Drawing.Point(24, 45);
            this.numGodina.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numGodina.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numGodina.Name = "numGodina";
            this.numGodina.Size = new System.Drawing.Size(120, 20);
            this.numGodina.TabIndex = 2;
            this.numGodina.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // comboVozilo
            // 
            this.comboVozilo.DataSource = this.voziloBindingSource;
            this.comboVozilo.DisplayMember = "naziv";
            this.comboVozilo.FormattingEnabled = true;
            this.comboVozilo.Location = new System.Drawing.Point(175, 44);
            this.comboVozilo.Name = "comboVozilo";
            this.comboVozilo.Size = new System.Drawing.Size(121, 21);
            this.comboVozilo.TabIndex = 3;
            this.comboVozilo.ValueMember = "sifra";
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataSource = typeof(RadionicaZaVozila.Vozilo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Godina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vozilo";
            // 
            // dsRadionicaVozila
            // 
            this.dsRadionicaVozila.DataSetName = "dsRadionicaVozila";
            this.dsRadionicaVozila.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtStatistikaPopravkaBindingSource
            // 
            this.dtStatistikaPopravkaBindingSource.DataMember = "dtStatistikaPopravka";
            this.dtStatistikaPopravkaBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // dtStatistikaPopravkaTableAdapter
            // 
            this.dtStatistikaPopravkaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrikazStatistikePopravaka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboVozilo);
            this.Controls.Add(this.numGodina);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.grafickiPrikaz);
            this.Name = "FrmPrikazStatistikePopravaka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz statistike popravaka";
            this.Load += new System.EventHandler(this.FrmPrikazStatistikePopravaka_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmPrikazStatistikePopravaka_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.grafickiPrikaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGodina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStatistikaPopravkaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafickiPrikaz;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.NumericUpDown numGodina;
        private System.Windows.Forms.ComboBox comboVozilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private dsRadionicaVozila dsRadionicaVozila;
        private System.Windows.Forms.BindingSource dtStatistikaPopravkaBindingSource;
        private dsRadionicaVozilaTableAdapters.dtStatistikaPopravkaTableAdapter dtStatistikaPopravkaTableAdapter;
    }
}