namespace YurtKayitSistemi
{
    partial class FrmAnaForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            menuStrip1 = new MenuStrip();
            öğrencilerToolStripMenuItem = new ToolStripMenuItem();
            öğrenciEkleToolStripMenuItem = new ToolStripMenuItem();
            öğrenciListesiToolStripMenuItem = new ToolStripMenuItem();
            öğrenciDüzenleToolStripMenuItem = new ToolStripMenuItem();
            bölümlerToolStripMenuItem = new ToolStripMenuItem();
            bölümEkleToolStripMenuItem = new ToolStripMenuItem();
            bölümDüzenleToolStripMenuItem = new ToolStripMenuItem();
            ödemelerToolStripMenuItem = new ToolStripMenuItem();
            ödemeAlToolStripMenuItem = new ToolStripMenuItem();
            giderlerToolStripMenuItem = new ToolStripMenuItem();
            giderEkleToolStripMenuItem = new ToolStripMenuItem();
            giderİstatistikleriToolStripMenuItem = new ToolStripMenuItem();
            istatisToolStripMenuItem = new ToolStripMenuItem();
            gelirİstatistikleriToolStripMenuItem = new ToolStripMenuItem();
            yöneticiToolStripMenuItem = new ToolStripMenuItem();
            şifreİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            personelDüzenleToolStripMenuItem = new ToolStripMenuItem();
            notEkleToolStripMenuItem = new ToolStripMenuItem();
            raporAlToolStripMenuItem = new ToolStripMenuItem();
            öğrenciBilgileriToolStripMenuItem = new ToolStripMenuItem();
            gelirRaporlarıToolStripMenuItem = new ToolStripMenuItem();
            erişimKolaylığıToolStripMenuItem = new ToolStripMenuItem();
            hesapMakinesiToolStripMenuItem = new ToolStripMenuItem();
            paintToolStripMenuItem = new ToolStripMenuItem();
            hakkımızdaToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { öğrencilerToolStripMenuItem, bölümlerToolStripMenuItem, ödemelerToolStripMenuItem, giderlerToolStripMenuItem, istatisToolStripMenuItem, yöneticiToolStripMenuItem, erişimKolaylığıToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(827, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // öğrencilerToolStripMenuItem
            // 
            öğrencilerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { öğrenciEkleToolStripMenuItem, öğrenciListesiToolStripMenuItem, öğrenciDüzenleToolStripMenuItem });
            öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            öğrencilerToolStripMenuItem.Size = new Size(97, 24);
            öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            öğrenciEkleToolStripMenuItem.Size = new Size(199, 26);
            öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            öğrenciEkleToolStripMenuItem.Click += öğrenciEkleToolStripMenuItem_Click;
            // 
            // öğrenciListesiToolStripMenuItem
            // 
            öğrenciListesiToolStripMenuItem.Name = "öğrenciListesiToolStripMenuItem";
            öğrenciListesiToolStripMenuItem.Size = new Size(199, 26);
            öğrenciListesiToolStripMenuItem.Text = "Öğrenci Listesi";
            öğrenciListesiToolStripMenuItem.Click += öğrenciListesiToolStripMenuItem_Click;
            // 
            // öğrenciDüzenleToolStripMenuItem
            // 
            öğrenciDüzenleToolStripMenuItem.Name = "öğrenciDüzenleToolStripMenuItem";
            öğrenciDüzenleToolStripMenuItem.Size = new Size(199, 26);
            öğrenciDüzenleToolStripMenuItem.Text = "Öğrenci Sil";
            öğrenciDüzenleToolStripMenuItem.Click += öğrenciDüzenleToolStripMenuItem_Click;
            // 
            // bölümlerToolStripMenuItem
            // 
            bölümlerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bölümEkleToolStripMenuItem, bölümDüzenleToolStripMenuItem });
            bölümlerToolStripMenuItem.Name = "bölümlerToolStripMenuItem";
            bölümlerToolStripMenuItem.Size = new Size(89, 24);
            bölümlerToolStripMenuItem.Text = "Bölümler";
            // 
            // bölümEkleToolStripMenuItem
            // 
            bölümEkleToolStripMenuItem.Name = "bölümEkleToolStripMenuItem";
            bölümEkleToolStripMenuItem.Size = new Size(204, 26);
            bölümEkleToolStripMenuItem.Text = "Bölüm Ekle ";
            bölümEkleToolStripMenuItem.Click += bölümEkleToolStripMenuItem_Click;
            // 
            // bölümDüzenleToolStripMenuItem
            // 
            bölümDüzenleToolStripMenuItem.Name = "bölümDüzenleToolStripMenuItem";
            bölümDüzenleToolStripMenuItem.Size = new Size(204, 26);
            bölümDüzenleToolStripMenuItem.Text = "Bölüm Düzenle";
            bölümDüzenleToolStripMenuItem.Click += bölümDüzenleToolStripMenuItem_Click;
            // 
            // ödemelerToolStripMenuItem
            // 
            ödemelerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ödemeAlToolStripMenuItem });
            ödemelerToolStripMenuItem.Name = "ödemelerToolStripMenuItem";
            ödemelerToolStripMenuItem.Size = new Size(93, 24);
            ödemelerToolStripMenuItem.Text = "Ödemeler";
            // 
            // ödemeAlToolStripMenuItem
            // 
            ödemeAlToolStripMenuItem.Name = "ödemeAlToolStripMenuItem";
            ödemeAlToolStripMenuItem.Size = new Size(164, 26);
            ödemeAlToolStripMenuItem.Text = "Ödeme Al";
            ödemeAlToolStripMenuItem.Click += ödemeAlToolStripMenuItem_Click;
            // 
            // giderlerToolStripMenuItem
            // 
            giderlerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { giderEkleToolStripMenuItem, giderİstatistikleriToolStripMenuItem });
            giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            giderlerToolStripMenuItem.Size = new Size(81, 24);
            giderlerToolStripMenuItem.Text = "Giderler";
            // 
            // giderEkleToolStripMenuItem
            // 
            giderEkleToolStripMenuItem.Name = "giderEkleToolStripMenuItem";
            giderEkleToolStripMenuItem.Size = new Size(183, 26);
            giderEkleToolStripMenuItem.Text = "Gider Ekle";
            giderEkleToolStripMenuItem.Click += giderEkleToolStripMenuItem_Click;
            // 
            // giderİstatistikleriToolStripMenuItem
            // 
            giderİstatistikleriToolStripMenuItem.Name = "giderİstatistikleriToolStripMenuItem";
            giderİstatistikleriToolStripMenuItem.Size = new Size(183, 26);
            giderİstatistikleriToolStripMenuItem.Text = "Gider Listesi";
            giderİstatistikleriToolStripMenuItem.Click += giderİstatistikleriToolStripMenuItem_Click;
            // 
            // istatisToolStripMenuItem
            // 
            istatisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gelirİstatistikleriToolStripMenuItem });
            istatisToolStripMenuItem.Name = "istatisToolStripMenuItem";
            istatisToolStripMenuItem.Size = new Size(101, 24);
            istatisToolStripMenuItem.Text = "İstatistikler";
            // 
            // gelirİstatistikleriToolStripMenuItem
            // 
            gelirİstatistikleriToolStripMenuItem.Name = "gelirİstatistikleriToolStripMenuItem";
            gelirİstatistikleriToolStripMenuItem.Size = new Size(214, 26);
            gelirİstatistikleriToolStripMenuItem.Text = "Gelir İstatistikleri";
            gelirİstatistikleriToolStripMenuItem.Click += gelirİstatistikleriToolStripMenuItem_Click;
            // 
            // yöneticiToolStripMenuItem
            // 
            yöneticiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { şifreİşlemleriToolStripMenuItem, personelDüzenleToolStripMenuItem, notEkleToolStripMenuItem, raporAlToolStripMenuItem });
            yöneticiToolStripMenuItem.Name = "yöneticiToolStripMenuItem";
            yöneticiToolStripMenuItem.Size = new Size(83, 24);
            yöneticiToolStripMenuItem.Text = "Yönetici";
            // 
            // şifreİşlemleriToolStripMenuItem
            // 
            şifreİşlemleriToolStripMenuItem.Name = "şifreİşlemleriToolStripMenuItem";
            şifreİşlemleriToolStripMenuItem.Size = new Size(218, 26);
            şifreİşlemleriToolStripMenuItem.Text = "Şifre İşlemleri";
            şifreİşlemleriToolStripMenuItem.Click += şifreİşlemleriToolStripMenuItem_Click;
            // 
            // personelDüzenleToolStripMenuItem
            // 
            personelDüzenleToolStripMenuItem.Name = "personelDüzenleToolStripMenuItem";
            personelDüzenleToolStripMenuItem.Size = new Size(218, 26);
            personelDüzenleToolStripMenuItem.Text = "Personel Düzenle";
            personelDüzenleToolStripMenuItem.Click += personelDüzenleToolStripMenuItem_Click;
            // 
            // notEkleToolStripMenuItem
            // 
            notEkleToolStripMenuItem.Name = "notEkleToolStripMenuItem";
            notEkleToolStripMenuItem.Size = new Size(218, 26);
            notEkleToolStripMenuItem.Text = "Not Ekle";
            notEkleToolStripMenuItem.Click += notEkleToolStripMenuItem_Click;
            // 
            // raporAlToolStripMenuItem
            // 
            raporAlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { öğrenciBilgileriToolStripMenuItem, gelirRaporlarıToolStripMenuItem });
            raporAlToolStripMenuItem.Name = "raporAlToolStripMenuItem";
            raporAlToolStripMenuItem.Size = new Size(218, 26);
            raporAlToolStripMenuItem.Text = "Rapor Al";
            // 
            // öğrenciBilgileriToolStripMenuItem
            // 
            öğrenciBilgileriToolStripMenuItem.Name = "öğrenciBilgileriToolStripMenuItem";
            öğrenciBilgileriToolStripMenuItem.Size = new Size(207, 26);
            öğrenciBilgileriToolStripMenuItem.Text = "Öğrenci Bilgileri";
            // 
            // gelirRaporlarıToolStripMenuItem
            // 
            gelirRaporlarıToolStripMenuItem.Name = "gelirRaporlarıToolStripMenuItem";
            gelirRaporlarıToolStripMenuItem.Size = new Size(207, 26);
            gelirRaporlarıToolStripMenuItem.Text = "Gelir Raporları";
            // 
            // erişimKolaylığıToolStripMenuItem
            // 
            erişimKolaylığıToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hesapMakinesiToolStripMenuItem, paintToolStripMenuItem, hakkımızdaToolStripMenuItem, çıkışToolStripMenuItem });
            erişimKolaylığıToolStripMenuItem.Name = "erişimKolaylığıToolStripMenuItem";
            erişimKolaylığıToolStripMenuItem.Size = new Size(137, 24);
            erişimKolaylığıToolStripMenuItem.Text = "Erişim Kolaylığı";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            hesapMakinesiToolStripMenuItem.Size = new Size(224, 26);
            hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi ";
            hesapMakinesiToolStripMenuItem.Click += hesapMakinesiToolStripMenuItem_Click;
            // 
            // paintToolStripMenuItem
            // 
            paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            paintToolStripMenuItem.Size = new Size(224, 26);
            paintToolStripMenuItem.Text = "Paint";
            paintToolStripMenuItem.Click += paintToolStripMenuItem_Click;
            // 
            // hakkımızdaToolStripMenuItem
            // 
            hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            hakkımızdaToolStripMenuItem.Size = new Size(224, 26);
            hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            hakkımızdaToolStripMenuItem.Click += hakkımızdaToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(224, 26);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(539, 342);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(545, 109);
            label1.Name = "label1";
            label1.Size = new Size(60, 22);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(609, 137);
            label2.Name = "label2";
            label2.Size = new Size(60, 22);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // FrmAnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(827, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAnaForm";
            Text = "Ana Sayfa";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem öğrencilerToolStripMenuItem;
        private ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private ToolStripMenuItem öğrenciListesiToolStripMenuItem;
        private ToolStripMenuItem öğrenciDüzenleToolStripMenuItem;
        private ToolStripMenuItem bölümlerToolStripMenuItem;
        private ToolStripMenuItem bölümEkleToolStripMenuItem;
        private ToolStripMenuItem bölümDüzenleToolStripMenuItem;
        private ToolStripMenuItem ödemelerToolStripMenuItem;
        private ToolStripMenuItem ödemeAlToolStripMenuItem;
        private ToolStripMenuItem giderlerToolStripMenuItem;
        private ToolStripMenuItem giderEkleToolStripMenuItem;
        private ToolStripMenuItem giderİstatistikleriToolStripMenuItem;
        private ToolStripMenuItem istatisToolStripMenuItem;
        private ToolStripMenuItem gelirİstatistikleriToolStripMenuItem;
        private ToolStripMenuItem yöneticiToolStripMenuItem;
        private ToolStripMenuItem şifreİşlemleriToolStripMenuItem;
        private ToolStripMenuItem personelDüzenleToolStripMenuItem;
        private ToolStripMenuItem erişimKolaylığıToolStripMenuItem;
        private ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private ToolStripMenuItem paintToolStripMenuItem;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem notEkleToolStripMenuItem;
        private ToolStripMenuItem raporAlToolStripMenuItem;
        private ToolStripMenuItem öğrenciBilgileriToolStripMenuItem;
        private ToolStripMenuItem gelirRaporlarıToolStripMenuItem;
    }
}