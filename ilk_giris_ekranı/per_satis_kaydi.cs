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

namespace ilk_giris_ekranı
{
    public partial class per_satis_kaydi : Form
    {


        public per_satis_kaydi()
        {
            InitializeComponent();
        }
        decimal toptutar;
        private void per_satis_kaydi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'carilerDataSet62.per_satis_kaydi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.per_satis_kaydiTableAdapter.Fill(this.carilerDataSet62.per_satis_kaydi);




            string[] headernme = {"ID" ,"STOK KODU", "STOK ADI", "ADET", "BİRİM", "KDV", "İSK", "BİRİM FİYAT", "TOPLAM TUTAR", "TARİH", "PERSONEL" };
    
            for (int i = 0; i < 11; i++)
            {
                dataGridView1_per_sat_kay.Columns[i].HeaderText = headernme[i];
            }
            for(int k = 0; k < dataGridView1_per_sat_kay.Rows.Count; k++)
            {
                toptutar += Convert.ToDecimal( dataGridView1_per_sat_kay.Rows[k].Cells[8].Value);

            }
            textBox1.Text = toptutar.ToString();
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void dataGridView1_per_sat_kay_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show("İADE MODU AKTİF");
                button2.Visible = true;
                button3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.per_satis_kaydiTableAdapter.Fill(this.carilerDataSet62.per_satis_kaydi);
        }
        void KayıtSil(int id)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            string sql = "DELETE FROM per_satis_kaydi WHERE id=@id  ";
            SqlCommand komut = new SqlCommand(sql, baglan);
            komut.Parameters.AddWithValue("@id", id);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            dataGridView1_per_sat_kay.AllowUserToDeleteRows = true;
            baglan.Open();
            SqlCommand ekle = new SqlCommand();
            ekle.Connection = baglan;

            int id = Convert.ToInt32(dataGridView1_per_sat_kay.CurrentRow.Cells[0].Value.ToString().TrimEnd());

            KayıtSil(id);
            string sql1 = "update stok_list set stok_adedi = stok_adedi + '" + Convert.ToInt32(dataGridView1_per_sat_kay.CurrentRow.Cells[3].Value.ToString().TrimEnd()) + "' where stok_kodu = '" + dataGridView1_per_sat_kay.CurrentRow.Cells[1].Value.ToString().TrimEnd() + "' ";

            ekle.CommandText = "INSERT INTO iade_list(stok_kodu,stok_adi,adet,birim,kdv,isk,birim_fiyat,toplam_tutar,tarih,cari_adi,personel_adi) VALUES ('" + dataGridView1_per_sat_kay.CurrentRow.Cells[1].Value.ToString() + "','" + dataGridView1_per_sat_kay.CurrentRow.Cells[2].Value.ToString() + "','" + (dataGridView1_per_sat_kay.CurrentRow.Cells[3].Value.ToString()) + "','" + dataGridView1_per_sat_kay.CurrentRow.Cells[4].Value.ToString() + "','" + dataGridView1_per_sat_kay.CurrentRow.Cells[5].Value.ToString() + "','" + dataGridView1_per_sat_kay.CurrentRow.Cells[6].Value.ToString() + "','" + dataGridView1_per_sat_kay.CurrentRow.Cells[7].Value.ToString() + "','" + dataGridView1_per_sat_kay.CurrentRow.Cells[8].Value.ToString() + "','" + (dataGridView1_per_sat_kay.CurrentRow.Cells[9].Value.ToString() + " " + dateTimePicker1.Value.ToShortDateString().ToString()) + "','" + "PERAKENDE" + "','" + dataGridView1_per_sat_kay.CurrentRow.Cells[10].Value.ToString() + "')";
            ekle.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand(sql1, baglan);
            cmd.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.

            baglan.Close();
        }
    }
}