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
    public partial class cariac : Form
    {
        public cariac()
        {
            InitializeComponent();
        }

        private void stokyükleme1_Load(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            groupBox1.Hide();

            groupBox3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            //SqlCommand ekle = new SqlCommand();
            //baglan.Open();


            //ekle.Connection = baglan;
            //ekle.CommandText = "INSERT INTO cari(firma_adi,firma_kodu,yetkili_adi,tc_kimlik,durum,ünvan,vergi_no,kart_tipi,fat_adres,ilce_semt,sehir,tel_no,gsm,email,faks,top_borc,pesin,bildirim,uyarı_metni,kredikarti) VALUES ('" + textBox_firadı.Text.ToString().TrimEnd() + "','"  + textBox_firkod.Text.ToString().TrimEnd() + "','" + textBox_yetklad.Text.ToString().TrimEnd() + "','" + textBox_tckmlk.Text.ToString().TrimEnd() +"','"+comboBox1_durum.Text.ToString()  + "','" +textBoxünvan.Text.ToUpper().TrimEnd() +"','" +textBox_vergino.Text.ToString().TrimEnd() + "','"+textBox_kart_tipi.Text.ToUpper().TrimEnd() +"','"+richTextBox1_fatadres.Text.ToString().TrimEnd() + "','"+textBox_ilcsemt.Text.ToString().ToUpper().TrimEnd() +"','"+textBox_sehr.Text.ToString().ToUpper().TrimEnd() +"','"+textBox_telno.Text.ToString().TrimEnd() + "','" +textBox_gsm.Text.ToString().TrimEnd() +"','"+textBox_mail.Text.ToString().TrimEnd() + "','" +textBox_faks.Text.ToString() + "','" +textBox_borc.Text.ToString().TrimEnd() + "','" +textBox_pesinödeme.Text.ToString().TrimEnd() + "','" + comboBox1_bildirim.Text + "','" +textBox_uyarmetni.Text.TrimEnd() + "','" + textBox_kredi_kartı.Text.ToString().TrimEnd() +"')";
            //ekle.ExecuteNonQuery();

            //baglan.Close();
            //this.Close();
        }
       
    }
}
