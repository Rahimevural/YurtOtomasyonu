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
    public partial class FrmOgrListe : Form
    {
        public FrmOgrListe()
        {
            InitializeComponent();
            listele();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        public void listele()
        {
            try
            {

                SqlDataAdapter ad = new SqlDataAdapter("SELECT * From Ogrenci", bgl.baglanti());
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                // Kolon isimlerini doğru indekslerle ayarlayın
                dataGridView1.Columns[0].HeaderText = "ogrid";
                dataGridView1.Columns[1].HeaderText = "ograd";
                dataGridView1.Columns[2].HeaderText = "ogrsoyad";
                dataGridView1.Columns[3].HeaderText = "ogrtc";
                dataGridView1.Columns[4].HeaderText = "ogrtelefon";
                dataGridView1.Columns[5].HeaderText = "ogrdogum";
                dataGridView1.Columns[6].HeaderText = "ogrbolum";
                dataGridView1.Columns[7].HeaderText = "ogrmail";
                dataGridView1.Columns[8].HeaderText = "ogrodano";
                dataGridView1.Columns[9].HeaderText = "ogrveliadsoyad";
                dataGridView1.Columns[10].HeaderText = "ogrvelitelefon";
                dataGridView1.Columns[11].HeaderText = "ogrveliadres";
                bgl.baglanti().Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("HATA !!! " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // düzenle ekranına öğrenci bilgilerini getiriyorum.
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDuzenle fr = new FrmOgrDuzenle();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.TC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.dogum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.bolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.odano = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.veliadsoyad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.velitel = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.veliadres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            
            fr.Show();
        }
    }
}
