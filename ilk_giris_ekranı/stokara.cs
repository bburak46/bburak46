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
    
    public partial class stokara : Form
    {
        public string  veri;
        public string veri1;

        public stokara()
        {
            InitializeComponent();
        }
        
        private void stokara_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'carilerDataSet56.stok_list' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stok_listTableAdapter1.Fill(this.carilerDataSet56.stok_list);

            string[] headernme = { "STOK ADI", "STOK KODU", "ADET", "BİRİM FİYAT", "ÜRETİCİ"};

            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Columns[i].HeaderText = headernme[i];
            }




            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
            
            baglan.Open();

            
           
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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




        public static string dgr;

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgr = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            stok_gör gr = new stok_gör();
            gr.Show();
        }
    }

}
    

