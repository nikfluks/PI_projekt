namespace RadionicaZaVozila
{
    partial class FrmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavna));
            this.alatnaTrakaGlavnogProzora = new System.Windows.Forms.ToolStrip();
            this.tsZaposlenik = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItemNoviZaposlenik = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPrikazSvihZaposlenika = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVlasniciVozila = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItemPrikazVlasnikaVozila = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNoviVlasnikVozila = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVozilo = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItemPrikazVozila = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNovVozilo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRezervniDio = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItemPrikazRezervnihDijelova = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNoviRezervniDio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPopravak = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItemPrikazPopravaka = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNoviPopravak = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStatistika = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItemPrikazPopravakaPoMjesecima = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRačuni = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItemPrikazRacuna = new System.Windows.Forms.ToolStripMenuItem();
            this.alatnaTrakaGlavnogProzora.SuspendLayout();
            this.SuspendLayout();
            // 
            // alatnaTrakaGlavnogProzora
            // 
            this.alatnaTrakaGlavnogProzora.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsZaposlenik,
            this.tsVlasniciVozila,
            this.tsVozilo,
            this.tsRezervniDio,
            this.tsPopravak,
            this.tsStatistika,
            this.tsRačuni});
            this.alatnaTrakaGlavnogProzora.Location = new System.Drawing.Point(0, 0);
            this.alatnaTrakaGlavnogProzora.Name = "alatnaTrakaGlavnogProzora";
            this.alatnaTrakaGlavnogProzora.Size = new System.Drawing.Size(784, 25);
            this.alatnaTrakaGlavnogProzora.TabIndex = 1;
            this.alatnaTrakaGlavnogProzora.Text = "toolStrip1";
            // 
            // tsZaposlenik
            // 
            this.tsZaposlenik.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsZaposlenik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPrikazSvihZaposlenika,
            this.MenuItemNoviZaposlenik});
            this.tsZaposlenik.Image = ((System.Drawing.Image)(resources.GetObject("tsZaposlenik.Image")));
            this.tsZaposlenik.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsZaposlenik.Name = "tsZaposlenik";
            this.tsZaposlenik.Size = new System.Drawing.Size(80, 22);
            this.tsZaposlenik.Text = "Zaposlenici";
            // 
            // MenuItemNoviZaposlenik
            // 
            this.MenuItemNoviZaposlenik.Name = "MenuItemNoviZaposlenik";
            this.MenuItemNoviZaposlenik.Size = new System.Drawing.Size(193, 22);
            this.MenuItemNoviZaposlenik.Text = "Novi zaposlenik";
            this.MenuItemNoviZaposlenik.Click += new System.EventHandler(this.MenuItemNoviZaposlenik_Click);
            // 
            // MenuItemPrikazSvihZaposlenika
            // 
            this.MenuItemPrikazSvihZaposlenika.Name = "MenuItemPrikazSvihZaposlenika";
            this.MenuItemPrikazSvihZaposlenika.Size = new System.Drawing.Size(193, 22);
            this.MenuItemPrikazSvihZaposlenika.Text = "Prikaz svih zaposlenika";
            this.MenuItemPrikazSvihZaposlenika.Click += new System.EventHandler(this.MenuItemPrikazSvihZaposlenika_Click);
            // 
            // tsVlasniciVozila
            // 
            this.tsVlasniciVozila.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPrikazVlasnikaVozila,
            this.MenuItemNoviVlasnikVozila});
            this.tsVlasniciVozila.Name = "tsVlasniciVozila";
            this.tsVlasniciVozila.Size = new System.Drawing.Size(93, 22);
            this.tsVlasniciVozila.Text = "Vlasnici vozila";
            // 
            // MenuItemPrikazVlasnikaVozila
            // 
            this.MenuItemPrikazVlasnikaVozila.Name = "MenuItemPrikazVlasnikaVozila";
            this.MenuItemPrikazVlasnikaVozila.Size = new System.Drawing.Size(183, 22);
            this.MenuItemPrikazVlasnikaVozila.Text = "Prikaz vlasnika vozila";
            this.MenuItemPrikazVlasnikaVozila.Click += new System.EventHandler(this.MenuItemPopisKlijenata_Click);
            // 
            // MenuItemNoviVlasnikVozila
            // 
            this.MenuItemNoviVlasnikVozila.Name = "MenuItemNoviVlasnikVozila";
            this.MenuItemNoviVlasnikVozila.Size = new System.Drawing.Size(183, 22);
            this.MenuItemNoviVlasnikVozila.Text = "Novi vlasnik vozila";
            this.MenuItemNoviVlasnikVozila.Click += new System.EventHandler(this.MenuItemNoviVlasnikVozila_Click);
            // 
            // tsVozilo
            // 
            this.tsVozilo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsVozilo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPrikazVozila,
            this.MenuItemNovVozilo});
            this.tsVozilo.Image = ((System.Drawing.Image)(resources.GetObject("tsVozilo.Image")));
            this.tsVozilo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsVozilo.Name = "tsVozilo";
            this.tsVozilo.Size = new System.Drawing.Size(50, 22);
            this.tsVozilo.Text = "Vozila";
            // 
            // MenuItemPrikazVozila
            // 
            this.MenuItemPrikazVozila.Name = "MenuItemPrikazVozila";
            this.MenuItemPrikazVozila.Size = new System.Drawing.Size(138, 22);
            this.MenuItemPrikazVozila.Text = "Prikaz vozila";
            this.MenuItemPrikazVozila.Click += new System.EventHandler(this.MenuItemPrikazVozila_Click);
            // 
            // MenuItemNovVozilo
            // 
            this.MenuItemNovVozilo.Name = "MenuItemNovVozilo";
            this.MenuItemNovVozilo.Size = new System.Drawing.Size(138, 22);
            this.MenuItemNovVozilo.Text = "Novo vozilo";
            this.MenuItemNovVozilo.Click += new System.EventHandler(this.MenuItemNovVozilo_Click);
            // 
            // tsRezervniDio
            // 
            this.tsRezervniDio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsRezervniDio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPrikazRezervnihDijelova,
            this.MenuItemNoviRezervniDio});
            this.tsRezervniDio.Image = ((System.Drawing.Image)(resources.GetObject("tsRezervniDio.Image")));
            this.tsRezervniDio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRezervniDio.Name = "tsRezervniDio";
            this.tsRezervniDio.Size = new System.Drawing.Size(84, 22);
            this.tsRezervniDio.Text = "Rezervni dio";
            // 
            // MenuItemPrikazRezervnihDijelova
            // 
            this.MenuItemPrikazRezervnihDijelova.Name = "MenuItemPrikazRezervnihDijelova";
            this.MenuItemPrikazRezervnihDijelova.Size = new System.Drawing.Size(200, 22);
            this.MenuItemPrikazRezervnihDijelova.Text = "Prikaz rezervnih dijelova";
            this.MenuItemPrikazRezervnihDijelova.Click += new System.EventHandler(this.MenuItemPrikazRezervnihDijelova_Click);
            // 
            // MenuItemNoviRezervniDio
            // 
            this.MenuItemNoviRezervniDio.Name = "MenuItemNoviRezervniDio";
            this.MenuItemNoviRezervniDio.Size = new System.Drawing.Size(200, 22);
            this.MenuItemNoviRezervniDio.Text = "Novi rezervni dio";
            this.MenuItemNoviRezervniDio.Click += new System.EventHandler(this.MenuItemNoviRezervniDio_Click);
            // 
            // tsPopravak
            // 
            this.tsPopravak.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsPopravak.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPrikazPopravaka,
            this.MenuItemNoviPopravak});
            this.tsPopravak.Image = ((System.Drawing.Image)(resources.GetObject("tsPopravak.Image")));
            this.tsPopravak.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPopravak.Name = "tsPopravak";
            this.tsPopravak.Size = new System.Drawing.Size(66, 22);
            this.tsPopravak.Text = "Popravci";
            // 
            // MenuItemPrikazPopravaka
            // 
            this.MenuItemPrikazPopravaka.Name = "MenuItemPrikazPopravaka";
            this.MenuItemPrikazPopravaka.Size = new System.Drawing.Size(163, 22);
            this.MenuItemPrikazPopravaka.Text = "Prikaz popravaka";
            this.MenuItemPrikazPopravaka.Click += new System.EventHandler(this.MenuItemPrikazPopravaka_Click);
            // 
            // MenuItemNoviPopravak
            // 
            this.MenuItemNoviPopravak.Name = "MenuItemNoviPopravak";
            this.MenuItemNoviPopravak.Size = new System.Drawing.Size(163, 22);
            this.MenuItemNoviPopravak.Text = "Novi popravak";
            this.MenuItemNoviPopravak.Click += new System.EventHandler(this.MenuItemNoviPopravak_Click);
            // 
            // tsStatistika
            // 
            this.tsStatistika.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsStatistika.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPrikazPopravakaPoMjesecima});
            this.tsStatistika.Image = ((System.Drawing.Image)(resources.GetObject("tsStatistika.Image")));
            this.tsStatistika.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStatistika.Name = "tsStatistika";
            this.tsStatistika.Size = new System.Drawing.Size(67, 22);
            this.tsStatistika.Text = "Statistika";
            // 
            // MenuItemPrikazPopravakaPoMjesecima
            // 
            this.MenuItemPrikazPopravakaPoMjesecima.Name = "MenuItemPrikazPopravakaPoMjesecima";
            this.MenuItemPrikazPopravakaPoMjesecima.Size = new System.Drawing.Size(240, 22);
            this.MenuItemPrikazPopravakaPoMjesecima.Text = "Prikaz popravaka po mjesecima";
            this.MenuItemPrikazPopravakaPoMjesecima.Click += new System.EventHandler(this.MenuItemPrikazPopravakaPoMjesecima_Click);
            // 
            // tsRačuni
            // 
            this.tsRačuni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPrikazRacuna});
            this.tsRačuni.Name = "tsRačuni";
            this.tsRačuni.Size = new System.Drawing.Size(56, 22);
            this.tsRačuni.Text = "Računi";
            // 
            // MenuItemPrikazRacuna
            // 
            this.MenuItemPrikazRacuna.Name = "MenuItemPrikazRacuna";
            this.MenuItemPrikazRacuna.Size = new System.Drawing.Size(144, 22);
            this.MenuItemPrikazRacuna.Text = "Prikaz računa";
            this.MenuItemPrikazRacuna.Click += new System.EventHandler(this.MenuItemPrikazRacuna_Click);
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.alatnaTrakaGlavnogProzora);
            this.IsMdiContainer = true;
            this.Name = "FrmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radionica za osobna vozila";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGlavna_FormClosing);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmGlavna_HelpRequested);
            this.alatnaTrakaGlavnogProzora.ResumeLayout(false);
            this.alatnaTrakaGlavnogProzora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip alatnaTrakaGlavnogProzora;
        private System.Windows.Forms.ToolStripDropDownButton tsZaposlenik;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNoviZaposlenik;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPrikazSvihZaposlenika;
        private System.Windows.Forms.ToolStripDropDownButton tsVlasniciVozila;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPrikazVlasnikaVozila;
        private System.Windows.Forms.ToolStripDropDownButton tsVozilo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPrikazVozila;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNovVozilo;
        private System.Windows.Forms.ToolStripDropDownButton tsRezervniDio;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPrikazRezervnihDijelova;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNoviRezervniDio;
        private System.Windows.Forms.ToolStripDropDownButton tsPopravak;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPrikazPopravaka;
        private System.Windows.Forms.ToolStripDropDownButton tsStatistika;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPrikazPopravakaPoMjesecima;
        private System.Windows.Forms.ToolStripDropDownButton tsRačuni;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPrikazRacuna;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNoviVlasnikVozila;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNoviPopravak;
    }
}