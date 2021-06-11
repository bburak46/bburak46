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
using System.Collections;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Web;

namespace ilk_giris_ekranı
{



    public partial class satis : Form
    {

        int sat_say;


        public satis()
        {
            InitializeComponent();
        }

        private void satis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'carilerDataSet57.stok_list' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.stok_listTableAdapter.Fill(this.carilerDataSet57.stok_list);
            //// TODO: Bu kod satırı 'carilerDataSet54.cari' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.cariTableAdapter.Fill(this.carilerDataSet54.cari);



            From1 st = new From1();
            textBox10_tarih.Text = st.dateTimePicker1_tarih.Value.ToString();
            textBox19.SelectedText = "TL";
            textBox11.SelectedText = "MERKEZ";
            textBox12.SelectedText = "MERKEZ";
            textBox15.SelectedText = "MERKEZ";
            textBox__kalanborcmktr.Text = "0";
            textBox__kalanborcmktr.ReadOnly = true;
            
            textBox__kredikartmktr.Text = "0";
            textBox__pesinmktr.Text = "0";
            dataGridView1_1.CurrentCell = null;
            sat_say = dataGridView1_1.Rows.Count - 1;
            //SqlConnection baglantı = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = "SELECT * FROM cari";
            //komut.Connection = baglantı;
            //komut.CommandType = CommandType.Text;

            //SqlDataReader dr;
            //baglantı.Open();
            //dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    comboBox1.Items.Add(dr["firma_adi"].ToString().TrimEnd());
            //    comboBox1_firma_kodu.Items.Add(dr["firma_kodu"].ToString().TrimEnd());
            //}

            //comboBox1.AutoCompleteCustomSource.Add(comboBox1.Items.ToString());
            //comboBox1_firma_kodu.AutoCompleteCustomSource.Add(comboBox1_firma_kodu.Items.ToString());
            //baglantı.Close();





        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
               
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = true;
                textBox__kalanborcmktr.Visible = false;
                textBox__kredikartmktr.Visible = false;
                textBox__pesinmktr.Visible = false;
                textBox_pesin.Visible = false;
                textBox_kredi.Visible = false;
                textBox_kalan.Visible = false;

                dataGridView1_2.Show();
                dataGridView1_2.CurrentCell = null;
              
