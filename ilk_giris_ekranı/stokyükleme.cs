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
    public partial class stokyükleme : Form
    {
        public stokyükleme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stokyükleme_Load(object sender, EventArgs e)
        {
            textBox_9.Text = stokyükleilk.ür_adı;
            textBox_8.Text = stokyükleilk.ür_adı;
        }

        private void groupBox2_stokyükle_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            SqlCommand ekle = new SqlCommand();
            baglan.Open();

            if(textBox_12.Text == "")
            {
                textBox_12.Text = 0.ToString();
            }
            ekle.Connection = baglan;
            ekle.CommandText = "INSERT INTO stok_list(stok_adi,stok_kodu,stok_adedi,stok_fiyati,ana_birim,üretici,kdv_dep,alis_fiyat,alis_kdv,stok_nevi,stok_tipi,max_isk) VALUES ('" +textBox_2.Text.ToString()+ "','" +textBox_1.Text.ToString() + "','" +Convert.ToInt32(textBox_12.Text.ToString().TrimEnd()) + "','" + (textBox_10.Text.TrimEnd()) + "','" +textBox_3.Text.ToString()+ "','" +textBox_4.Text.ToString() + "','" +textBox_5.Text.ToString() + "','" +textBox_6.Text.ToString() + "','" +textBox_7.Text.ToString() + "','" +textBox_8.Text.ToString() + "','" +textBox_9.Text.ToString() + "','"  +textBox_11.Text.ToString() + "')";
            ekle.ExecuteNonQuery();

            baglan.Close();
            this.Close();
        }
    }
}
