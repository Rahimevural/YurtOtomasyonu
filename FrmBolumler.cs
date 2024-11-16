using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
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
    public partial class FrmBolumler : Form
    {

        public FrmBolumler()
        {
            InitializeComponent();
            listele();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        public void listele()
        {
            try
            {
                
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Bolumler", bgl.baglanti());
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                // Kolon isimlerini doğru indekslerle ayarlayın
                dataGridView1.Columns[0].HeaderText = "bolumid";
                dataGridView1.Columns[1].HeaderText = "bolumad";
                bgl.baglanti().Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("HATA !!! " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PcbBolumekle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (bolumad) values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Bölüm Eklendi");
            }
            catch
            {
                MessageBox.Show("Hata oluştu yeniden deneyin");
            }
        }

        private void PcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where bolumid=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtBolumid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme işlemi gerçekleşti");
            }
            catch
            {
                MessageBox.Show("Hata,işlem gerçekleşmedi");
            }
        }


        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            TxtBolumid.Text = id;
            TxtBolumAd.Text = bolumad;
        }

        private void PcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("update Bolumler Set bolumad=@p1 where bolumid=@p2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p2", TxtBolumid.Text);
                komut2.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Gerçekleşti");
            }
            catch
            {
                MessageBox.Show("HATA");
            }
        }
    }
}
