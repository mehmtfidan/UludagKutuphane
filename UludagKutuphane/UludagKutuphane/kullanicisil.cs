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
    public partial class kullanicisil : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;

        public kullanicisil()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id=132030020; pwd=Ogrenci9512357.; database=132030020");
        }

        private void KullaniciSil_Load(object sender, EventArgs e)
        {
            con.Open();
            string Komut = "Select Uye.Id, Uye.Adi as Adı, Uye.Soyadi as Soyadı, Uye.Uye_Numarasi as Üye_Numarası, Uye.Telefon_No as Telefon_Numarası, Uye.E_Posta, Uye.Ceza, Bolum.Adi As Bölüm_Adı From Bolum Inner Join Uye On Uye.Bolum_Id = Bolum.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KullaniciSil_dgv.DataSource = dt;
            con.Close();
        }

        private void Sil_btn_Click(object sender, EventArgs e)
        {
            int SecilenId = Convert.ToInt32(KullaniciSil_dgv.CurrentRow.Cells[0].Value);

            con.Open();
            MySqlCommand Komut = new MySqlCommand("DELETE FROM Uye WHERE Id = '"+ SecilenId +"'", con);
            Komut.ExecuteNonQuery();

            string Komut1 = "Select Uye.Id, Uye.Adi as Adı, Uye.Soyadi as Soyadı, Uye.Uye_Numarasi as Üye_Numarası, Uye.Telefon_No as Telefon_Numarası, Uye.E_Posta, Uye.Ceza, Bolum.Adi As Bölüm_Adı From Bolum Inner Join Uye On Uye.Bolum_Id = Bolum.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut1, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KullaniciSil_dgv.DataSource = dt;
            MessageBox.Show("Kullanıcı başarıyla silindi.");
            con.Close();
        }


    }
}
