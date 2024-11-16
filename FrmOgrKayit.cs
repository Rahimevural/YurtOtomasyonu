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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            try
            {
                // b�l�mleri listeleme komutlar�

                SqlCommand komut = new SqlCommand("Select Bolumad From Bolumler", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cboxogrbolum.Items.Add(oku[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata olu�tu: " + ex.Message);
            }
            finally
            {
                bgl.baglanti().Close();

                //Bo� odalar� listeleme komutlar�

                SqlCommand komut2 = new SqlCommand("Select odano From Odalar where odakapasite != odaaktif", bgl.baglanti());// odadaki kapasiteye g�re bo�luk olan odalar� getirir
                SqlDataReader oku2 = komut2.ExecuteReader();
                while (oku2.Read())
                {
                    cboxodano.Items.Add(oku2[0].ToString());
                }
                bgl.baglanti().Close();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            // ��renci bilgilerinin kay�t edilmesi
            try
            {

                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci (ograd,ogrsoyad,ogrtc,ogrtelefon,ogrdogum,ogrbolum,ogrmail,ogrodano,ogrveliadsoyad,ogrvelitelefon,ogrveliadres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());// alanlar� ve kar��l�k olarak parametre ekledik.
                komutkaydet.Parameters.AddWithValue("@p1", txtograd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txtogrsoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", MskTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", Mskogrtelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", MskDogumtarihi.Text);
                komutkaydet.Parameters.AddWithValue("@p6", cboxogrbolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", txtmail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", cboxodano.Text);
                komutkaydet.Parameters.AddWithValue("@p9", txtveliadsoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", Mskvelitelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p11", rtextbadres.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kay�t ba�ar�l� bir �ekilde eklendi.");


                // ogrenci id labele �ekme 
                SqlCommand komut = new SqlCommand("select ogrid from Ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();


                // ��renci bor� alan� olu�turma 

                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar (ogrid,ograd,ogrsoyad) values(@b1,@b2,@b3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", txtograd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", txtogrsoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();



            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!! L�tfen yeniden deneyin.");
            }



            // ��renci oda kontenjan� artt�rma 

            SqlCommand komutoda = new SqlCommand("update Odalar set Odaaktif = odaaktif + 1 where odano=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1",cboxodano.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

      
    }
}
