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
    public partial class stok_sil : Form
    {
        public stok_sil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stok_sil_Load(object sender, EventArgs e)
        {


            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            baglan.Open();
            SqlCommand komut = new SqlCommand();

            komut.Connection = baglan;
            komut.CommandText = "Select * from stok_list where stok_kodu = '" +stokgör.dgr1 + "'";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textbox__1.Text = dr["stok_kodu"].ToString().TrimEnd();
                textbox__2.Text = dr["stok_adi"].ToString().TrimEnd();
                textBox_12.Text = dr["stok_adedi"].ToString().TrimEnd();
                textbox__3.Text = dr["ana_birim"].ToString().TrimEnd();
                textbox__4.Text = dr["üretici"].ToString().TrimEnd();
                textbox__5.Text = dr["kdv_dep"].ToString().TrimEnd();
                textbox__6.Text = dr["alis_fiyat"].ToString().TrimEnd();
                textbox__7.Text = dr["alis_kdv"].ToString().TrimEnd();
                textbox__8.Text = dr["stok_nevi"].ToString().TrimEnd();
                textbox__9.Text = dr["stok_tipi"].ToString().TrimEnd();
                textbox__10.Text = dr["stok_fiyati"].ToString().TrimEnd();
                textbox__11.Text = dr["max_isk"].ToString().TrimEnd();
            }
            else
            {
                MessageBox.Show("VERİ BULUNAMADI");
            }
            baglan.Dispose();
            baglan.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            textbox__1.ReadOnly = false;
            textbox__2.ReadOnly = false;
            textbox__3.ReadOnly = false;
            textbox__4.ReadOnly = false;
            textbox__5.ReadOnly = false;
            textbox__6.ReadOnly = false;
            textbox__7.ReadOnly = false;
            textbox__8.ReadOnly = false;
            textbox__9.ReadOnly = false;
            textbox__10.ReadOnly = false;
            textbox__11.ReadOnly = false;
            textBox_12.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            string sql = "update stok_list set stok_adi = '"+textbox__2.Text.ToString().TrimEnd() + "' , stok_kodu = '"+textbox__1.Text.ToString().TrimEnd()+ "',stok_adedi = '"+Convert.ToInt32(textBox_12.Text.TrimEnd())+ "',stok_fiyati = '"+Convert.ToDecimal(textbox__10.Text.TrimEnd())+ "',ana_birim = '"+textbox__3.Text.TrimEnd()+ "',üretici = '"+textbox__4.Text.TrimEnd()+ "',kdv_dep = '"+textbox__5.Text.TrimEnd()+ "',alis_fiyat= '"+(textbox__6.Text.TrimEnd())+ "',alis_kdv= '"+(textbox__7.Text.TrimEnd())+ "',stok_nevi = '"+textbox__8.Text.TrimEnd()+ "',stok_tipi = '"+textbox__9.Text.TrimEnd() + "',max_isk = '"+(textbox__11.Text.TrimEnd())+"'  where stok_kodu = '" + textbox__1.Text.TrimEnd().ToString() + "' ";
            baglan.Open();
            SqlCommand cmd = new SqlCommand(sql, baglan);
            cmd.ExecuteNonQuery(); // sql sorgusunu işleme ko


            baglan.Close();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
            string stkkodu = textbox__1.Text.TrimEnd();
            string sql = "DELETE FROM stok_list WHERE stok_kodu=@stok_kodu  ";
            SqlCommand komut = new SqlCommand(sql, baglan);

            komut.Parameters.AddWithValue("@stok_kodu", stkkodu);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            this.Close();
        }
    }
}
