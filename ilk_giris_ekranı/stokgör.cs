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
    public partial class stokgör : Form
    {
        public stokgör()
        {
            InitializeComponent();
        }

        private void stokgör_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'carilerDataSet55.stok_list' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stok_listTableAdapter1.Fill(this.carilerDataSet55.stok_list);



        }
        public static string dgr1;


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            baglan.Open();


            DataTable tbl = new DataTable();
            string vara, cumle;
            vara = textBox1.Text.Trim();
            cumle = "Select * from stok_list where stok_adi + stok_kodu   like '%" + textBox1.Text.TrimEnd() + "%'";

            SqlDataAdapter adptr = new SqlDataAdapter(cumle, baglan);
            adptr.Fill(tbl);
            baglan.Close();

            dataGridView1.DataSource = tbl;

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgr1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            stok_sil sl = new stok_sil();
            sl.Show();
            this.stok_listTableAdapter1.Fill(this.carilerDataSet55.stok_list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
            string stkkodu = dataGridView1.CurrentRow.Cells[1].Value.ToString().TrimEnd();
            string sql = "DELETE FROM stok_list WHERE stok_kodu=@stok_kodu  ";
            SqlCommand komut = new SqlCommand(sql, baglan);

            komut.Parameters.AddWithValue("@stok_kodu", stkkodu);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("STOK BAŞARIYLA SİLİNDİ");
            this.stok_listTableAdapter1.Fill(this.carilerDataSet55.stok_list);
        }

    }
}
