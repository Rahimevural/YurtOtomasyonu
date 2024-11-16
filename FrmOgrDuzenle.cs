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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }

        public string id, ad, soyad, TC, telefon, dogum, bolum;
        public string mail, odano, veliadsoyad, velitel, veliadres;

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            txtogrid.Text = id;
            txtograd.Text = ad;
            txtogrsoyad.Text = soyad;
            MskTC.Text = TC;
            Mskogrtelefon.Text = telefon;
            MskDogumtarihi.Text = dogum;
            cboxogrbolum.Text = bolum;
            txtmail.Text = mail;
            cboxodano.Text = odano;
            txtveliadsoyad.Text = veliadsoyad;
            Mskvelitelefon.Text = velitel;
            rtextbadres.Text = veliadres;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set ograd=@p2,ogrsoyad=@p3,ogrtc=@p4,ogrtelefon=@p5,ogrdogum=@p6,ogrbolum=@p7,ogrmail=@p8,ogrodano=@p9,ogrveliadsoyad=@p10,ogrvelitelefon=@p11,ogrveliadres=@p12 where ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtogrid.Text);
                komut.Parameters.AddWithValue("@p2", txtograd.Text);
                komut.Parameters.AddWithValue("@p3", txtogrsoyad.Text);
                komut.Parameters.AddWithValue("@p4", MskTC.Text);
                komut.Parameters.AddWithValue("@p5", Mskogrtelefon.Text);
                komut.Parameters.AddWithValue("@p6", MskDogumtarihi.Text);
                komut.Parameters.AddWithValue("@p7", cboxogrbolum.Text);
                komut.Parameters.AddWithValue("@p8", txtmail.Text);
                komut.Parameters.AddWithValue("@p9", cboxodano.Text);
                komut.Parameters.AddWithValue("@p10", txtveliadsoyad.Text);
                komut.Parameters.AddWithValue("@p11", Mskvelitelefon.Text);
                komut.Parameters.AddWithValue("@p12", rtextbadres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kayıt Güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata,yeniden deneyin ", ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Öğrenci Silme 
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where ogrid=@k1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1",txtogrid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt Silindi.");

            // Odanın aktif öğrenci sayısını azaltma 

            SqlCommand komutoda = new SqlCommand("update Odalar set odaaktif= odaaktif-1 where odano=@oda", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda",cboxodano.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
