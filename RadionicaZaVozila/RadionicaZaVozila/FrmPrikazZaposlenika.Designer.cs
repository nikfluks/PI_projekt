namespace RadionicaZaVozila
{
    partial class FrmPrikazZaposlenika
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
            this.btnUredivanjePodataka = new System.Windows.Forms.Button();
            this.dsInformacijeZaposlenika = new RadionicaZaVozila.dsInformacijeZaposlenika();
            this.dtInformacijeZaposlenikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtInformacijeZaposlenikaTableAdapter = new RadionicaZaVozila.dsInformacijeZaposlenikaTableAdapters.dtInformacijeZaposlenikaTableAdapter();
            this.tableAdapterManager = new RadionicaZaVozila.dsInformacijeZaposlenikaTableAdapters.TableAdapterManager();
            this.dtInformacijeZaposlenikaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsInformacijeZaposlenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInformacijeZaposlenikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInformacijeZaposlenikaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUredivanjePodataka
            // 
            this.btnUredivanjePodataka.Location = new System.Drawing.Point(12, 12);
            this.btnUredivanjePodataka.Name = "btnUredivanjePodataka";
            this.btnUredivanjePodataka.Size = new System.Drawing.Size(100, 32);
            this.btnUredivanjePodataka.TabIndex = 1;
            this.btnUredivanjePodataka.Text = "Uredi svoj profil";
            this.btnUredivanjePodataka.UseVisualStyleBackColor = true;
            this.btnUredivanjePodataka.Click += new System.EventHandler(this.btnUredivanjePodataka_Click);
            // 
            // dsInformacijeZaposlenika
            // 
            this.dsInformacijeZaposlenika.DataSetName = "dsInformacijeZaposlenika";
            this.dsInformacijeZaposlenika.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtInformacijeZaposlenikaBindingSource
            // 
            this.dtInformacijeZaposlenikaBindingSource.DataMember = "dtInformacijeZaposlenika";
            this.dtInformacijeZaposlenikaBindingSource.DataSource = this.dsInformacijeZaposlenika;
            // 
            // dtInformacijeZaposlenikaTableAdapter
            // 
            this.dtInformacijeZaposlenikaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = RadionicaZaVozila.dsInformacijeZaposlenikaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dtInformacijeZaposlenikaDataGridView
            // 
            this.dtInformacijeZaposlenikaDataGridView.AllowUserToAddRows = false;
            this.dtInformacijeZaposlenikaDataGridView.AllowUserToDeleteRows = false;
            this.dtInformacijeZaposlenikaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtInformacijeZaposlenikaDataGridView.AutoGenerateColumns = false;
            this.dtInformacijeZaposlenikaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInformacijeZaposlenikaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dtInformacijeZaposlenikaDataGridView.DataSource = this.dtInformacijeZaposlenikaBindingSource;
            this.dtInformacijeZaposlenikaDataGridView.Location = new System.Drawing.Point(12, 63);
            this.dtInformacijeZaposlenikaDataGridView.Name = "dtInformacijeZaposlenikaDataGridView";
            this.dtInformacijeZaposlenikaDataGridView.ReadOnly = true;
            this.dtInformacijeZaposlenikaDataGridView.Size = new System.Drawing.Size(744, 312);
            this.dtInformacijeZaposlenikaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OIB";
            this.dataGridViewTextBoxColumn1.HeaderText = "OIB";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "datumZaposlenja";
            this.dataGridViewTextBoxColumn4.HeaderText = "Datum zaposlenja";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "korisnickoIme";
            this.dataGridViewTextBoxColumn5.HeaderText = "Korisnicko ime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "naziv";
            this.dataGridViewTextBoxColumn6.HeaderText = "Prebivalište";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "naziv1";
            this.dataGridViewTextBoxColumn7.HeaderText = "Autoservis";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // FrmPrikazZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 387);
            this.Controls.Add(this.dtInformacijeZaposlenikaDataGridView);
            this.Controls.Add(this.btnUredivanjePodataka);
            this.Name = "FrmPrikazZaposlenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz zaposlenika";
            this.Load += new System.EventHandler(this.FrmPrikazZaposlenika_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmPrikazZaposlenika_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dsInformacijeZaposlenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInformacijeZaposlenikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInformacijeZaposlenikaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUredivanjePodataka;
        private dsInformacijeZaposlenika dsInformacijeZaposlenika;
        private System.Windows.Forms.BindingSource dtInformacijeZaposlenikaBindingSource;
        private dsInformacijeZaposlenikaTableAdapters.dtInformacijeZaposlenikaTableAdapter dtInformacijeZaposlenikaTableAdapter;
        private dsInformacijeZaposlenikaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dtInformacijeZaposlenikaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}