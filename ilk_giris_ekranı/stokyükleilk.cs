using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilk_giris_ekranı
{
    public partial class stokyükleilk : Form
    {
        stokyükleme stkyklmılk = new stokyükleme();
        

        public stokyükleilk()
        {
            InitializeComponent();
        }

        private void stokyükleilk_Load(object sender, EventArgs e)
        {
            
        }
        public static string ür_adı;
        private void button1_stokyükleilk_tamam_Click(object sender, EventArgs e)
        {
            ür_adı = comboBox1_stokyükle1.Text.ToString().ToUpper();
            stkyklmılk.Show();
            this.Close();
        }

        private void comboBox1_stokyükle1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_stokyükleilk_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
