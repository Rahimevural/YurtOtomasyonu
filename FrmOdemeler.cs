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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
            listele();

        }
        SqlBaglantim bgl = new SqlBaglantim();

        public void listele()
        {
            try
            {

                SqlDataAdapter ad = new SqlDataAdapter("SELECT ogrid,ograd,ogrsoyad,ogrkalanborc from Borclar", bgl.baglanti());
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                // Kolon isimlerini doğru indekslerle ayarlayın
                dataGridView1.Columns[0].HeaderText = "ogrid";
                dataGridView1.Columns[1].HeaderText = "ograd";
                dataGridView1.Columns[2].HeaderText = "ogrsoyad";
                dataGridView1.Columns[3].HeaderText = "ogrkalanborc";
                bgl.baglanti().Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("HATA !!! " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            Txtograd.Text = ad;
            Txtogrsoyad.Text = soyad;
            TxtKalan.Text = kalan;
            TxtOgrenciid.Text = id;
        }

        private void btnOdemeal_Click(object sender, EventArgs e)
        {
            // ödenen tutarı toplam borctan düşme 
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(TxtOdenen.Text);
            kalan = Convert.ToInt16(TxtKalan.Text);

            yeniborc = kalan - odenen;
            TxtKalan.Text = yeniborc.ToString();

            // yeni tutarı veritabanına kaydetme 
            SqlCommand komut = new SqlCommand("update Borclar set ogrkalanborc = @p1 where ogrid =@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", TxtOgrenciid.Text);
            komut.Parameters.AddWithValue("@p1", TxtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi.");


            // Kasa tablosuna ekleme yapma

            SqlCommand komut2 = new SqlCommand("insert into Kasa (odemeay,odememiktar) values (@k1,@k2)",bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1",txtodenenay.Text);
            komut2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            Temizle();
            listele();




        }
        // Ekranı temizlemek için oluşturdum.
        private void Temizle()
        {
            TxtOgrenciid.Text = "";
            Txtograd.Text = "";
            Txtogrsoyad.Text = "";
            TxtKalan.Text = "";
            TxtOdenen.Text = "";
            txtodenenay.Text = "";
            
        }

        
    }
}

