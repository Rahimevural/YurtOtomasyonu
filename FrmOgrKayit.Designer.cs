namespace YurtKayitSistemi
{
    partial class FrmOgrKayit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            label1 = new Label();
            txtograd = new TextBox();
            txtogrsoyad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            MskTC = new MaskedTextBox();
            label4 = new Label();
            Mskogrtelefon = new MaskedTextBox();
            label5 = new Label();
            MskDogumtarihi = new MaskedTextBox();
            label6 = new Label();
            cboxogrbolum = new ComboBox();
            label7 = new Label();
            txtmail = new TextBox();
            label8 = new Label();
            cboxodano = new ComboBox();
            label9 = new Label();
            txtveliadsoyad = new TextBox();
            Mskvelitelefon = new MaskedTextBox();
            label10 = new Label();
            label11 = new Label();
            rtextbadres = new RichTextBox();
            btnkaydet = new Button();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(46, 24);
            label1.Name = "label1";
            label1.Size = new Size(112, 22);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Ad :";
            // 
            // txtograd
            // 
            txtograd.BackColor = Color.FromArgb(224, 224, 224);
            txtograd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtograd.Location = new Point(180, 12);
            txtograd.Name = "txtograd";
            txtograd.Size = new Size(265, 30);
            txtograd.TabIndex = 1;
            // 
            // txtogrsoyad
            // 
            txtogrsoyad.BackColor = Color.FromArgb(224, 224, 224);
            txtogrsoyad.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtogrsoyad.Location = new Point(180, 60);
            txtogrsoyad.Name = "txtogrsoyad";
            txtogrsoyad.Size = new Size(265, 30);
            txtogrsoyad.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(20, 68);
            label2.Name = "label2";
            label2.Size = new Size(138, 22);
            label2.TabIndex = 3;
            label2.Text = "Öğrenci Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(112, 119);
            label3.Name = "label3";
            label3.Size = new Size(46, 22);
            label3.TabIndex = 4;
            label3.Text = "TC :";
            // 
            // MskTC
            // 
            MskTC.BackColor = Color.FromArgb(224, 224, 224);
            MskTC.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            MskTC.Location = new Point(180, 111);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(265, 30);
            MskTC.TabIndex = 7;
            MskTC.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(72, 172);
            label4.Name = "label4";
            label4.Size = new Size(86, 22);
            label4.TabIndex = 8;
            label4.Text = "Telefon : ";
            // 
            // Mskogrtelefon
            // 
            Mskogrtelefon.BackColor = Color.FromArgb(224, 224, 224);
            Mskogrtelefon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Mskogrtelefon.Location = new Point(180, 164);
            Mskogrtelefon.Mask = "(999) 000-0000";
            Mskogrtelefon.Name = "Mskogrtelefon";
            Mskogrtelefon.Size = new Size(265, 30);
            Mskogrtelefon.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(23, 223);
            label5.Name = "label5";
            label5.Size = new Size(135, 22);
            label5.TabIndex = 10;
            label5.Text = "Doğum Tarihi : ";
            // 
            // MskDogumtarihi
            // 
            MskDogumtarihi.BackColor = Color.FromArgb(224, 224, 224);
            MskDogumtarihi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            MskDogumtarihi.Location = new Point(180, 215);
            MskDogumtarihi.Mask = "00/00/0000";
            MskDogumtarihi.Name = "MskDogumtarihi";
            MskDogumtarihi.Size = new Size(265, 30);
            MskDogumtarihi.TabIndex = 11;
            MskDogumtarihi.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(1, 271);
            label6.Name = "label6";
            label6.Size = new Size(157, 22);
            label6.TabIndex = 12;
            label6.Text = "Öğrenci Bölümü : ";
            // 
            // cboxogrbolum
            // 
            cboxogrbolum.BackColor = Color.FromArgb(224, 224, 224);
            cboxogrbolum.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxogrbolum.FormattingEnabled = true;
            cboxogrbolum.Location = new Point(180, 263);
            cboxogrbolum.Name = "cboxogrbolum";
            cboxogrbolum.Size = new Size(265, 30);
            cboxogrbolum.TabIndex = 13;
           
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(94, 322);
            label7.Name = "label7";
            label7.Size = new Size(64, 22);
            label7.TabIndex = 14;
            label7.Text = "Mail : ";
            // 
            // txtmail
            // 
            txtmail.BackColor = Color.FromArgb(224, 224, 224);
            txtmail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtmail.Location = new Point(180, 314);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(265, 30);
            txtmail.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(75, 375);
            label8.Name = "label8";
            label8.Size = new Size(83, 22);
            label8.TabIndex = 16;
            label8.Text = "Oda No :";
            // 
            // cboxodano
            // 
            cboxodano.BackColor = Color.FromArgb(224, 224, 224);
            cboxodano.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxodano.FormattingEnabled = true;
            cboxodano.Location = new Point(180, 367);
            cboxodano.Name = "cboxodano";
            cboxodano.Size = new Size(265, 30);
            cboxodano.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(18, 452);
            label9.Name = "label9";
            label9.Size = new Size(140, 22);
            label9.TabIndex = 18;
            label9.Text = "Veli Ad Soyad : ";
            // 
            // txtveliadsoyad
            // 
            txtveliadsoyad.BackColor = Color.FromArgb(224, 224, 224);
            txtveliadsoyad.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtveliadsoyad.Location = new Point(180, 444);
            txtveliadsoyad.Name = "txtveliadsoyad";
            txtveliadsoyad.Size = new Size(265, 30);
            txtveliadsoyad.TabIndex = 19;
            // 
            // Mskvelitelefon
            // 
            Mskvelitelefon.BackColor = Color.FromArgb(224, 224, 224);
            Mskvelitelefon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Mskvelitelefon.Location = new Point(180, 495);
            Mskvelitelefon.Mask = "(999) 000-0000";
            Mskvelitelefon.Name = "Mskvelitelefon";
            Mskvelitelefon.Size = new Size(265, 30);
            Mskvelitelefon.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.Location = new Point(40, 503);
            label10.Name = "label10";
            label10.Size = new Size(118, 22);
            label10.TabIndex = 21;
            label10.Text = "Veli Telefon :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.Location = new Point(84, 547);
            label11.Name = "label11";
            label11.Size = new Size(74, 22);
            label11.TabIndex = 22;
            label11.Text = "Adres : ";
            // 
            // rtextbadres
            // 
            rtextbadres.BackColor = Color.FromArgb(224, 224, 224);
            rtextbadres.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rtextbadres.Location = new Point(180, 547);
            rtextbadres.Name = "rtextbadres";
            rtextbadres.Size = new Size(265, 100);
            rtextbadres.TabIndex = 23;
            rtextbadres.Text = "";
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = Color.Silver;
            btnkaydet.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnkaydet.Location = new Point(248, 671);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(121, 38);
            btnkaydet.TabIndex = 24;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(67, 610);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 25;
            label12.Text = "label12";
            label12.Visible = false;
            // 
            // FrmOgrKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(482, 721);
            Controls.Add(label12);
            Controls.Add(btnkaydet);
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
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmOgrKayit";
            Text = "Öğrenci Kayıt";
            Load += FrmOgrKayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtograd;
        private TextBox txtogrsoyad;
        private Label label2;
        private Label label3;
        private MaskedTextBox MskTC;
        private Label label4;
        private MaskedTextBox Mskogrtelefon;
        private Label label5;
        private MaskedTextBox MskDogumtarihi;
        private Label label6;
        private ComboBox cboxogrbolum;
        private Label label7;
        private TextBox txtmail;
        private Label label8;
        private ComboBox cboxodano;
        private Label label9;
        private TextBox txtveliadsoyad;
        private MaskedTextBox Mskvelitelefon;
        private Label label10;
        private Label label11;
        private RichTextBox rtextbadres;
        private Button btnkaydet;
        private Label label12;
    }
}
