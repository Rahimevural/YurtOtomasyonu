namespace YurtKayitSistemi
{
    partial class FrmYoneticiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYoneticiDuzenle));
            label1 = new Label();
            txtyoneticiid = new TextBox();
            txtkullaniciad = new TextBox();
            label2 = new Label();
            txtsifre = new TextBox();
            label3 = new Label();
            btnkaydet = new Button();
            btnsil = new Button();
            btnguncelle = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(28, 23);
            label1.Name = "label1";
            label1.Size = new Size(115, 22);
            label1.TabIndex = 0;
            label1.Text = "Yönetici id : ";
            // 
            // txtyoneticiid
            // 
            txtyoneticiid.Font = new Font("Times New Roman", 12F);
            txtyoneticiid.Location = new Point(162, 15);
            txtyoneticiid.Name = "txtyoneticiid";
            txtyoneticiid.Size = new Size(228, 30);
            txtyoneticiid.TabIndex = 1;
            // 
            // txtkullaniciad
            // 
            txtkullaniciad.Font = new Font("Times New Roman", 12F);
            txtkullaniciad.Location = new Point(162, 62);
            txtkullaniciad.Name = "txtkullaniciad";
            txtkullaniciad.Size = new Size(228, 30);
            txtkullaniciad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(15, 70);
            label2.Name = "label2";
            label2.Size = new Size(128, 22);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı Ad : ";
            // 
            // txtsifre
            // 
            txtsifre.Font = new Font("Times New Roman", 12F);
            txtsifre.Location = new Point(162, 114);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(228, 30);
            txtsifre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(78, 122);
            label3.Name = "label3";
            label3.Size = new Size(65, 22);
            label3.TabIndex = 4;
            label3.Text = "Şifre : ";
            // 
            // btnkaydet
            // 
            btnkaydet.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnkaydet.Location = new Point(12, 180);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(127, 39);
            btnkaydet.TabIndex = 6;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // btnsil
            // 
            btnsil.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnsil.Location = new Point(162, 180);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(127, 39);
            btnsil.TabIndex = 7;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // btnguncelle
            // 
            btnguncelle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnguncelle.Location = new Point(309, 180);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(127, 39);
            btnguncelle.TabIndex = 8;
            btnguncelle.Text = "Güncelle";
            btnguncelle.UseVisualStyleBackColor = true;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(424, 188);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmYoneticiDuzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(448, 460);
            Controls.Add(dataGridView1);
            Controls.Add(btnguncelle);
            Controls.Add(btnsil);
            Controls.Add(btnkaydet);
            Controls.Add(txtsifre);
            Controls.Add(label3);
            Controls.Add(txtkullaniciad);
            Controls.Add(label2);
            Controls.Add(txtyoneticiid);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmYoneticiDuzenle";
            Text = "Yönetici İşlemleri";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtyoneticiid;
        private TextBox txtkullaniciad;
        private Label label2;
        private TextBox txtsifre;
        private Label label3;
        private Button btnkaydet;
        private Button btnsil;
        private Button btnguncelle;
        private DataGridView dataGridView1;
    }
}