using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UludagKutuphane
{
    public partial class kullanicilistesi : Form
    {
        MySqlConnection con;

        public kullanicilistesi()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id=132030020; pwd=Ogrenci9512357.; database=132030020");
        }

        private void KullaniciListele_load(object sender, EventArgs e)
        {
            con.Open();
            string Komut = "Select Uye.Id, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta, Uye.Ceza, Bolum.Adi As Adi1 From Bolum Inner Join Uye On Uye.Bolum_Id = Bolum.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KullaniciListesi_dgv.DataSource = dt;
            con.Close();
        }
    }
}
