namespace RadionicaZaVozila
{
    partial class FrmPrikazIzvjestajaRacun
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtPodaciOZaposlenikuIAutoservisuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRadionicaVozila = new RadionicaZaVozila.dsRadionicaVozila();
            this.dtRezervniDioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtVrstaUslugeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtRacunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtVoziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izvjRacun = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtPodaciOZaposlenikuIAutoservisuTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtPodaciOZaposlenikuIAutoservisuTableAdapter();
            this.dtRezervniDioTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtRezervniDioTableAdapter();
            this.dtVrstaUslugeTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtVrstaUslugeTableAdapter();
            this.dtRacunTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtRacunTableAdapter();
            this.dtVoziloTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtVoziloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtPodaciOZaposlenikuIAutoservisuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRezervniDioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVrstaUslugeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRacunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVoziloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPodaciOZaposlenikuIAutoservisuBindingSource
            // 
            this.dtPodaciOZaposlenikuIAutoservisuBindingSource.DataMember = "dtPodaciOZaposlenikuIAutoservisu";
            this.dtPodaciOZaposlenikuIAutoservisuBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // dsRadionicaVozila
            // 
            this.dsRadionicaVozila.DataSetName = "dsRadionicaVozila";
            this.dsRadionicaVozila.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtRezervniDioBindingSource
            // 
            this.dtRezervniDioBindingSource.DataMember = "dtRezervniDio";
            this.dtRezervniDioBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // dtVrstaUslugeBindingSource
            // 
            this.dtVrstaUslugeBindingSource.DataMember = "dtVrstaUsluge";
            this.dtVrstaUslugeBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // dtRacunBindingSource
            // 
            this.dtRacunBindingSource.DataMember = "dtRacun";
            this.dtRacunBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // dtVoziloBindingSource
            // 
            this.dtVoziloBindingSource.DataMember = "dtVozilo";
            this.dtVoziloBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // izvjRacun
            // 
            this.izvjRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dsPodaciOAutoservisuIZaposleniku";
            reportDataSource1.Value = this.dtPodaciOZaposlenikuIAutoservisuBindingSource;
            reportDataSource2.Name = "dsPodaciORezernomDijelu";
            reportDataSource2.Value = this.dtRezervniDioBindingSource;
            reportDataSource3.Name = "dsVrstaUsluge";
            reportDataSource3.Value = this.dtVrstaUslugeBindingSource;
            reportDataSource4.Name = "dsRacun";
            reportDataSource4.Value = this.dtRacunBindingSource;
            reportDataSource5.Name = "dsVozilo";
            reportDataSource5.Value = this.dtVoziloBindingSource;
            this.izvjRacun.LocalReport.DataSources.Add(reportDataSource1);
            this.izvjRacun.LocalReport.DataSources.Add(reportDataSource2);
            this.izvjRacun.LocalReport.DataSources.Add(reportDataSource3);
            this.izvjRacun.LocalReport.DataSources.Add(reportDataSource4);
            this.izvjRacun.LocalReport.DataSources.Add(reportDataSource5);
            this.izvjRacun.LocalReport.ReportEmbeddedResource = "RadionicaZaVozila.izvjRacun.rdlc";
            this.izvjRacun.Location = new System.Drawing.Point(12, 12);
            this.izvjRacun.Name = "izvjRacun";
            this.izvjRacun.Size = new System.Drawing.Size(634, 347);
            this.izvjRacun.TabIndex = 0;
            // 
            // dtPodaciOZaposlenikuIAutoservisuTableAdapter
            // 
            this.dtPodaciOZaposlenikuIAutoservisuTableAdapter.ClearBeforeFill = true;
            // 
            // dtRezervniDioTableAdapter
            // 
            this.dtRezervniDioTableAdapter.ClearBeforeFill = true;
            // 
            // dtVrstaUslugeTableAdapter
            // 
            this.dtVrstaUslugeTableAdapter.ClearBeforeFill = true;
            // 
            // dtRacunTableAdapter
            // 
            this.dtRacunTableAdapter.ClearBeforeFill = true;
            // 
            // dtVoziloTableAdapter
            // 
            this.dtVoziloTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrikazIzvjestajaRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 371);
            this.Controls.Add(this.izvjRacun);
            this.Name = "FrmPrikazIzvjestajaRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz izvještaja za račun";
            this.Load += new System.EventHandler(this.FrmPrikazIzvjestajaRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPodaciOZaposlenikuIAutoservisuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRezervniDioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVrstaUslugeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRacunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVoziloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer izvjRacun;
        private System.Windows.Forms.BindingSource dtPodaciOZaposlenikuIAutoservisuBindingSource;
        private dsRadionicaVozila dsRadionicaVozila;
        private System.Windows.Forms.BindingSource dtRezervniDioBindingSource;
        private System.Windows.Forms.BindingSource dtVrstaUslugeBindingSource;
        private dsRadionicaVozilaTableAdapters.dtPodaciOZaposlenikuIAutoservisuTableAdapter dtPodaciOZaposlenikuIAutoservisuTableAdapter;
        private dsRadionicaVozilaTableAdapters.dtRezervniDioTableAdapter dtRezervniDioTableAdapter;
        private dsRadionicaVozilaTableAdapters.dtVrstaUslugeTableAdapter dtVrstaUslugeTableAdapter;
        private System.Windows.Forms.BindingSource dtRacunBindingSource;
        private dsRadionicaVozilaTableAdapters.dtRacunTableAdapter dtRacunTableAdapter;
        private System.Windows.Forms.BindingSource dtVoziloBindingSource;
        private dsRadionicaVozilaTableAdapters.dtVoziloTableAdapter dtVoziloTableAdapter;
    }
}