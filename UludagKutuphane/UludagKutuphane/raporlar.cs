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
    public partial class raporlar : Form
    {
        MySqlConnection con;

        public raporlar()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id=132030020; pwd=Ogrenci9512357.; database=132030020");
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand komut1 = new MySqlCommand("Select Count(*) From Kitap", con);
            MySqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                Toplam_Kitap_lbl.Text = dr1[0].ToString();
            }
            con.Close();

            con.Open();
            MySqlCommand komut2 = new MySqlCommand("Select Count(*) From Odunc", con);
            MySqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                EmanetKitap_Lbl.Text = dr2[0].ToString();
            }
            con.Close();

            con.Open();
            MySqlCommand komut3 = new MySqlCommand("Select Count(*) From Kitap WHERE Durum_Id = '3'", con);
            MySqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                KayipKitap_Lbl.Text = dr3[0].ToString();
            }
            con.Close();

            con.Open();
            MySqlCommand komut4 = new MySqlCommand("Select Count(*) From Uye", con);
            MySqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                ToplamUye_Lbl.Text = dr4[0].ToString();
            }
            con.Close();

            con.Open();
            MySqlDataAdapter komut5 = new MySqlDataAdapter("SELECT Kitap.Ki_Adi FROM Odunc INNER JOIN Kitap ON Odunc.Kitap_Id = Kitap.Id GROUP BY Odunc.Kitap_Id ORDER BY COUNT(Kitap_Id) DESC LIMIT 5", con);
            DataTable dt = new DataTable();               
            komut5.Fill(dt);
            EnCokOkunan_dgv.DataSource = dt;
                
            
            con.Close();

            con.Open();
            MySqlDataAdapter komut6 = new MySqlDataAdapter("SELECT Uye.Adi, Uye.Soyadi FROM Odunc INNER JOIN Uye ON Odunc.Uye_Id = Uye.Id GROUP BY Odunc.Uye_Id ORDER BY COUNT(Uye_Id) DESC LIMIT 5", con);
            DataTable dt1 = new DataTable();
            komut6.Fill(dt1);
            encokokuyan_dgv.DataSource = dt1;
            con.Close();
        }
    }
}
