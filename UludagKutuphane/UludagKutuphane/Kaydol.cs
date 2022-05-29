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
    public partial class Kaydol : Form
    {
        MySqlConnection con;

        public Kaydol()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id=132030020; pwd=Ogrenci9512357.; database=132030020");
        }

        

        private void GirisYap_btn_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = KullaniciAdi_txt.Text;
            string kullaniciSoyadi = KullaniciSoyadi_txt.Text;
            string kullaniciMail = KullaniciMail_txt.Text;
            string kullaniciSifre = KullaniciSifre_txt.Text;
            int Okul = Okul_cmb.SelectedIndex;

            con.Open();
            if (KullaniciAdi_txt.Text == "" && KullaniciSifre_txt.Text == "" && KullaniciSoyadi_txt.Text == "" && KullaniciMail_txt.Text == "" && Okul_cmb.SelectedIndex == 0)
            {
                MessageBox.Show("Bilgileri eksiksiz doldurunuz!!");
            }
            else
            {
                MySqlCommand konut = new MySqlCommand("INSERT INTO Memur (Adi, Soyadi, Kullanici_Adi, Kullanici_Sifre, Bolum_Id) VALUES ('" + kullaniciAdi + "', '" + kullaniciSoyadi + "', '" + kullaniciMail + "', '" + kullaniciSifre + "', '" + Okul + "')", con);
                konut.ExecuteNonQuery();
                this.Close();
                MessageBox.Show("kayıt başarıyla oluşturuldu");
            }
            con.Close();
        }

 
        
    }
}
