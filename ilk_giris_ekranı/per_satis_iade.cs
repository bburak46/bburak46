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
    
    public partial class per_satis_iade : Form
    {
        int sat_say1;
        public per_satis_iade()
        {
            InitializeComponent();
        }

        private void per_satis_iade_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'carilerDataSet47.stok_list' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stok_listTableAdapter.Fill(this.carilerDataSet47.stok_list);
            groupBox1.Location = new Point(0, 0);

            From1 st = new From1();
            textBox10_tarih.Text = st.dateTimePicker1_tarih.Value.ToString();
            textBox19.SelectedText = "TL";
            textBox11.SelectedText = "MERKEZ";
            textBox12.SelectedText = "MERKEZ";
            textBox15.SelectedText = "MERKEZ";
            dataGridView1_1.CurrentCell = null;
            sat_say1 = dataGridView1_1.Rows.Count - 1;
            SqlConnection baglantı = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM cari";
            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglantı.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["firma_adi"].ToString().TrimEnd());
                comboBox1_firma_kodu.Items.Add(dr["firma_kodu"].ToString().TrimEnd());
            }

            comboBox1.AutoCompleteCustomSource.Add(comboBox1.Items.ToString());
            comboBox1_firma_kodu.AutoCompleteCustomSource.Add(comboBox1_firma_kodu.Items.ToString());
            baglantı.Close();


        }

        private void dataGridView1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                button1.Visible = false;
                button2.Visible = false;

                dataGridView1_2.Show();
                dataGridView1_2.CurrentCell = null;

   
                button5.Hide();

            }
        }

        private void dataGridView1_2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1_2.CurrentCell != null)
            {
                foreach (DataGridViewRow row in dataGridView1_2.SelectedRows)
                {

                    dynamic[] rowData = new dynamic[11];
                    rowData[0] = row.Cells[0].Value;//stok kodu
                    rowData[1] = row.Cells[1].Value;//stok adı
                    rowData[2] = 1;//adet  
                    row.Cells[2].Value = Convert.ToInt32(row.Cells[2].Value) - 1;
                    rowData[3] = row.Cells[3].Value;//birim
                    rowData[4] = 18;//kdv
                    rowData[5] = 0;//isk
                    rowData[6] = Convert.ToDouble(row.Cells[5].Value);//stok fiyat
                    rowData[7] = Convert.ToDouble((rowData[2] * rowData[6]) + ((rowData[2] * rowData[6]) * 0.18));
                    rowData[8] = dateTimePicker1.Value.ToString();
                    if (comboBox1.Text == "" && comboBox1_firma_kodu.Text == "")
                    {
                        rowData[9] = "Merkez";
                    }
                    rowData[9] = comboBox1.Text.ToString().TrimEnd();//cariadı
                    rowData[10] = From1.personl.ToString().ToUpper();


                    this.dataGridView1_1.Rows.Add(rowData);

                }
                dataGridView1_2.Hide();
                button5.Show();

                groupBox1.Visible = true;
                groupBox2.Visible = true;
                button1.Visible = true;
                button2.Visible = true;


                if (dataGridView1_1.Rows.Count - 1 != 0)
                {
                    double adet = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[2].Value);
                    double kdv = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[4].Value);
                    double isk = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[5].Value);
                    double fiyat = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[6].Value);
                    double toplam = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[7].Value);

                    toplam = (adet * fiyat) + ((adet * fiyat) * kdv / 100) - (((adet * fiyat) * isk) / 100);
                    dataGridView1_1.SelectedRows[0].Cells[7].Value = toplam;
                    double kesinti_top = 0;
                    double kdv_top = 0;
                    double ara_top = 0;
                    double genel_top = 0;
                    for (int i = 0; i < dataGridView1_1.Rows.Count - 1; i++)
                    {

                        double adet1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[2].Value);
                        double kdv1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[4].Value);
                        double isk1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[5].Value);
                        double fiyat1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[6].Value);
                        double toplam1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[7].Value);
                        kesinti_top = kesinti_top + (((adet1 * fiyat1) * isk1) / 100);
                        kdv_top = kdv_top + (((adet1 * fiyat1) * kdv1 / 100));
                        ara_top = ara_top + (adet1 * fiyat1);
                        genel_top = genel_top + (adet1 * fiyat1) + ((adet1 * fiyat1) * kdv1 / 100) - (((adet1 * fiyat1) * isk1) / 100);


                    }
                    textBox23.Text = kesinti_top.ToString();
                    textBox24.Text = kdv_top.ToString();
                    textBox25.Text = ara_top.ToString();
                    textBox26.Text = genel_top.ToString();
                }


            }
        }
    }
}
