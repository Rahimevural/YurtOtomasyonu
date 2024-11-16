namespace YurtKayitSistemi
{
    partial class FrmGelirİstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirİstatistik));
            label1 = new Label();
            lblpara = new Label();
            cboxay = new ComboBox();
            label2 = new Label();
            lblaykazanc = new Label();
            label4 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(425, 17);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 0;
            label1.Text = "Kasadaki Para : ";
            // 
            // lblpara
            // 
            lblpara.AutoSize = true;
            lblpara.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblpara.Location = new Point(581, 17);
            lblpara.Name = "lblpara";
            lblpara.Size = new Size(20, 23);
            lblpara.TabIndex = 1;
            lblpara.Text = "0";
            // 
            // cboxay
            // 
            cboxay.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxay.FormattingEnabled = true;
            cboxay.Location = new Point(128, 12);
            cboxay.Name = "cboxay";
            cboxay.Size = new Size(237, 30);
            cboxay.TabIndex = 2;
            cboxay.SelectedIndexChanged += cboxay_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "Ay Seçin : ";
            // 
            // lblaykazanc
            // 
            lblaykazanc.AutoSize = true;
            lblaykazanc.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblaykazanc.Location = new Point(581, 53);
            lblaykazanc.Name = "lblaykazanc";
            lblaykazanc.Size = new Size(20, 23);
            lblaykazanc.TabIndex = 5;
            lblaykazanc.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(457, 53);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 4;
            label4.Text = "Seçilen Ay :";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(12, 150);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Aylık";
            chart1.Series.Add(series1);
            chart1.Size = new Size(651, 375);
            chart1.TabIndex = 6;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // FrmGelirİstatistik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(704, 548);
            Controls.Add(chart1);
            Controls.Add(lblaykazanc);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(cboxay);
            Controls.Add(lblpara);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGelirİstatistik";
            Text = "Gelir İstatistik";
            Load += FrmGelirİstatistik_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblpara;
        private ComboBox cboxay;
        private Label label2;
        private Label lblaykazanc;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}