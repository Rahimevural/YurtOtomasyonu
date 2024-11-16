namespace YurtKayitSistemi
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            label1 = new Label();
            txtkullaniciad = new TextBox();
            btngirisyap = new Button();
            txtsifre = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(59, 114);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı : ";
            // 
            // txtkullaniciad
            // 
            txtkullaniciad.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtkullaniciad.Location = new Point(198, 107);
            txtkullaniciad.Name = "txtkullaniciad";
            txtkullaniciad.Size = new Size(186, 30);
            txtkullaniciad.TabIndex = 1;
            // 
            // btngirisyap
            // 
            btngirisyap.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btngirisyap.Location = new Point(219, 207);
            btngirisyap.Name = "btngirisyap";
            btngirisyap.Size = new Size(125, 38);
            btngirisyap.TabIndex = 2;
            btngirisyap.Text = "Giriş Yap ";
            btngirisyap.UseVisualStyleBackColor = true;
            btngirisyap.Click += btngirisyap_Click;
            // 
            // txtsifre
            // 
            txtsifre.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtsifre.Location = new Point(198, 155);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(186, 30);
            txtsifre.TabIndex = 4;
            txtsifre.UseSystemPasswordChar = true;
            //txtsifre.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(124, 162);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 3;
            label2.Text = "Şifre : ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MintCream;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(22, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 47);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(38, 12);
            label3.Name = "label3";
            label3.Size = new Size(351, 23);
            label3.TabIndex = 6;
            label3.Text = "Öğrenci Yurt Kayıt Otomasyonu Sistemi ";
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Lavender;
            ClientSize = new Size(477, 293);
            Controls.Add(panel1);
            Controls.Add(txtsifre);
            Controls.Add(label2);
            Controls.Add(btngirisyap);
            Controls.Add(txtkullaniciad);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdminGiris";
            Text = "Admin Giriş";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtkullaniciad;
        private Button btngirisyap;
        private TextBox txtsifre;
        private Label label2;
        private Panel panel1;
        private Label label3;
    }
}