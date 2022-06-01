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

        public int VarMi(string sorgu)
        {
            int sonuc;
            con.Open();
            cmd = new MySqlCommand(sorgu, con);
            sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return sonuc;
        } 
        

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            con.Open();
            string Komut = "Select Uye.Id, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta, Bolum.Adi As Bolum From Bolum Inner Join Uye On Uye.Bolum_Id = Bolum.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KullaniciEkle_dgv.DataSource = dt;
            con.Close();


            con.Open();
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM Bolum", con);           
            MySqlDataReader dr;
            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                Bolum_cmb.Items.Add(dr["Adi"]);
            }
            con.Close();
        }

        private void UyeEkle_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = KullaniciAdi_txt.Text;
            string kullaniciSoyadi = KullaniciSoyadi_txt.Text;
            string kullaniciMail = EPosta_txt.Text;
            string KullaniciTelNo = TelNo_txt.Text;
            string kullaniciUyeNumara = UyeNumara_txt.Text;

            int Bolum = Bolum_cmb.SelectedIndex;

            if (KullaniciAdi_txt.Text == "" && KullaniciSoyadi_txt.Text == "" && EPosta_txt.Text == "" && UyeNumara_txt.Text == "" && Bolum_cmb.SelectedIndex == 0)
            {
                MessageBox.Show("Uye bilgileri eksiksiz giriniz!!");
            }
            else
            {
                if (VarMi("SELECT COUNT(*) From Uye WHERE Uye_Numarasi = '" + UyeNumara_txt.Text + "'") == 0)
                {
                    con.Open();
                    cmd = new MySqlCommand("INSERT INTO Uye (Adi, Soyadi, Uye_Numarasi, Telefon_No, E_Posta, Bolum_Id) VALUES ('" + kullaniciAdi + "', '" + kullaniciSoyadi + "', '" + kullaniciUyeNumara + "', '" + KullaniciTelNo + "', '" + kullaniciMail + "', '" + Bolum + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Uye başarıyla kayıt edildi.");
                }
                else
                {
                    MessageBox.Show("Bu üye numarasıyla kayıt bulunmaktadır.");
                }
            }

            string Komut = "Select Uye.Id, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta, Bolum.Adi As Adi1 From Bolum Inner Join Uye On Uye.Bolum_Id = Bolum.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KullaniciEkle_dgv.DataSource = dt;
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand insert = new MySqlCommand("INSERT INTO Bolum (Adi) VALUES ('" + textBox1.Text + "')", con);
            insert.ExecuteNonQuery();
            con.Close();

            Bolum_cmb.Items.Add(textBox1.Text);
            MessageBox.Show("Bölüm Eklendi");
            textBox1.Clear();
        }
    }
}
