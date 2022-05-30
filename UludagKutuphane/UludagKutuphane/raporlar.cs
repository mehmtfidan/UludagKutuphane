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

            //con.Open();
            //MySqlCommand komut3 = new MySqlCommand("Select Count(*) From Kayip_Kitap", con);
            //MySqlDataReader dr3 = komut3.ExecuteReader();
            //while (dr3.Read())
            //{
            //    KayipKitap_Lbl.Text = dr3[0].ToString();
            //}
            //con.Close();

            con.Open();
            MySqlCommand komut4 = new MySqlCommand("Select Count(*) From Kitap", con);
            MySqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                ToplamUye_Lbl.Text = dr4[0].ToString();
            }
            con.Close();

            con.Open();
            MySqlCommand komut5 = new MySqlCommand("SELECT COUNT(Id), Kitap_Id FROM Odunc GROUP BY Kitap_Id ORDER BY COUNT(Id) DESC", con);
            MySqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                EnCokOkunan_Lb.Items.Add(dr5["Kitap_Id"]);
            }
            con.Close();

            con.Open();
            MySqlCommand komut6 = new MySqlCommand("SELECT COUNT(Id), Uye_Id FROM Odunc GROUP BY Uye_Id ORDER BY COUNT(Id) DESC", con);
            MySqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                EnCokOkuyan_Lb.Items.Add(dr6["Uye_Id"]);
            }
            con.Close();
        }
    }
}
