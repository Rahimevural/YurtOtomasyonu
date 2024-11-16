namespace YurtKayitSistemi
{
    partial class FrmOdemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeler));
            label1 = new Label();
            TxtOgrenciid = new TextBox();
            label2 = new Label();
            TxtOdenen = new TextBox();
            TxtKalan = new TextBox();
            label3 = new Label();
            btnOdemeal = new Button();
            dataGridView1 = new DataGridView();
            Txtogrsoyad = new TextBox();
            label4 = new Label();
            Txtograd = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtodenenay = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(44, 22);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci id :";
            // 
            // TxtOgrenciid
            // 
            TxtOgrenciid.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TxtOgrenciid.Location = new Point(142, 12);
            TxtOgrenciid.Name = "TxtOgrenciid";
            TxtOgrenciid.Size = new Size(249, 30);
            TxtOgrenciid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(61, 125);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Ödenen :";
            // 
            // TxtOdenen
            // 
            TxtOdenen.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TxtOdenen.Location = new Point(141, 121);
            TxtOdenen.Name = "TxtOdenen";
            TxtOdenen.Size = new Size(249, 30);
            TxtOdenen.TabIndex = 3;
            // 
            // TxtKalan
            // 
            TxtKalan.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TxtKalan.Location = new Point(142, 157);
            TxtKalan.Name = "TxtKalan";
            TxtKalan.Size = new Size(249, 30);
            TxtKalan.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(36, 161);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 5;
            label3.Text = "Kalan Borç :";
            // 
            // btnOdemeal
            // 
            btnOdemeal.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOdemeal.Location = new Point(190, 241);
            btnOdemeal.Name = "btnOdemeal";
            btnOdemeal.Size = new Size(142, 40);
            btnOdemeal.TabIndex = 6;
            btnOdemeal.Text = "Ödeme Al";
            btnOdemeal.UseVisualStyleBackColor = true;
            btnOdemeal.Click += btnOdemeal_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(414, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(536, 248);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Txtogrsoyad
            // 
            Txtogrsoyad.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Txtogrsoyad.Location = new Point(142, 84);
            Txtogrsoyad.Name = "Txtogrsoyad";
            Txtogrsoyad.Size = new Size(249, 30);
            Txtogrsoyad.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(7, 88);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 10;
            label4.Text = "Öğrenci Soyad : ";
            // 
            // Txtograd
            // 
            Txtograd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Txtograd.Location = new Point(142, 48);
            Txtograd.Name = "Txtograd";
            Txtograd.Size = new Size(249, 30);
            Txtograd.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(36, 52);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 8;
            label5.Text = "Öğrenci Ad :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(35, 197);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 13;
            label6.Text = "Ödenen Ay :";
            // 
            // txtodenenay
            // 
            txtodenenay.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtodenenay.Location = new Point(141, 193);
            txtodenenay.Name = "txtodenenay";
            txtodenenay.Size = new Size(249, 30);
            txtodenenay.TabIndex = 12;
            // 
            // FrmOdemeler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(951, 326);
            Controls.Add(label6);
            Controls.Add(txtodenenay);
            Controls.Add(Txtogrsoyad);
            Controls.Add(label4);
            Controls.Add(Txtograd);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btnOdemeal);
            Controls.Add(label3);
            Controls.Add(TxtKalan);
            Controls.Add(TxtOdenen);
            Controls.Add(label2);
            Controls.Add(TxtOgrenciid);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmOdemeler";
            Text = "Ödemeler";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtOgrenciid;
        private Label label2;
        private TextBox TxtOdenen;
        private TextBox TxtKalan;
        private Label label3;
        private Button btnOdemeal;
        private DataGridView dataGridView1;
        private TextBox Txtogrsoyad;
        private Label label4;
        private TextBox Txtograd;
        private Label label5;
        private Label label6;
        private TextBox txtodenenay;
    }
}