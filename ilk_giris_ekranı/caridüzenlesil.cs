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
    public partial class caridüzenlesil : Form
    {
        public caridüzenlesil()
        {
            InitializeComponent();
        }

        private void boş_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'carilerDataSet64.cari' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.cariTableAdapter.Fill(this.carilerDataSet64.cari);


            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[15].Value = (Convert.ToDouble(Convert.ToInt32(dataGridView1.Rows[i].Cells[15].Value.ToString().TrimEnd()) * 0.01)).ToString();
                dataGridView1.Rows[i].Cells[16].Value = (Convert.ToDouble(Convert.ToInt32(dataGridView1.Rows[i].Cells[16].Value.ToString().TrimEnd()) * 0.01)).ToString();
                dataGridView1.Rows[i].Cells[19].Value = (Convert.ToDouble(Convert.ToInt32(dataGridView1.Rows[i].Cells[19].Value.ToString().TrimEnd()) * 0.01)).ToString();
            }
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            //baglan.Open();


            //DataTable tbl = new DataTable();
            //string vara, cumle;
            //vara = textBox1.Text;
            //cumle = "Select * from cari where firma_adi + firma_kodu like '%" + textBox1.Text + "%'";

            //SqlDataAdapter adptr = new SqlDataAdapter(cumle, baglan);
            //adptr.Fill(tbl);
            //baglan.Close();

            //dataGridView1.DataSource = tbl;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //caridüzesilson göster = new caridüzesilson();
            //göster.label18.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString().TrimEnd().ToUpper() + " - " + dataGridView1.SelectedRows[0].Cells[5].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_firkod.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_firmad.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_ytklad.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_vergi.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_karttipi.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_tc.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_ünvan.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString().TrimEnd().ToUpper();
            //göster.richTextBox_fatadres.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_ilcesmt.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_shr.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_tel.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_email.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_gsm.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_faks.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_pesinödeme.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString().TrimEnd();
            //göster.textBox_kredi_kartı.Text = dataGridView1.SelectedRows[0].Cells[19].Value.ToString().TrimEnd();
            //göster.textBox_borc.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString().TrimEnd();
            //göster.comboBox1_durum.Text= dataGridView1.SelectedRows[0].Cells[4].Value.ToString().TrimEnd().ToUpper();
            //göster.comboBox1_bildirim.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString().TrimEnd().ToUpper();
            //göster.textBox_uyarmetni.Text = dataGridView1.SelectedRows[0].Cells[18].Value.ToString().TrimEnd().ToUpper();

            //göster.Show();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
            //string firkodu = dataGridView1.CurrentRow.Cells[1].Value.ToString().TrimEnd();
            //string sql = "DELETE FROM cari WHERE firma_kodu=@firma_kodu  ";
            //SqlCommand komut = new SqlCommand(sql, baglan);

            //komut.Parameters.AddWithValue("@firma_kodu", firkodu);
            //baglan.Open();
            //komut.ExecuteNonQuery();
            //baglan.Close();
            //this.cariTableAdapter.Fill(this.carilerDataSet64.cari);
        }
    }
}
