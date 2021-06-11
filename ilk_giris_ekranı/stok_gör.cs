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
    public partial class stok_gör : Form
    {
        
        public stok_gör()
        {
            InitializeComponent();
        }
       
        private void stok_gör_Load(object sender, EventArgs e)
        {



            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            baglan.Open();
            SqlCommand komut = new SqlCommand();
            
            komut.Connection = baglan;
            komut.CommandText = "Select * from stok_list where stok_kodu = '"+stokara.dgr +"' ";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox2_stokyükle.Text = dr["stok_kodu"].ToString().TrimEnd();
    
                textBox1_stokyükle.Text = dr["stok_adi"].ToString().TrimEnd();
                textBox1.Text = dr["ana_birim"].ToString().TrimEnd();
                textBox1_stokyükle1.Text = dr["üretici"].ToString().TrimEnd();
                textBox4.Text = dr["kdv_dep"].ToString().TrimEnd();
                textBox3_stokyükle1.Text = dr["alis_fiyat"].ToString().TrimEnd();
                textBox2_stokyükle1.Text = dr["alis_kdv"].ToString().TrimEnd();
                textBox2.Text = dr["stok_nevi"].ToString().TrimEnd();
                textBox3.Text = dr["stok_tipi"].ToString().TrimEnd();
                textBox1_stkyklfyt.Text = dr["stok_fiyati"].ToString().TrimEnd();
                textBox4_stokyükle1.Text = dr["max_isk"].ToString().TrimEnd();
                textBox5.Text = dr["stok_adedi"].ToString().TrimEnd();
            }
            else
            {
                MessageBox.Show("VERİ BULUNAMADI");
            }
            baglan.Dispose();
            baglan.Close();
            decimal a = Convert.ToDecimal(textBox3_stokyükle1.Text);//alis
            decimal b = Convert.ToDecimal(textBox2_stokyükle1.Text);//aliskdv
            decimal c = Convert.ToDecimal(textBox1_stkyklfyt.Text);//stokfiyat

            double netalis = Convert.ToDouble(a + (a * Convert.ToDecimal(0.18)));
            double ciro = Convert.ToDouble(c + (c * Convert.ToDecimal(0.18)))-netalis;
           
            textBox_netciro.Text = ciro.ToString();
        }


    }
}
