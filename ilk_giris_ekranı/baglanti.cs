using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ilk_giris_ekranı
{
    class baglanti
    {
        SqlConnection baglan = new SqlConnection("Data Source=ILP\\SQLEXPRESS ; Initial Catalog = cariler; Integrated Security= True");

        public  void baglanac() { 
            baglan.Open();
        }
        public  void baglankapat() {
            baglan.Close();
        }
    }
}
