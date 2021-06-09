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
    public partial class caridüzesilson : Form
    {
        public caridüzesilson()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox3.Hide();
        }

        private void caridüzesilson_Load(object sender, EventArgs e)
        {
            groupBox1.Show();
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();

            groupBox3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_kredi_kartı.ReadOnly = false;
            textBox_borc.ReadOnly = false;
            textBox_firmad.ReadOnly = false;
            textBox_vergi.ReadOnly = false;
            textBox_karttipi.ReadOnly = false;
            textBox_tc.ReadOnly = false;
            textBox_ünvan.ReadOnly = false;
            textBox_ytklad.ReadOnly = false;
            textBox_firkod.ReadOnly = false;
            textBox_tel.ReadOnly = false;
            textBox_email.ReadOnly = false;
            textBox_gsm.ReadOnly = false;
            textBox_faks.ReadOnly = false;
            textBox_shr.ReadOnly = false;
            textBox_ilcesmt.ReadOnly = false;
            richTextBox_fatadres.ReadOnly = false;
            textBox_uyarmetni.ReadOnly = false;
            comboBox1_bildirim.Enabled = true;
            comboBox1_durum.Enabled = true;
            textBox_kredi_kartı.ReadOnly = false;
            textBox_pesinödeme.ReadOnly = false;
            label20.Text = "Düzenleme Aktif";
            label20.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            //SqlCommand ekle = new SqlCommand();
            //baglan.Open();
   


            //ekle.Connection = baglan;
            //ekle.CommandText = "UPDATE  cari set  firma_adi = '" + textBox_firmad.Text.ToString().TrimEnd() + "' , firma_kodu = '" + textBox_firkod.Text.ToString().TrimEnd() + "',yetkili_adi = '" + textBox_ytklad.Text.ToString().TrimEnd() + "', tc_kimlik = '" + textBox_tc.Text.ToString().TrimEnd() + "',durum= '" + comboBox1_durum.Text.ToString().TrimEnd() + "',ünvan= '" + textBox_ünvan.Text.ToString().TrimEnd() + "',vergi_no= '" + textBox_vergi.Text.ToString().TrimEnd() + "',kart_tipi= '" + textBox_karttipi.Text.ToString().TrimEnd() + "',fat_adres= '" + richTextBox_fatadres.Text.ToString().TrimEnd() + "',ilce_semt= '" + textBox_ilcesmt.Text.ToString().TrimEnd() + "',sehir= '" + textBox_shr.Text.ToString().TrimEnd() + "',tel_no= '" + textBox_tel.Text.ToString().TrimEnd() + "',gsm= '" + textBox_gsm.Text.ToString().TrimEnd() + "',email= '" + textBox_email.Text.ToString().TrimEnd() + "',faks= '" + textBox_faks.Text.ToString().TrimEnd() + "',top_borc= '" + textBox_borc.Text.ToString().TrimEnd() + "',pesin= '" + textBox_pesinödeme.Text.ToString().TrimEnd() + "',bildirim= '" + comboBox1_bildirim.Text.ToString().TrimEnd() + "',uyarı_metni= '" + textBox_uyarmetni.Text.ToString().TrimEnd() +  "' ,kredikarti= '" +textBox_kredi_kartı.Text.ToString().TrimEnd() + "' where firma_kodu= '" + textBox_firkod.Text.ToString().TrimEnd() + "' ";
            //ekle.ExecuteNonQuery();
            //MessageBox.Show("KAYIT BAŞARIYLA GÜNCELLENDİ");
            //baglan.Close();
            //this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
            //string firkodu = textBox_firkod.Text.ToString().TrimEnd();
            //string sql = "DELETE FROM cari WHERE firma_kodu=@firma_kodu  ";
            //SqlCommand komut = new SqlCommand(sql, baglan);

            //komut.Parameters.AddWithValue("@firma_kodu", firkodu);
            //baglan.Open();
            //komut.ExecuteNonQuery();
            //baglan.Close();
            //this.Close();
        }
    }


    }

