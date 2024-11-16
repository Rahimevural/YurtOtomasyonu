using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        public string elektrik, su, dogalgaz, gida, diger, internet, personel, id;
        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            txtgiderid.Text = id;
            Txtelektrik.Text = elektrik;
            Txtsu.Text = su;
            txtdogalgaz.Text = dogalgaz;
            txtgida.Text = gida;
            txtdiger.Text = diger;
            txtinternet.Text = internet;
            txtpersonel.Text = personel;
        }

        private void btngiderguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set elektrik = @p1,su=@p2,dogalgaz=@p3,internet=@p4,gida=@p5,personel=@p6,diger=@p7 where odemeid=@p8", bgl.baglanti());
                komut.Parameters.AddWithValue("@p8", txtgiderid.Text);
                komut.Parameters.AddWithValue("@p1", Txtelektrik.Text);
                komut.Parameters.AddWithValue("@p2", Txtsu.Text);
                komut.Parameters.AddWithValue("@p3", txtdogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtinternet.Text);
                komut.Parameters.AddWithValue("@p5", txtgida.Text);
                komut.Parameters.AddWithValue("@p6", txtpersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtdiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Güncelleme Yapıldı");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata",ex.Message);
            }



        }
    }
}
