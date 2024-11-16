namespace YurtKayitSistemi
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            PcbBolumekle = new PictureBox();
            PcbBolumSil = new PictureBox();
            PcbBolumDuzenle = new PictureBox();
            label1 = new Label();
            TxtBolumid = new TextBox();
            TxtBolumAd = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            labelekle = new Label();
            labelsil = new Label();
            labelduzen = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)PcbBolumekle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbBolumSil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbBolumDuzenle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PcbBolumekle
            // 
            PcbBolumekle.Image = (Image)resources.GetObject("PcbBolumekle.Image");
            PcbBolumekle.Location = new Point(55, 133);
            PcbBolumekle.Name = "PcbBolumekle";
            PcbBolumekle.Size = new Size(78, 85);
            PcbBolumekle.SizeMode = PictureBoxSizeMode.Zoom;
            PcbBolumekle.TabIndex = 0;
            PcbBolumekle.TabStop = false;
            toolTip1.SetToolTip(PcbBolumekle, "Bölüm Ekle");
            PcbBolumekle.Click += PcbBolumekle_Click;
            // 
            // PcbBolumSil
            // 
            PcbBolumSil.Image = (Image)resources.GetObject("PcbBolumSil.Image");
            PcbBolumSil.Location = new Point(230, 133);
            PcbBolumSil.Name = "PcbBolumSil";
            PcbBolumSil.Size = new Size(78, 85);
            PcbBolumSil.SizeMode = PictureBoxSizeMode.Zoom;
            PcbBolumSil.TabIndex = 1;
            PcbBolumSil.TabStop = false;
            toolTip1.SetToolTip(PcbBolumSil, "Bölüm Sil");
            PcbBolumSil.Click += PcbBolumSil_Click;
            // 
            // PcbBolumDuzenle
            // 
            PcbBolumDuzenle.Image = (Image)resources.GetObject("PcbBolumDuzenle.Image");
            PcbBolumDuzenle.Location = new Point(408, 133);
            PcbBolumDuzenle.Name = "PcbBolumDuzenle";
            PcbBolumDuzenle.Size = new Size(78, 85);
            PcbBolumDuzenle.SizeMode = PictureBoxSizeMode.Zoom;
            PcbBolumDuzenle.TabIndex = 2;
            PcbBolumDuzenle.TabStop = false;
            toolTip1.SetToolTip(PcbBolumDuzenle, "Bölüm Güncelle");
            PcbBolumDuzenle.Click += PcbBolumDuzenle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label1.Location = new Point(55, 37);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 3;
            label1.Text = "Bölüm id :";
            // 
            // TxtBolumid
            // 
            TxtBolumid.Enabled = false;
            TxtBolumid.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TxtBolumid.Location = new Point(183, 27);
            TxtBolumid.Name = "TxtBolumid";
            TxtBolumid.Size = new Size(236, 30);
            TxtBolumid.TabIndex = 4;
            // 
            // TxtBolumAd
            // 
            TxtBolumAd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TxtBolumAd.Location = new Point(183, 77);
            TxtBolumAd.Name = "TxtBolumAd";
            TxtBolumAd.Size = new Size(236, 30);
            TxtBolumAd.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label2.Location = new Point(55, 87);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 5;
            label2.Text = "Bölüm Ad :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(117, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(326, 269);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelekle
            // 
            labelekle.AutoSize = true;
            labelekle.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelekle.Location = new Point(71, 249);
            labelekle.Name = "labelekle";
            labelekle.Size = new Size(46, 22);
            labelekle.TabIndex = 8;
            labelekle.Text = "Ekle";
            // 
            // labelsil
            // 
            labelsil.AutoSize = true;
            labelsil.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelsil.Location = new Point(255, 249);
            labelsil.Name = "labelsil";
            labelsil.Size = new Size(33, 22);
            labelsil.TabIndex = 9;
            labelsil.Text = "Sil";
            // 
            // labelduzen
            // 
            labelduzen.AutoSize = true;
            labelduzen.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelduzen.Location = new Point(408, 249);
            labelduzen.Name = "labelduzen";
            labelduzen.Size = new Size(82, 22);
            labelduzen.TabIndex = 10;
            labelduzen.Text = "Güncelle";
            // 
            // FrmBolumler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(560, 581);
            Controls.Add(labelduzen);
            Controls.Add(labelsil);
            Controls.Add(labelekle);
            Controls.Add(dataGridView1);
            Controls.Add(TxtBolumAd);
            Controls.Add(label2);
            Controls.Add(TxtBolumid);
            Controls.Add(label1);
            Controls.Add(PcbBolumDuzenle);
            Controls.Add(PcbBolumSil);
            Controls.Add(PcbBolumekle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBolumler";
            Text = "Bölümler";
            ((System.ComponentModel.ISupportInitialize)PcbBolumekle).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbBolumSil).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbBolumDuzenle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PcbBolumekle;
        private PictureBox PcbBolumSil;
        private PictureBox PcbBolumDuzenle;
        private Label label1;
        private TextBox TxtBolumid;
        private TextBox TxtBolumAd;
        private Label label2;
        private DataGridView dataGridView1;
        private Label labelekle;
        private Label labelsil;
        private Label labelduzen;
        private ToolTip toolTip1;
    }
}