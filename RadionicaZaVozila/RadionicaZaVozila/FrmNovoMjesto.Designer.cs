namespace RadionicaZaVozila
{
    partial class FrmNovoMjesto
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
            if(disposing && (components != null))
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
            this.lblPostanskiBroj = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPostanskiBroj = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnDodajMjesto = new System.Windows.Forms.Button();
            this.btnPrikazSvihMjesta = new System.Windows.Forms.Button();
            this.mjestoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSvaMjesta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPostanskiBroj
            // 
            this.lblPostanskiBroj.AutoSize = true;
            this.lblPostanskiBroj.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPostanskiBroj.Location = new System.Drawing.Point(4, 0);
            this.lblPostanskiBroj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostanskiBroj.Name = "lblPostanskiBroj";
            this.lblPostanskiBroj.Size = new System.Drawing.Size(97, 35);
            this.lblPostanskiBroj.TabIndex = 0;
            this.lblPostanskiBroj.Text = "Poštanski broj";
            this.lblPostanskiBroj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNaziv.Location = new System.Drawing.Point(4, 35);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(43, 35);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv";
            this.lblNaziv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.78802F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.21198F));
            this.tableLayoutPanel1.Controls.Add(this.lblPostanskiBroj, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNaziv, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPostanskiBroj, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNaziv, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 91);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(312, 70);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtPostanskiBroj
            // 
            this.txtPostanskiBroj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPostanskiBroj.Location = new System.Drawing.Point(121, 4);
            this.txtPostanskiBroj.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostanskiBroj.Name = "txtPostanskiBroj";
            this.txtPostanskiBroj.Size = new System.Drawing.Size(187, 22);
            this.txtPostanskiBroj.TabIndex = 2;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNaziv.Location = new System.Drawing.Point(121, 39);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(187, 22);
            this.txtNaziv.TabIndex = 3;
            // 
            // btnDodajMjesto
            // 
            this.btnDodajMjesto.Location = new System.Drawing.Point(155, 180);
            this.btnDodajMjesto.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajMjesto.Name = "btnDodajMjesto";
            this.btnDodajMjesto.Size = new System.Drawing.Size(187, 28);
            this.btnDodajMjesto.TabIndex = 3;
            this.btnDodajMjesto.Text = "Dodaj";
            this.btnDodajMjesto.UseVisualStyleBackColor = true;
            this.btnDodajMjesto.Click += new System.EventHandler(this.btnDodajMjesto_Click);
            // 
            // btnPrikazSvihMjesta
            // 
            this.btnPrikazSvihMjesta.Location = new System.Drawing.Point(155, 15);
            this.btnPrikazSvihMjesta.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikazSvihMjesta.Name = "btnPrikazSvihMjesta";
            this.btnPrikazSvihMjesta.Size = new System.Drawing.Size(187, 28);
            this.btnPrikazSvihMjesta.TabIndex = 4;
            this.btnPrikazSvihMjesta.Text = "Prikaži sva mjesta";
            this.btnPrikazSvihMjesta.UseVisualStyleBackColor = true;
            this.btnPrikazSvihMjesta.Click += new System.EventHandler(this.btnPrikazSvihMjesta_Click);
            // 
            // mjestoDataGridView
            // 
            this.mjestoDataGridView.AllowUserToAddRows = false;
            this.mjestoDataGridView.AllowUserToDeleteRows = false;
            this.mjestoDataGridView.AutoGenerateColumns = false;
            this.mjestoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mjestoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.mjestoDataGridView.DataSource = this.mjestoBindingSource;
            this.mjestoDataGridView.Location = new System.Drawing.Point(447, 39);
            this.mjestoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.mjestoDataGridView.Name = "mjestoDataGridView";
            this.mjestoDataGridView.ReadOnly = true;
            this.mjestoDataGridView.Size = new System.Drawing.Size(369, 199);
            this.mjestoDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "postanskiBroj";
            this.dataGridViewTextBoxColumn1.HeaderText = "Poštanski broj";
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
            // mjestoBindingSource
            // 
            this.mjestoBindingSource.DataSource = typeof(RadionicaZaVozila.Mjesto);
            // 
            // lblSvaMjesta
            // 
            this.lblSvaMjesta.AutoSize = true;
            this.lblSvaMjesta.Location = new System.Drawing.Point(589, 15);
            this.lblSvaMjesta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSvaMjesta.Name = "lblSvaMjesta";
            this.lblSvaMjesta.Size = new System.Drawing.Size(81, 17);
            this.lblSvaMjesta.TabIndex = 6;
            this.lblSvaMjesta.Text = "Sva mjesta ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(400, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 369);
            this.panel1.TabIndex = 7;
            // 
            // FrmNovoMjesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 254);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSvaMjesta);
            this.Controls.Add(this.mjestoDataGridView);
            this.Controls.Add(this.btnPrikazSvihMjesta);
            this.Controls.Add(this.btnDodajMjesto);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmNovoMjesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo mjesto";
            this.Load += new System.EventHandler(this.FrmNovoMjesto_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmNovoMjesto_HelpRequested);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPostanskiBroj;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPostanskiBroj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnDodajMjesto;
        private System.Windows.Forms.Button btnPrikazSvihMjesta;
        private System.Windows.Forms.BindingSource mjestoBindingSource;
        private System.Windows.Forms.DataGridView mjestoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblSvaMjesta;
        private System.Windows.Forms.Panel panel1;
    }
}