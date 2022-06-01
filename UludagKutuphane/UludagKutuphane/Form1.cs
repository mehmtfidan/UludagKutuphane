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
    public partial class Form1 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id=132030020; pwd=Ogrenci9512357.; database=132030020");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kaydol KaydolEkrani = new Kaydol();
            KaydolEkrani.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Adi = KullaniciAdi_txt.Text;
            string Sifre = KullaniciSifre_txt.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Memur where Kullanici_Adi='" + Adi + "' AND Kullanici_Sifre='" + Sifre + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                islempaneli islempaneliform = new islempaneli();
                islempaneliform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
            }
            con.Close();
           
        }

        private void KullaniciAdi_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KullaniciSifre_txt_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
