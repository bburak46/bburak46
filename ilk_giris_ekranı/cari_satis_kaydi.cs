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
    public partial class cari_satis_kaydi : Form
    {
        public cari_satis_kaydi()
        {
            InitializeComponent();
        }

        private void cari_satis_kaydi_Load(object sender, EventArgs e)
        {
            //SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = "SELECT * FROM cari";
            //komut.Connection = baglan;
            //komut.CommandType = CommandType.Text;

            //SqlDataReader dr;
            //baglan.Open();
            //dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    comboBox1.Items.Add(dr["firma_adi"].ToString().TrimEnd());

            //}
            //comboBox1.AutoCompleteCustomSource.Add(comboBox1.Items.ToString());

            //baglan.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(comboBox1.Text.ToString().TrimEnd() !=  "")
            //{
            //    SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            //    baglan.Open();


            //    DataTable tbl = new DataTable();
            //    string vara, cumle;
            //    vara = comboBox1.Text.Trim();
            //    cumle = "Select * from cari_satis_kaydi where cari_adi  like '%" + comboBox1.Text.TrimEnd() + "%'";

            //    SqlDataAdapter adptr = new SqlDataAdapter(cumle, baglan);
            //    adptr.Fill(tbl);
            //    baglan.Close();

            //    dataGridView1_cari_sat_kay.DataSource = tbl;

            //    string[] headernme = { "ID", "STOK KODU", "STOK ADI", "ADET", "BİRİM", "KDV", "İSK", "BİRİM FİYAT", "TOPLAM TUTAR", "TARİH", "CARİ ADI", "PERSONEL" };
            //    for (int i = 0; i < 12; i++)
            //    {
            //        dataGridView1_cari_sat_kay.Columns[i].HeaderText = headernme[i];
            //    }
            //    dataGridView1_cari_sat_kay.Columns[0].Width = 5;
            //    decimal toptutar = 0;
            //    for (int i = 0; i < dataGridView1_cari_sat_kay.Rows.Count - 1; i++)
            //    {
            //        toptutar += Convert.ToDecimal(dataGridView1_cari_sat_kay.Rows[i].Cells[8].Value);
            //    }
            //    textBox1.Text = toptutar.ToString();
            //}

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void dataGridView1_cari_sat_kay_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Size =new Size(1536,778);
                button2.Visible = true;
                button3.Visible = true;

            }
        }

        void KayıtSil(int id)
        {
            //SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            //string sql = "DELETE FROM cari_satis_kaydi WHERE id=@id  ";
            //SqlCommand komut = new SqlCommand(sql, baglan);
            //komut.Parameters.AddWithValue("@id", id);
            //baglan.Open();
            //komut.ExecuteNonQuery();
            //baglan.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            //dataGridView1_cari_sat_kay.AllowUserToDeleteRows = true;
            //baglan.Open();
            //SqlCommand ekle = new SqlCommand();
            //ekle.Connection = baglan;
 
            //    int id = Convert.ToInt32(dataGridView1_cari_sat_kay.CurrentRow.Cells[0].Value.ToString().TrimEnd());

            //    KayıtSil(id);
            //    string sql1 = "update stok_list set stok_adedi = stok_adedi + '" + Convert.ToInt32(dataGridView1_cari_sat_kay.CurrentRow.Cells[3].Value.ToString().TrimEnd()) + "' where stok_kodu = '" + dataGridView1_cari_sat_kay.CurrentRow.Cells[1].Value.ToString().TrimEnd() + "' ";
                
            //    ekle.CommandText = "INSERT INTO iade_list(stok_kodu,stok_adi,adet,birim,kdv,isk,birim_fiyat,toplam_tutar,tarih,cari_adi,personel_adi) VALUES ('" + dataGridView1_cari_sat_kay.CurrentRow.Cells[1].Value.ToString() + "','" + dataGridView1_cari_sat_kay.CurrentRow.Cells[2].Value.ToString() + "','" + (dataGridView1_cari_sat_kay.CurrentRow.Cells[3].Value.ToString()) + "','" + dataGridView1_cari_sat_kay.CurrentRow.Cells[4].Value.ToString() + "','" + dataGridView1_cari_sat_kay.CurrentRow.Cells[5].Value.ToString() + "','"+ dataGridView1_cari_sat_kay.CurrentRow.Cells[6].Value.ToString() + "','" + dataGridView1_cari_sat_kay.CurrentRow.Cells[7].Value.ToString() + "','" + dataGridView1_cari_sat_kay.CurrentRow.Cells[8].Value.ToString() + "','" + (dataGridView1_cari_sat_kay.CurrentRow.Cells[9].Value.ToString() +" "+  dateTimePicker1.Value.ToString()) + "','" + dataGridView1_cari_sat_kay.CurrentRow.Cells[10].Value.ToString() + "','" + dataGridView1_cari_sat_kay.CurrentRow.Cells[11].Value.ToString() + "')";
            //    ekle.ExecuteNonQuery();
            //    SqlCommand cmd = new SqlCommand(sql1, baglan);
            //    cmd.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
            
            //baglan.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {



            //SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            //baglan.Open();


            //DataTable tbl = new DataTable();
            //string vara, cumle;
            //vara = comboBox1.Text.Trim();
            //cumle = "Select * from cari_satis_kaydi where cari_adi  like '%" + comboBox1.Text.TrimEnd() + "%'";

            //SqlDataAdapter adptr = new SqlDataAdapter(cumle, baglan);
            //adptr.Fill(tbl);
            //baglan.Close();

            //dataGridView1_cari_sat_kay.DataSource = tbl;

            //string[] headernme = { "ID", "STOK KODU", "STOK ADI", "ADET", "BİRİM", "KDV", "İSK", "BİRİM FİYAT", "TOPLAM TUTAR", "TARİH", "CARİ ADI", "PERSONEL" };
            //for (int i = 0; i < 12; i++)
            //{
            //    dataGridView1_cari_sat_kay.Columns[i].HeaderText = headernme[i];
            //}
            //decimal toptutar = 0;
            //for (int i = 0; i < dataGridView1_cari_sat_kay.Rows.Count - 1; i++)
            //{
            //    toptutar += Convert.ToDecimal(dataGridView1_cari_sat_kay.Rows[i].Cells[8].Value);
            //}
            //textBox1.Text = toptutar.ToString();


        }
    }
}
