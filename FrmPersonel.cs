using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
            listele();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        public void listele()
        {
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("select * from Personel", bgl.baglanti());
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.Columns[0].HeaderText = "personelid";
                dataGridView1.Columns[1].HeaderText = "personeladsoyad";
                dataGridView1.Columns[2].HeaderText = "personeldepartman";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("HATA !!! " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string personelid, personeladsoyad, personeldepartman;


            personelid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            personeladsoyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            personeldepartman = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtpersonelid.Text = personelid;
            txtpersonelad.Text = personeladsoyad;
            txtpersonelgorev.Text = personeldepartman;

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel(personeladsoyad,personeldepartman) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtpersonelad.Text);
            komut.Parameters.AddWithValue("@p2", txtpersonelgorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt eklendi.");


        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where personelid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtpersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt Silindi.");

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personel set personeladsoyad=@p1,personeldepartman=@p2 where personelid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtpersonelad.Text);
            komut.Parameters.AddWithValue("@p2", txtpersonelgorev.Text);
            komut.Parameters.AddWithValue("@p3", txtpersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt Güncellendi");
            

        }
    }
}
