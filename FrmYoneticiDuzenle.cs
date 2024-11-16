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
using System.Data.SqlClient;


namespace YurtKayitSistemi
{
    public partial class FrmYoneticiDuzenle : Form
    {
        public FrmYoneticiDuzenle()
        {
            InitializeComponent();
            listele();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        public void listele()
        {
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("select * from Admin", bgl.baglanti());
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.Columns[0].HeaderText = "yoneticiid";
                dataGridView1.Columns[1].HeaderText = "yoneticiad";
                dataGridView1.Columns[2].HeaderText = "yoneticisifre";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("HATA !!! " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Admin(yoneticiad,yoneticisifre) values(@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkullaniciad.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Yönetici eklendi.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            string ad, sifre, id;

            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtkullaniciad.Text = ad;
            txtsifre.Text = sifre;
            txtyoneticiid.Text = id;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Admin where yoneticiid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtyoneticiid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Silme işlemi gerçekleşti");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Admin set yoneticiad=@p1,yoneticisifre=@p2 where yoneticiid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkullaniciad.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);
            komut.Parameters.AddWithValue("@p3", txtyoneticiid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Güncelleme işlemi gerçekleşti.");
        }
    }
}