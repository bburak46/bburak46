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
     
    public partial class From1 : Form
    {
        public static int günsay;
        public static string personl;
        anaform sıfrekont = new anaform();
        

        public From1()
        {
            InitializeComponent();
        }

        private void From1_Load(object sender, EventArgs e)
        {

            //SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            //string sql = "DELETE FROM per_satis_kaydi WHERE kdv= "+18+"  ";
            //SqlCommand komut = new SqlCommand(sql, baglan);
  
            //baglan.Open();
            //komut.ExecuteNonQuery();
            //baglan.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_bayisecimitik_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void From1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_kullanıcıadıgiris_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_sifregiris_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public static string kullanıcı_adı;
        public static string sıfre;
        private void button1_sifreonay_Click(object sender, EventArgs e)
        {
            ////SqlConnection baglantı = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
            //kullanıcı_adı = textBox2_kullanıcıadıgiris.Text.TrimEnd();
            //sıfre = textBox1_sifregiris.Text.TrimEnd();
            //con = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
            //cmd = new SqlCommand();
            //con.Open();
            //cmd.Connection = con;
            //cmd.CommandText = "SELECT * FROM personel_list where kullanıcı_adi='" + textBox2_kullanıcıadıgiris.Text.TrimEnd() + "' AND sifre_1='" + textBox1_sifregiris.Text.TrimEnd() + "'";
            //dr = cmd.ExecuteReader();

            //if (dr.Read())
            //{
            //    personl = textBox2_kullanıcıadıgiris.Text.TrimEnd().ToString();
            //    sıfrekont.Show();
            //    this.Hide();
            //}
            //else if(textBox2_kullanıcıadıgiris.Text == "" || textBox1_sifregiris.Text == "")
            //{
            //    label1_uyarısıfre.Text = "Kullanıcı Adı Veya Şifre Boş Bırakılamaz !";
            //    label1_uyarısıfre.Show();
            //}
            //else
            //{
            //    label1_uyarısıfre.Text = "Kullanıcı Adı Veya Şifre Hatalı !";
            //    label1_uyarısıfre.Show();
            //}
            //con.Close();

            sıfrekont.Show();
            this.Hide();


        }

        private void From1_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
