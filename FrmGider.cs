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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Giderler (elektrik,su,dogalgaz,internet,gida,personel,diger) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtelektrik.Text);
                komut.Parameters.AddWithValue("@p2", Txtsu.Text);
                komut.Parameters.AddWithValue("@p3", txtdogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtinternet.Text);
                komut.Parameters.AddWithValue("@p5", txtgida.Text);
                komut.Parameters.AddWithValue("@p6", txtpersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtdiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kayıtlar Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA!!!", ex.Message);
            }
        }
    }
}
