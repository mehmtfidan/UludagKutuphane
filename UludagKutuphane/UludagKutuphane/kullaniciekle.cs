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
    public partial class kullaniciekle : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;

        public kullaniciekle()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id=132030020; pwd=Ogrenci9512357.; database=132030020");
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            con.Open();
            string Komut = "Select Uye.Id, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta, Uye.Ceza, Bolum.Adi As Adi1 From Bolum Inner Join Uye On Uye.Bolum_Id = Bolum.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KullaniciEkle_dgv.DataSource = dt;
            con.Close();
        }

        private void UyeEkle_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = KullaniciAdi_txt.Text;
            string kullaniciSoyadi = KullaniciSoyadi_txt.Text;
            string kullaniciMail = EPosta_txt.Text;
            string KullaniciTelNo = TelNo_txt.Text;
            string kullaniciUyeNumara = UyeNumara_txt.Text;
            float Ceza = float.Parse(ceza_txt.Text);
            int Bolum = Bolum_cmb.SelectedIndex;

            if (KullaniciAdi_txt.Text == "" && KullaniciSoyadi_txt.Text == "" && EPosta_txt.Text == "" && UyeNumara_txt.Text == "" && float.Parse(ceza_txt.Text) == 0 && Bolum_cmb.SelectedIndex == 0)
            {
                MessageBox.Show("Uye bilgileri eksiksiz giriniz!!");
            }
            else
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO Uye (Adi, Soyadi, Uye_Numarasi, Telefon_No, E_Posta, Ceza, Bolum_Id) VALUES ('"+ kullaniciAdi +"', '"+ kullaniciSoyadi +"', '"+ kullaniciUyeNumara +"', '"+ KullaniciTelNo +"', '"+ kullaniciMail +"', '"+ Ceza +"', '"+ Bolum +"')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Uye başarıyla kayıt edildi.");
            }

            string Komut = "Select Uye.Id, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta, Uye.Ceza, Bolum.Adi As Adi1 From Bolum Inner Join Uye On Uye.Bolum_Id = Bolum.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KullaniciEkle_dgv.DataSource = dt;
            con.Close();
        }
    }
}
