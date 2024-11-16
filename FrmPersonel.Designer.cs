namespace YurtKayitSistemi
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            txtpersonelid = new TextBox();
            label1 = new Label();
            txtpersonelad = new TextBox();
            label2 = new Label();
            txtpersonelgorev = new TextBox();
            label3 = new Label();
            btnguncelle = new Button();
            btnsil = new Button();
            btnkaydet = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtpersonelid
            // 
            txtpersonelid.Font = new Font("Times New Roman", 12F);
            txtpersonelid.Location = new Point(207, 28);
            txtpersonelid.Name = "txtpersonelid";
            txtpersonelid.Size = new Size(228, 30);
            txtpersonelid.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(76, 36);
            label1.Name = "label1";
            label1.Size = new Size(116, 22);
            label1.TabIndex = 2;
            label1.Text = "Personel id : ";
            // 
            // txtpersonelad
            // 
            txtpersonelad.Font = new Font("Times New Roman", 12F);
            txtpersonelad.Location = new Point(207, 71);
            txtpersonelad.Name = "txtpersonelad";
            txtpersonelad.Size = new Size(228, 30);
            txtpersonelad.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(69, 79);
            label2.Name = "label2";
            label2.Size = new Size(123, 22);
            label2.TabIndex = 4;
            label2.Text = "Personel Ad : ";
            // 
            // txtpersonelgorev
            // 
            txtpersonelgorev.Font = new Font("Times New Roman", 12F);
            txtpersonelgorev.Location = new Point(207, 117);
            txtpersonelgorev.Name = "txtpersonelgorev";
            txtpersonelgorev.Size = new Size(228, 30);
            txtpersonelgorev.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(42, 125);
            label3.Name = "label3";
            label3.Size = new Size(150, 22);
            label3.TabIndex = 6;
            label3.Text = "Personel Görev : ";
            // 
            // btnguncelle
            // 
            btnguncelle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnguncelle.Location = new Point(330, 179);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(127, 39);
            btnguncelle.TabIndex = 11;
            btnguncelle.Text = "Güncelle";
            btnguncelle.UseVisualStyleBackColor = true;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnsil
            // 
            btnsil.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnsil.Location = new Point(183, 179);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(127, 39);
            btnsil.TabIndex = 10;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnkaydet.Location = new Point(33, 179);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(127, 39);
            btnkaydet.TabIndex = 9;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(421, 188);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmPersonel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Lavender;
            ClientSize = new Size(490, 469);
            Controls.Add(dataGridView1);
            Controls.Add(btnguncelle);
            Controls.Add(btnsil);
            Controls.Add(btnkaydet);
            Controls.Add(txtpersonelgorev);
            Controls.Add(label3);
            Controls.Add(txtpersonelad);
            Controls.Add(label2);
            Controls.Add(txtpersonelid);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPersonel";
            Text = "Personel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpersonelid;
        private Label label1;
        private TextBox txtpersonelad;
        private Label label2;
        private TextBox txtpersonelgorev;
        private Label label3;
        private Button btnguncelle;
        private Button btnsil;
        private Button btnkaydet;
        private DataGridView dataGridView1;
    }
}