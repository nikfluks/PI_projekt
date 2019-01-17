namespace RadionicaZaVozila
{
    partial class FrmPrikazVozila
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
            this.btnDodavanjeVozila = new System.Windows.Forms.Button();
            this.btnIzmijeniVozilo = new System.Windows.Forms.Button();
            this.dtVoziloDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtVoziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRadionicaVozila = new RadionicaZaVozila.dsRadionicaVozila();
            this.dtVoziloTableAdapter = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.dtVoziloTableAdapter();
            this.tableAdapterManager = new RadionicaZaVozila.dsRadionicaVozilaTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dtVoziloDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVoziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodavanjeVozila
            // 
            this.btnDodavanjeVozila.Location = new System.Drawing.Point(13, 12);
            this.btnDodavanjeVozila.Name = "btnDodavanjeVozila";
            this.btnDodavanjeVozila.Size = new System.Drawing.Size(176, 23);
            this.btnDodavanjeVozila.TabIndex = 0;
            this.btnDodavanjeVozila.Text = "Dodaj novo vozilo";
            this.btnDodavanjeVozila.UseVisualStyleBackColor = true;
            this.btnDodavanjeVozila.Click += new System.EventHandler(this.btnDodavanjeVozila_Click);
            // 
            // btnIzmijeniVozilo
            // 
            this.btnIzmijeniVozilo.Location = new System.Drawing.Point(195, 12);
            this.btnIzmijeniVozilo.Name = "btnIzmijeniVozilo";
            this.btnIzmijeniVozilo.Size = new System.Drawing.Size(177, 23);
            this.btnIzmijeniVozilo.TabIndex = 1;
            this.btnIzmijeniVozilo.Text = "Izmijeni vozilo";
            this.btnIzmijeniVozilo.UseVisualStyleBackColor = true;
            this.btnIzmijeniVozilo.Click += new System.EventHandler(this.btnIzmijeniVozilo_Click);
            // 
            // dtVoziloDataGridView
            // 
            this.dtVoziloDataGridView.AllowUserToAddRows = false;
            this.dtVoziloDataGridView.AllowUserToDeleteRows = false;
            this.dtVoziloDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtVoziloDataGridView.AutoGenerateColumns = false;
            this.dtVoziloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVoziloDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtVoziloDataGridView.DataSource = this.dtVoziloBindingSource;
            this.dtVoziloDataGridView.Location = new System.Drawing.Point(13, 59);
            this.dtVoziloDataGridView.Name = "dtVoziloDataGridView";
            this.dtVoziloDataGridView.ReadOnly = true;
            this.dtVoziloDataGridView.Size = new System.Drawing.Size(544, 227);
            this.dtVoziloDataGridView.TabIndex = 3;
            this.dtVoziloDataGridView.SelectionChanged += new System.EventHandler(this.dtVoziloDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sifra";
            this.dataGridViewTextBoxColumn1.HeaderText = "Šifra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "godinaProizvodnje";
            this.dataGridViewTextBoxColumn3.HeaderText = "Godina proizvodnje";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "registracijskaOznaka";
            this.dataGridViewTextBoxColumn4.HeaderText = "Registracijska oznaka";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Vlasnik";
            this.dataGridViewTextBoxColumn5.HeaderText = "Vlasnik";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dtVoziloBindingSource
            // 
            this.dtVoziloBindingSource.DataMember = "dtVozilo";
            this.dtVoziloBindingSource.DataSource = this.dsRadionicaVozila;
            // 
            // dsRadionicaVozila
            // 
            this.dsRadionicaVozila.DataSetName = "dsRadionicaVozila";
            this.dsRadionicaVozila.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtVoziloTableAdapter
            // 
            this.dtVoziloTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dtComboPopravakTableAdapter = null;
            this.tableAdapterManager.dtPodaciOZaposlenikuIAutoservisuTableAdapter = null;
            this.tableAdapterManager.dtRezervniDioTableAdapter = null;
            this.tableAdapterManager.dtVlasnikVozilaIOIBTableAdapter = null;
            this.tableAdapterManager.dtVoziloTableAdapter = this.dtVoziloTableAdapter;
            this.tableAdapterManager.dtVrstaUslugeTableAdapter = null;
            this.tableAdapterManager.dtZaposlenikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RadionicaZaVozila.dsRadionicaVozilaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmPrikazVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 301);
            this.Controls.Add(this.dtVoziloDataGridView);
            this.Controls.Add(this.btnIzmijeniVozilo);
            this.Controls.Add(this.btnDodavanjeVozila);
            this.Name = "FrmPrikazVozila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz vozila";
            this.Load += new System.EventHandler(this.FrmPrikazVozila_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmPrikazVozila_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dtVoziloDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVoziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadionicaVozila)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodavanjeVozila;
        private System.Windows.Forms.Button btnIzmijeniVozilo;
        private dsRadionicaVozila dsRadionicaVozila;
        private System.Windows.Forms.BindingSource dtVoziloBindingSource;
        private dsRadionicaVozilaTableAdapters.dtVoziloTableAdapter dtVoziloTableAdapter;
        private dsRadionicaVozilaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dtVoziloDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}