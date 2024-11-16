namespace YurtKayitSistemi
{
    partial class FrmOgrDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrDuzenle));
            label1 = new Label();
            label12 = new Label();
            btnguncelle = new Button();
            rtextbadres = new RichTextBox();
            label11 = new Label();
            label10 = new Label();
            Mskvelitelefon = new MaskedTextBox();
            txtveliadsoyad = new TextBox();
            label9 = new Label();
            cboxodano = new ComboBox();
            label8 = new Label();
            txtmail = new TextBox();
            label7 = new Label();
            cboxogrbolum = new ComboBox();
            label6 = new Label();
            MskDogumtarihi = new MaskedTextBox();
            label5 = new Label();
            Mskogrtelefon = new MaskedTextBox();
            label4 = new Label();
            MskTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            txtogrsoyad = new TextBox();
            txtograd = new TextBox();
            label13 = new Label();
            txtogrid = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(60, 18);
            label1.Name = "label1";
            label1.Size = new Size(105, 22);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci id :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(74, 651);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 49;
            label12.Text = "label12";
            label12.Visible = false;
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.Silver;
            btnguncelle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnguncelle.Location = new Point(187, 709);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(121, 38);
            btnguncelle.TabIndex = 48;
            btnguncelle.Text = "Güncelle";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // rtextbadres
            // 
            rtextbadres.BackColor = Color.FromArgb(224, 224, 224);
            rtextbadres.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rtextbadres.Location = new Point(187, 588);
            rtextbadres.Name = "rtextbadres";
            rtextbadres.Size = new Size(265, 100);
            rtextbadres.TabIndex = 47;
            rtextbadres.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.Location = new Point(91, 588);
            label11.Name = "label11";
            label11.Size = new Size(74, 22);
            label11.TabIndex = 46;
            label11.Text = "Adres : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.Location = new Point(47, 544);
            label10.Name = "label10";
            label10.Size = new Size(118, 22);
            label10.TabIndex = 45;
            label10.Text = "Veli Telefon :";
            // 
            // Mskvelitelefon
            // 
            Mskvelitelefon.BackColor = Color.FromArgb(224, 224, 224);
            Mskvelitelefon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Mskvelitelefon.Location = new Point(187, 536);
            Mskvelitelefon.Mask = "(999) 000-0000";
            Mskvelitelefon.Name = "Mskvelitelefon";
            Mskvelitelefon.Size = new Size(265, 30);
            Mskvelitelefon.TabIndex = 44;
            // 
            // txtveliadsoyad
            // 
            txtveliadsoyad.BackColor = Color.FromArgb(224, 224, 224);
            txtveliadsoyad.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtveliadsoyad.Location = new Point(187, 485);
            txtveliadsoyad.Name = "txtveliadsoyad";
            txtveliadsoyad.Size = new Size(265, 30);
            txtveliadsoyad.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(25, 493);
            label9.Name = "label9";
            label9.Size = new Size(140, 22);
            label9.TabIndex = 42;
            label9.Text = "Veli Ad Soyad : ";
            // 
            // cboxodano
            // 
            cboxodano.BackColor = Color.FromArgb(224, 224, 224);
            cboxodano.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxodano.FormattingEnabled = true;
            cboxodano.Location = new Point(187, 408);
            cboxodano.Name = "cboxodano";
            cboxodano.Size = new Size(265, 30);
            cboxodano.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(82, 416);
            label8.Name = "label8";
            label8.Size = new Size(83, 22);
            label8.TabIndex = 40;
            label8.Text = "Oda No :";
            // 
            // txtmail
            // 
            txtmail.BackColor = Color.FromArgb(224, 224, 224);
            txtmail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtmail.Location = new Point(187, 355);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(265, 30);
            txtmail.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(101, 363);
            label7.Name = "label7";
            label7.Size = new Size(64, 22);
            label7.TabIndex = 38;
            label7.Text = "Mail : ";
            // 
            // cboxogrbolum
            // 
            cboxogrbolum.BackColor = Color.FromArgb(224, 224, 224);
            cboxogrbolum.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxogrbolum.FormattingEnabled = true;
            cboxogrbolum.Location = new Point(187, 304);
            cboxogrbolum.Name = "cboxogrbolum";
            cboxogrbolum.Size = new Size(265, 30);
            cboxogrbolum.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(8, 312);
            label6.Name = "label6";
            label6.Size = new Size(157, 22);
            label6.TabIndex = 36;
            label6.Text = "Öğrenci Bölümü : ";
            // 
            // MskDogumtarihi
            // 
            MskDogumtarihi.BackColor = Color.FromArgb(224, 224, 224);
            MskDogumtarihi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            MskDogumtarihi.Location = new Point(187, 256);
            MskDogumtarihi.Mask = "00/00/0000";
            MskDogumtarihi.Name = "MskDogumtarihi";
            MskDogumtarihi.Size = new Size(265, 30);
            MskDogumtarihi.TabIndex = 35;
            MskDogumtarihi.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(30, 264);
            label5.Name = "label5";
            label5.Size = new Size(135, 22);
            label5.TabIndex = 34;
            label5.Text = "Doğum Tarihi : ";
            // 
            // Mskogrtelefon
            // 
            Mskogrtelefon.BackColor = Color.FromArgb(224, 224, 224);
            Mskogrtelefon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Mskogrtelefon.Location = new Point(187, 205);
            Mskogrtelefon.Mask = "(999) 000-0000";
            Mskogrtelefon.Name = "Mskogrtelefon";
            Mskogrtelefon.Size = new Size(265, 30);
            Mskogrtelefon.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(79, 213);
            label4.Name = "label4";
            label4.Size = new Size(86, 22);
            label4.TabIndex = 32;
            label4.Text = "Telefon : ";
            // 
            // MskTC
            // 
            MskTC.BackColor = Color.FromArgb(224, 224, 224);
            MskTC.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            MskTC.Location = new Point(187, 152);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(265, 30);
            MskTC.TabIndex = 31;
            MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(119, 160);
            label3.Name = "label3";
            label3.Size = new Size(46, 22);
            label3.TabIndex = 30;
            label3.Text = "TC :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(27, 109);
            label2.Name = "label2";
            label2.Size = new Size(138, 22);
            label2.TabIndex = 29;
            label2.Text = "Öğrenci Soyad :";
            // 
            // txtogrsoyad
            // 
            txtogrsoyad.BackColor = Color.FromArgb(224, 224, 224);
            txtogrsoyad.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtogrsoyad.Location = new Point(187, 101);
            txtogrsoyad.Name = "txtogrsoyad";
            txtogrsoyad.Size = new Size(265, 30);
            txtogrsoyad.TabIndex = 28;
            // 
            // txtograd
            // 
            txtograd.BackColor = Color.FromArgb(224, 224, 224);
            txtograd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtograd.Location = new Point(187, 53);
            txtograd.Name = "txtograd";
            txtograd.Size = new Size(265, 30);
            txtograd.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label13.Location = new Point(53, 65);
            label13.Name = "label13";
            label13.Size = new Size(112, 22);
            label13.TabIndex = 26;
            label13.Text = "Öğrenci Ad :";
            // 
            // txtogrid
            // 
            txtogrid.BackColor = Color.FromArgb(224, 224, 224);
            txtogrid.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtogrid.Location = new Point(187, 10);
            txtogrid.Name = "txtogrid";
            txtogrid.Size = new Size(265, 30);
            txtogrid.TabIndex = 50;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(331, 709);
            button1.Name = "button1";
            button1.Size = new Size(121, 38);
            button1.TabIndex = 51;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmOgrDuzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Lavender;
            ClientSize = new Size(496, 773);
            Controls.Add(button1);
            Controls.Add(txtogrid);
            Controls.Add(label12);
            Controls.Add(btnguncelle);
            Controls.Add(rtextbadres);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(Mskvelitelefon);
            Controls.Add(txtveliadsoyad);
            Controls.Add(label9);
            Controls.Add(cboxodano);
            Controls.Add(label8);
            Controls.Add(txtmail);
            Controls.Add(label7);
            Controls.Add(cboxogrbolum);
            Controls.Add(label6);
            Controls.Add(MskDogumtarihi);
            Controls.Add(label5);
            Controls.Add(Mskogrtelefon);
            Controls.Add(label4);
            Controls.Add(MskTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtogrsoyad);
            Controls.Add(txtograd);
            Controls.Add(label13);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmOgrDuzenle";
            Text = "Öğrenci Düzenle";
            Load += FrmOgrDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label12;
        private Button btnguncelle;
        private RichTextBox rtextbadres;
        private Label label11;
        private Label label10;
        private MaskedTextBox Mskvelitelefon;
        private TextBox txtveliadsoyad;
        private Label label9;
        private ComboBox cboxodano;
        private Label label8;
        private TextBox txtmail;
        private Label label7;
        private ComboBox cboxogrbolum;
        private Label label6;
        private MaskedTextBox MskDogumtarihi;
        private Label label5;
        private MaskedTextBox Mskogrtelefon;
        private Label label4;
        private MaskedTextBox MskTC;
        private Label label3;
        private Label label2;
        private TextBox txtogrsoyad;
        private TextBox txtograd;
        private Label label13;
        private TextBox txtogrid;
        private Button button1;
    }
}