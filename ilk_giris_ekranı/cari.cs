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
    
    public partial class cari : Form
    {

        


        
        
        public cari()

        {
            InitializeComponent();
        }
        private void cari_Load(object sender, EventArgs e)
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
          
            this.Hide();
        }


    }
}
