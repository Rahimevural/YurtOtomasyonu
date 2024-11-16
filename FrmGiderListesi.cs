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
    public partial class FrmGiderListesi : Form
    {
        public FrmGiderListesi()
        {
            InitializeComponent();
            listele();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        public void listele()
        {

            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * From Giderler", bgl.baglanti());
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.Columns[0].HeaderText = "odemeid";
                dataGridView1.Columns[1].HeaderText = "elektrik";
                dataGridView1.Columns[2].HeaderText = "su";
                dataGridView1.Columns[3].HeaderText = "dogalgaz";
                dataGridView1.Columns[4].HeaderText = "internet";
                dataGridView1.Columns[5].HeaderText = "gida";
                dataGridView1.Columns[6].HeaderText = "personel";
                dataGridView1.Columns[7].HeaderText = "diger";
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata", ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmGiderGuncelle frg = new FrmGiderGuncelle();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frg.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frg.elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frg.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frg.dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frg.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frg.gida = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frg.personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frg.diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frg.Show();
        }
    }
}
