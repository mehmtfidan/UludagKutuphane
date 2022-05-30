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
        }
    }
}
