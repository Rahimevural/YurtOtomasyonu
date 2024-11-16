using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace YurtKayitSistemi
{
    public partial class FrmGelirİstatistik : Form
    {
        public FrmGelirİstatistik()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        // kasadaki toplam tutar
        private void FrmGelirİstatistik_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum (odememiktar) from Kasa", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblpara.Text = oku[0].ToString() + " TL";
            }
            bgl.baglanti().Close();
            // tekrarsız olarak ayları listeleme 

            SqlCommand komut2 = new SqlCommand("select distinct(odemeay) from Kasa", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cboxay.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();


            // Grafiklere veritabanından veri çekme

            SqlCommand komut3 = new SqlCommand("select odemeay, sum(odememiktar) from Kasa group by odemeay", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }
            bgl.baglanti().Close();

        }

        private void cboxay_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("select sum(odememiktar) from Kasa where odemeay=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cboxay.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblaykazanc.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