                label1.Show();
                textBox10.TabIndex = 0;
                textBox10.Show();
                button5.Hide();

            }


        }
        public static int sayı;
        private void dataGridView1_2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if( Convert.ToInt32(dataGridView1_2.CurrentRow.Cells[2].Value) <= 0)
            {
                MessageBox.Show("Stokta Olmayan Bir Ürünü Satmaya Çalışıyorsunuz !");
            }
            else
            {
                if (dataGridView1_2.CurrentCell != null)
                {
                    foreach (DataGridViewRow row in dataGridView1_2.SelectedRows)
                    {

                        dynamic[] rowData = new dynamic[12];
                        rowData[1] = row.Cells[0].Value;//stok kodu
                        rowData[2] = row.Cells[1].Value;//stok adı
                        rowData[3] = 1;//adet  
                        row.Cells[2].Value = Convert.ToInt32(row.Cells[2].Value) - 1;
                        rowData[4] = row.Cells[3].Value;//birim

                        if (checkBox1.Checked == false || checkBox1.CheckState == CheckState.Unchecked) { rowData[5] = 0; }
                        else
                        {
                            rowData[5] = 18;//kdv
                        }

                        
                        rowData[6] = 0;//isk
                        rowData[7] = Convert.ToDouble(row.Cells[5].Value);//stok fiyat
                        rowData[8] = Convert.ToDouble((rowData[3] * rowData[7]) + ((rowData[3] * rowData[7]) * 0.18));
                        rowData[9] = dateTimePicker1.Value.ToString();
                        if (comboBox1.Text == "" && comboBox1_firma_kodu.Text == "")
                        {
                            rowData[10] = "Merkez";
                        }
                        rowData[10] = comboBox1.Text.ToString().TrimEnd();//cariadı
                        rowData[11] = From1.personl.ToString().ToUpper();
                        

                        this.dataGridView1_1.Rows.Add(rowData);

                    }
                    dataGridView1_2.Hide();
                    button5.Show();
                    textBox10.Hide();
                    label1.Hide();
                    textBox10.Clear();
                    groupBox1.Visible = true;
                    groupBox2.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = false;
                    if(comboBox1_firma_kodu.Text != "" && comboBox1.Text != "")
                    {
                        textBox_pesin.Visible = true;
                        textBox_kredi.Visible = true;
                        textBox_kalan.Visible = true;

                        textBox__kalanborcmktr.Visible = true;
                        textBox__kredikartmktr.Visible = true;
                        textBox__pesinmktr.Visible = true;
                    }
               

                    label1.Hide();
                    textBox10.Hide();
                    if (dataGridView1_1.Rows.Count - 1 != 0)
                    {
                        double adet = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[3].Value);
                        double kdv = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[5].Value);
                        double isk = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[6].Value);
                        double fiyat = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[7].Value);
                        double toplam = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[8].Value);

                        toplam = (adet * fiyat) + ((adet * fiyat) * kdv / 100) - (((adet * fiyat) * isk) / 100);
                        dataGridView1_1.SelectedRows[0].Cells[8].Value = toplam;
                        double kesinti_top = 0;
                        double kdv_top = 0;
                        double ara_top = 0;
                        double genel_top = 0;
                        for (int i = 0; i < dataGridView1_1.Rows.Count - 1; i++)
                        {

                            double adet1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[3].Value);
                            double kdv1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[5].Value);
                            double isk1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[6].Value);
                            double fiyat1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[7].Value);
                            double toplam1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[8].Value);
                            kesinti_top = kesinti_top + (((adet1 * fiyat1) * isk1) / 100);
                            kdv_top = kdv_top + (((adet1 * fiyat1) * kdv1 / 100));
                            ara_top = ara_top + (adet1 * fiyat1);
                            genel_top = genel_top + (adet1 * fiyat1) + ((adet1 * fiyat1) * kdv1 / 100) - (((adet1 * fiyat1) * isk1) / 100);


                        }
                        textBox23.Text = kesinti_top.ToString();
                        textBox24.Text = kdv_top.ToString();
                        textBox25.Text = ara_top.ToString();
                        textBox26.Text = genel_top.ToString();
                        textBox__kalanborcmktr.Text = genel_top.ToString();
                        gentop = genel_top;
                    }


                }
            }




        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

            //SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            //baglan.Open();


            //DataTable tbl = new DataTable();
            //string vara, cumle;
            //vara = textBox10.Text.Trim();
            //cumle = "Select * from stok_list where stok_adi + stok_kodu   like '%" + textBox10.Text.TrimEnd() + "%'";

            //SqlDataAdapter adptr = new SqlDataAdapter(cumle, baglan);
            //adptr.Fill(tbl);
            //baglan.Close();

            //dataGridView1_2.DataSource = tbl;

        }

        
        private void dataGridView1_1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            double adet = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[3].Value);
            double kdv = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[5].Value);
            double isk = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[6].Value);
            double fiyat = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[7].Value);
            double toplam = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[8].Value);

            toplam = (adet * fiyat) + ((adet * fiyat) * kdv / 100) - (((adet * fiyat) * isk) / 100);
            dataGridView1_1.SelectedRows[0].Cells[8].Value = toplam;
            double kesinti_top = 0;
            double kdv_top = 0;
            double ara_top = 0;
            double genel_top = 0;
            
            for (int i = 0; i < dataGridView1_1.Rows.Count - 1; i++)
            {

                double adet1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[3].Value);
                double kdv1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[5].Value);
                double isk1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[6].Value);
                double fiyat1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[7].Value);
                double toplam1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[8].Value);
                kesinti_top = kesinti_top + (((adet1 * fiyat1) * isk1) / 100);
                kdv_top = kdv_top + (((adet1 * fiyat1) * kdv1 / 100));
                ara_top = ara_top + (adet1 * fiyat1);
                genel_top = genel_top + (adet1 * fiyat1) + ((adet1 * fiyat1) * kdv1 / 100) - (((adet1 * fiyat1) * isk1) / 100);
                

            }
            textBox23.Text = kesinti_top.ToString();
            textBox24.Text = kdv_top.ToString();
            textBox25.Text = ara_top.ToString();
            textBox26.Text = genel_top.ToString();
            textBox__kalanborcmktr.Text = genel_top.ToString();
            gentop = genel_top;
            //SqlConnection baglantı = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = "SELECT * FROM stok_list WHERE stok_kodu='"+dataGridView1_1.CurrentRow.Cells[1].Value.ToString().TrimEnd()+"'";
            //komut.Connection = baglantı;
            //komut.CommandType = CommandType.Text;
            //int enadet = 0;
            //SqlDataReader dr;
            //baglantı.Open();
            //dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    enadet = Convert.ToInt32(dr["stok_adedi"].ToString().TrimEnd());
            //}
            //if(enadet <= Convert.ToInt32(dataGridView1_1.CurrentRow.Cells[3].Value))
            //{
            //    MessageBox.Show("STOK TÜKENDİ");
            //    dataGridView1_1.CurrentRow.Cells[3].Value = enadet;
            //    dataGridView1_2.CurrentRow.Cells[2].Value = 0;
            //}
            //dataGridView1_2.CurrentRow.Cells[2].Value = Convert.ToInt32(dataGridView1_2.CurrentRow.Cells[2].Value) - Convert.ToInt32(dataGridView1_1.CurrentRow.Cells[3].Value)+1; 
            //baglantı.Close();
        }



        private void satis_Resize_1(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(0, 0);

        }

        private void hesap()
        {
            //SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

            //SqlCommand hesap = new SqlCommand();
            //hesap.Connection = baglan;
            //baglan.Open();
            //double k = Convert.ToDouble(textBox__pesinmktr.Text.ToString().TrimEnd());
            //int t = (int)(k * 100);
            //hesap.CommandText = "update cari set pesin = pesin + '" + t + "'  where firma_kodu = '" + comboBox1_firma_kodu.Text.ToString().TrimEnd() + "' ";
            //hesap.ExecuteNonQuery();
            //double c = Convert.ToDouble(textBox__kredikartmktr.Text.ToString().TrimEnd());
            //int d = (int)(c * 100);
            //hesap.CommandText = "update cari set kredikarti = kredikarti + '" + d + "'  where firma_kodu = '" + comboBox1_firma_kodu.Text.ToString().TrimEnd() + "' ";
            //hesap.ExecuteNonQuery();
            //double a = Convert.ToDouble(textBox__kalanborcmktr.Text.ToString().TrimEnd());
            //int b = (int)(a * 100);

            //hesap.CommandText = "update cari set top_borc = top_borc + '" + (b) + "'  where firma_kodu = '" + comboBox1_firma_kodu.Text.ToString().TrimEnd() + "' ";
            //hesap.ExecuteNonQuery();
            //baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            //SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
            //if (comboBox1.Text == "" && comboBox1_firma_kodu.Text == "")
            //{
            //    SqlCommand ekle = new SqlCommand();
            //    baglan.Open();
            //    for (int i = 0; i < dataGridView1_1.Rows.Count - 1; i++)
            //    {

            //        ekle.Connection = baglan;
            //        string sql = "update stok_list set stok_adedi = stok_adedi - '" + Convert.ToInt32(dataGridView1_1.Rows[i].Cells[3].Value.ToString().TrimEnd()) + "' where stok_kodu = '" + dataGridView1_1.Rows[i].Cells[1].Value.ToString().TrimEnd() + "' ";
            //        SqlCommand cmd = new SqlCommand(sql, baglan);
            //        cmd.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
            //        ekle.CommandText = "INSERT INTO per_satis_kaydi(stok_kodu,stok_adi,adet,birim,kdv,isk,birim_fiyat,toplam_tutar,tarih,personel_adi) VALUES ('" + dataGridView1_1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[5].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[6].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[7].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[8].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[9].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[11].Value.ToString() + "')";
            //        ekle.ExecuteNonQuery();
            //    }
                
            //}


            //else
            //{




            //    SqlCommand ekle = new SqlCommand();

            //    baglan.Open();

            //    for (int i = 0; i < dataGridView1_1.Rows.Count - 1; i++)
            //    {
            //        ekle.Connection = baglan;

            //        string sql = "update stok_list set stok_adedi = stok_adedi - '" + Convert.ToInt32(dataGridView1_1.Rows[i].Cells[3].Value.ToString().TrimEnd()) + "' where stok_kodu = '" + dataGridView1_1.Rows[i].Cells[1].Value.ToString().TrimEnd() + "' ";
            //        SqlCommand cmd = new SqlCommand(sql, baglan);
            //        cmd.ExecuteNonQuery(); // sql sorgusunu işleme ko
            //        ekle.CommandText = "INSERT INTO cari_satis_kaydi(stok_kodu,stok_adi,adet,birim,kdv,isk,birim_fiyat,toplam_tutar,tarih,cari_adi,personel_adi) VALUES ('" + dataGridView1_1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[5].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[6].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[7].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[8].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[9].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[10].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[11].Value.ToString() + "')";
            //        ekle.ExecuteNonQuery();
                    


            //    }

            //    hesap();







            //}



            //baglan.Close();
            //dataGridView1_1.Rows.Clear();
            //textBox__kalanborcmktr.Text = "0";
            //textBox__kredikartmktr.Text = "0";
            //textBox__pesinmktr.Text = "0";


        }


        private void button3_Click(object sender, EventArgs e)
        {




        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            
        }
        double gentop;
        private void dataGridView1_1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (dataGridView1_1.Rows.Count != sat_say)
            {
                double adet = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[3].Value);
                double kdv = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[5].Value);
                double isk = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[6].Value);
                double fiyat = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[7].Value);
                double toplam = Convert.ToDouble(dataGridView1_1.SelectedRows[0].Cells[8].Value);

                toplam = (adet * fiyat) + ((adet * fiyat) * kdv / 100) - (((adet * fiyat) * isk) / 100);
                dataGridView1_1.SelectedRows[0].Cells[8].Value = toplam;
                double kesinti_top = 0;
                double kdv_top = 0;
                double ara_top = 0;
                double genel_top = 0;
                for (int i = 0; i < dataGridView1_1.Rows.Count - 1; i++)
                {

                    double adet2 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[3].Value);
                    double kdv1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[5].Value);
                    double isk1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[6].Value);
                    double fiyat1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[7].Value);
                    double toplam1 = Convert.ToInt32(dataGridView1_1.Rows[i].Cells[8].Value);
                    kesinti_top = kesinti_top + (((adet2 * fiyat1) * isk1) / 100);
                    kdv_top = kdv_top + (((adet2 * fiyat1) * kdv1 / 100));
                    ara_top = ara_top + (adet2 * fiyat1);
                    genel_top = genel_top + (adet2 * fiyat1) + ((adet2 * fiyat1) * kdv1 / 100) - (((adet2 * fiyat1) * isk1) / 100);


                }
                textBox23.Text = kesinti_top.ToString();
                textBox24.Text = kdv_top.ToString();
                textBox25.Text = ara_top.ToString();
                textBox26.Text = genel_top.ToString();
                gentop = genel_top;
                textBox__kalanborcmktr.Text = genel_top.ToString();
                if(dataGridView1_1.Rows.Count < 2)
                {
                    textBox__kalanborcmktr.Text = "0";
                    textBox__kredikartmktr.Text = "0";
                    textBox__pesinmktr.Text = "0";
                }
                this.stok_listTableAdapter.Fill(this.carilerDataSet57.stok_list);
            }
           
    
        }
        private void satis_FormClosed(object sender, FormClosedEventArgs e)
        {



        }

        private void dataGridView1_1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1_firma_kodu.SelectedIndex = comboBox1.SelectedIndex ;
            textBox_pesin.Visible = true;
            textBox_kredi.Visible = true;
            textBox_kalan.Visible = true;

            textBox__kalanborcmktr.Visible = true;
            textBox__kredikartmktr.Visible = true;
            textBox__pesinmktr.Visible = true;
            dataGridView1_1.Rows.Clear();
            textBox__kalanborcmktr.Text = "0";
            textBox__kredikartmktr.Text = "0";
            textBox__pesinmktr.Text = "0";
        }

        private void comboBox1_firma_kodu_TextChanged(object sender, EventArgs e)
        {
            
            comboBox1.SelectedIndex = comboBox1_firma_kodu.SelectedIndex;
            
        }
        public static string yol;
        public static string firadı;
        public static string belgenotu;
        private void button2_Click(object sender, EventArgs e)
        {
            //belgenotu = richTextBox__belgenotu.Text.ToString().TrimEnd();
            
            //firadı = comboBox1.Text.ToString();
            //decimal toplam = 0;
            //decimal kdv = 0;
            //decimal aratop = 0;
            //try
            //{
            //    for (int i = 0; i < dataGridView1_1.Rows.Count - 1; i++)
            //    {
            //        toplam += Convert.ToDecimal(dataGridView1_1.Rows[i].Cells[8].Value.ToString());

            //    }
            //    for (int j = 0; j < dataGridView1_1.Rows.Count - 1; j++)
            //    {
            //        kdv += Convert.ToDecimal(dataGridView1_1.Rows[j].Cells[8].Value.ToString()) - (Convert.ToDecimal(dataGridView1_1.Rows[j].Cells[3].Value.ToString()) * Convert.ToDecimal(dataGridView1_1.Rows[j].Cells[7].Value.ToString()));

            //    }
            //    for(int t=0;t<dataGridView1_1.Rows.Count - 1; t++)
            //    {
            //        aratop += Convert.ToDecimal(dataGridView1_1.Rows[t].Cells[7].Value.ToString().TrimEnd());
            //    }
            //    dataGridView2.Rows.Add("", "", " KDV(%18)", kdv.ToString());
            //    dataGridView2.Rows.Add("", "", " ARA TOPLAM", aratop.ToString());
            //    dataGridView2.Rows.Add("", "", " GENEL TOPLAM", toplam.ToString());
            //    dataGridView2.Rows.Add("  ", "  ", "  ", "  ");
            //    dataGridView2.Rows.Add("  ", "  ", "  ", "  ");
            //    dataGridView2.Rows.Add("  ", "  ", "  ", "  ");
            //    dataGridView2.Rows.Add("    AD SOYAD", "", "", "SATICI");
            //    dataGridView2.Rows.Add("      "+comboBox1.Text.ToString().ToLower()+"", "  ", "  ", "  ");
            //    dataGridView2.Rows.Add("        IMZA", "", "", "ENERJI MOTOR");
            //    PdfPTable pdfTablosu = new PdfPTable(dataGridView1_1.ColumnCount-8);
            //    pdfTablosu.DefaultCell.Padding = 1;
            //    pdfTablosu.WidthPercentage = 100;
            //    pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
            //    pdfTablosu.DefaultCell.BorderWidth = 1;
            //    pdfTablosu.DefaultCell.Border = iTextSharp.text.Rectangle.LISTITEM;
            //    PdfPTable pdfTablosu1 = new PdfPTable(dataGridView2.ColumnCount);
            //    pdfTablosu1.DefaultCell.Padding = 5;
            //    pdfTablosu1.WidthPercentage = 100;
            //    pdfTablosu1.HorizontalAlignment = Element.ALIGN_LEFT;
            //    pdfTablosu1.DefaultCell.BorderWidth = 0;
            //    pdfTablosu1.DefaultCell.Border = iTextSharp.text.Rectangle.BODY;



            //    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"C:\\Users\\Rasityilmaz\\Desktop\\NTP\\ilk.png");


            //    //Boyutlandırma için ScaleToFit() methodunu ya da ScalePercent() methodunu kullanabiliriz.

            //    img.ScaleToFit(600, 600);

            //    //Çerçeve vermek için aşağıdaki özelliklerini kullanabiliriz.

            //    img.Border = iTextSharp.text.Rectangle.TOP_BORDER;

            //    img.BorderColor = iTextSharp.text.BaseColor.BLACK;

            //    img.BorderWidth = 0f;





            //    for (int k = 0; k < dataGridView1_1.Rows.Count-1; k++)
            //    {

            //        MessageBox.Show(k.ToString());
            //        pdfTablosu.AddCell(dataGridView1_1.Rows[k].Cells[2].Value.ToString());
            //        pdfTablosu.AddCell(dataGridView1_1.Rows[k].Cells[3].Value.ToString());
            //        pdfTablosu.AddCell(dataGridView1_1.Rows[k].Cells[7].Value.ToString());
            //        pdfTablosu.AddCell(dataGridView1_1.Rows[k].Cells[8].Value.ToString());

            //    }


            //    foreach (DataGridViewRow satir in dataGridView2.Rows)
            //    {
            //        foreach (DataGridViewCell cell in satir.Cells)
            //        {

            //            pdfTablosu1.AddCell(cell.Value.ToString());

            //        }
            //    }

            //    SaveFileDialog dosyakaydet = new SaveFileDialog();
            //    dosyakaydet.FileName= comboBox1.Text.ToString();
            //    dosyakaydet.RestoreDirectory = true;
            //    dosyakaydet.Filter = "PDF Dosyası|*.pdf";
                
            //    if (dosyakaydet.ShowDialog() == DialogResult.OK)
            //    {
            //        using (FileStream stream = new FileStream(dosyakaydet.FileName, FileMode.Create))
            //        {
            //            Document pdfDoc = new Document(PageSize.A4, 0f, 0f, 0f, 0f);
            //            iTextSharp.text.Font fn = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL);
            //            PdfWriter.GetInstance(pdfDoc, stream);

            //            pdfDoc.AddCreationDate();
            //            pdfDoc.Open();
            //            pdfDoc.Add(img);
            //            pdfDoc.Add(pdfTablosu);
            //            pdfDoc.Add(pdfTablosu1);

            //            pdfDoc.Close();
            //            stream.Close();
                        
            //            MessageBox.Show("PDF dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + dosyakaydet.FileName, "İşlem Tamam");
            //            yol = dosyakaydet.FileName.ToString();
            //        }
            //        SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
            //        if (comboBox1.Text == "" && comboBox1_firma_kodu.Text == "")
            //        {
            //            SqlCommand ekle = new SqlCommand();
            //            baglan.Open();
            //            for (int i = 0; i < dataGridView1_1.Rows.Count - 1; i++)
            //            {

            //                ekle.Connection = baglan;
            //                string sql = "update stok_list set stok_adedi = stok_adedi - '" + Convert.ToInt32(dataGridView1_1.Rows[i].Cells[3].Value.ToString().TrimEnd()) + "' where stok_kodu = '" + dataGridView1_1.Rows[i].Cells[1].Value.ToString().TrimEnd() + "' ";
            //                SqlCommand cmd = new SqlCommand(sql, baglan);
            //                cmd.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
            //                ekle.CommandText = "INSERT INTO per_satis_kaydi(stok_kodu,stok_adi,adet,birim,kdv,isk,birim_fiyat,toplam_tutar,tarih,personel_adi) VALUES ('" + dataGridView1_1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[5].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[6].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[7].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[8].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[9].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[11].Value.ToString() + "')";
            //                ekle.ExecuteNonQuery();
            //            }

            //        }
            //        else
            //        {



            //            SqlCommand ekle = new SqlCommand();
            //            baglan.Open();
            //            for (int i = 0; i < dataGridView1_1.Rows.Count - 1; i++)
            //            {

            //                ekle.Connection = baglan;
            //                string sql = "update stok_list set stok_adedi = stok_adedi - '" + Convert.ToInt32(dataGridView1_1.Rows[i].Cells[3].Value.ToString().TrimEnd()) + "' where stok_kodu = '" + dataGridView1_1.Rows[i].Cells[1].Value.ToString().TrimEnd() + "' ";
            //                SqlCommand cmd = new SqlCommand(sql, baglan);
            //                cmd.ExecuteNonQuery(); // sql sorgusunu işleme ko

            //                ekle.CommandText = "INSERT INTO cari_satis_kaydi(stok_kodu,stok_adi,adet,birim,kdv,isk,birim_fiyat,toplam_tutar,tarih,cari_adi,personel_adi) VALUES ('" + dataGridView1_1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[5].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[6].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[7].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[8].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[9].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[10].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[11].Value.ToString() + "')";
            //                ekle.ExecuteNonQuery();
            //            }

            //            hesap();







            //        }
            //        dataGridView1_1.Rows.Clear();
            //        textBox__kalanborcmktr.Text = "0";
            //        textBox__kredikartmktr.Text = "0";
            //        textBox__pesinmktr.Text = "0";

            //        baglan.Close();
            //        dataGridView1_1.Rows.Clear();

            //        this.Close();

            //        satis_fat sn = new satis_fat();
            //        sn.Show();
            //    }
            //    else if (dosyakaydet.ShowDialog() == DialogResult.Cancel)
            //    {
            //        this.Close();
            //    }

                
            //}
            //catch(Exception hata)
            //{
            //    MessageBox.Show(hata.Message.ToString());
            //}

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(comboBox1.Text.ToString().TrimEnd() == dataGridView1.Rows[i].Cells[0].Value.ToString().TrimEnd() && dataGridView1.Rows[i].Cells[2].Value.ToString().TrimEnd() == "UYAR")
                {
                    MessageBox.Show( dataGridView1.Rows[i].Cells[3].Value.ToString() + " EMRİ VERİLDİ !!!" );
                    comboBox1.Text = "";
                    comboBox1_firma_kodu.Text = "";
                }
            }
        }

        private void satis_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");
            //if (comboBox1.Text == "" && comboBox1_firma_kodu.Text == "")
            //{
            //    SqlCommand ekle = new SqlCommand();
            //    baglan.Open();
            //    for (int i = 0; i < dataGridView1_1.Rows.Count - 1; i++)
            //    {

            //        ekle.Connection = baglan;
            //        string sql = "update stok_list set stok_adedi = stok_adedi - '" + Convert.ToInt32(dataGridView1_1.Rows[i].Cells[3].Value.ToString().TrimEnd()) + "' where stok_kodu = '" + dataGridView1_1.Rows[i].Cells[1].Value.ToString().TrimEnd() + "' ";
            //        SqlCommand cmd = new SqlCommand(sql, baglan);
            //        cmd.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
            //        ekle.CommandText = "INSERT INTO per_satis_kaydi(stok_kodu,stok_adi,adet,birim,kdv,isk,birim_fiyat,toplam_tutar,tarih,personel_adi) VALUES ('" + dataGridView1_1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[5].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[6].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[7].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[8].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[9].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[11].Value.ToString() + "')";
            //        ekle.ExecuteNonQuery();
            //    }

            //}


            //else
            //{



            //    SqlCommand ekle = new SqlCommand();
            //    baglan.Open();
            //    for (int i = 0; i < dataGridView1_1.Rows.Count - 1; i++)
            //    {

            //        ekle.Connection = baglan;
            //        string sql = "update stok_list set stok_adedi = stok_adedi - '" + Convert.ToInt32(dataGridView1_1.Rows[i].Cells[3].Value.ToString().TrimEnd()) + "' where stok_kodu = '" + dataGridView1_1.Rows[i].Cells[1].Value.ToString().TrimEnd() + "' ";
            //        SqlCommand cmd = new SqlCommand(sql, baglan);
            //        cmd.ExecuteNonQuery(); // sql sorgusunu işleme ko

            //        ekle.CommandText = "INSERT INTO cari_satis_kaydi(stok_kodu,stok_adi,adet,birim,kdv,isk,birim_fiyat,toplam_tutar,tarih,cari_adi,personel_adi) VALUES ('" + dataGridView1_1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[5].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[6].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[7].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[8].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[9].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[10].Value.ToString() + "','" + dataGridView1_1.Rows[i].Cells[11].Value.ToString() + "')";
            //        ekle.ExecuteNonQuery();
            //    }


            //    hesap();






            //}



            //baglan.Close();
            //dataGridView1_1.Rows.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridView1_2.Hide();
            button5.Show();
            textBox10.Hide();
            label1.Hide();
            textBox10.Clear();
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
            label1.Hide();
            textBox10.Hide();
        }
        private void degis()
        { try
            {
                textBox__kalanborcmktr.Text = gentop.ToString();
                textBox__kalanborcmktr.Text = (Convert.ToDecimal(textBox__kalanborcmktr.Text.ToString().TrimEnd()) - (Convert.ToDecimal(textBox__kredikartmktr.Text.ToString().TrimEnd()) + Convert.ToDecimal(textBox__pesinmktr.Text.ToString().TrimEnd()))).ToString();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            
            
        }
        private void textBox__kredikart_Leave(object sender, EventArgs e)
        {
            degis();
  
        }

        private void textBox__pesin_Leave(object sender, EventArgs e)
        {

            degis();
        }


    }
}
    

    

