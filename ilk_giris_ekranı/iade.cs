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
    public partial class iade : Form
    {
        public iade()
        {
            InitializeComponent();
        }


        string kadı;
        private void iade_Load(object sender, EventArgs e)
        {
            kadı = grafik_1.kulad;
            // TODO: Bu kod satırı 'carilerDataSet50.per_satis_kaydi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.per_satis_kaydiTableAdapter.Fill(this.carilerDataSet50.per_satis_kaydi);
            // TODO: Bu kod satırı 'carilerDataSet49.cari_satis_kaydi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cari_satis_kaydiTableAdapter.Fill(this.carilerDataSet49.cari_satis_kaydi);

            SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            baglan.Open();


            DataTable tbl = new DataTable();
            string  cumle;
            
            cumle = "Select * from per_satis_kaydi where personel_adi  like '%" + kadı.ToUpper() + "%'";

            SqlDataAdapter adptr = new SqlDataAdapter(cumle, baglan);
            adptr.Fill(tbl);
            baglan.Close();

            dataGridView2_per.DataSource = tbl;

            baglan.Open();
            DataTable tbl1 = new DataTable();
            string cumle1;

            cumle1 = "Select * from cari_satis_kaydi where personel_adi  like '%" + kadı.ToUpper() + "%'";

            SqlDataAdapter adptr1 = new SqlDataAdapter(cumle1, baglan);
            adptr1.Fill(tbl1);
            baglan.Close();

            dataGridView1_cari.DataSource = tbl1;
            string[] headernme = { "STOK KODU", "STOK ADI", "ADET", "BİRİM", "KDV", "İSK", "BİRİM FİYAT", "TOPLAM TUTAR", "TARİH", "PERSONEL" };
            for (int i = 0; i < 10; i++)
            {
                dataGridView1_cari.Columns[i].HeaderText = headernme[i];
            }
            string[] headernme1 = { "STOK KODU", "STOK ADI", "ADET", "BİRİM", "KDV", "İSK", "BİRİM FİYAT", "TOPLAM TUTAR", "TARİH", "CARİ ADI", "PERSONEL" };
            for (int i = 0; i < 10; i++)
            {
                dataGridView2_per.Columns[i].HeaderText = headernme[i];
            }
        }


    }
}
