namespace YurtKayitSistemi
{
    partial class FrmNotEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotEkle));
            btnkaydet = new Button();
            richTextBox1 = new RichTextBox();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // btnkaydet
            // 
            btnkaydet.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnkaydet.Location = new Point(298, 430);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(139, 45);
            btnkaydet.TabIndex = 0;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.MintCream;
            richTextBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            richTextBox1.Location = new Point(1, 1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(723, 423);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // FrmNotEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(723, 487);
            Controls.Add(richTextBox1);
            Controls.Add(btnkaydet);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNotEkle";
            Text = "Not Oluştur";
            ResumeLayout(false);
        }

        #endregion

        private Button btnkaydet;
        private RichTextBox richTextBox1;
        private SaveFileDialog saveFileDialog1;
    }
}