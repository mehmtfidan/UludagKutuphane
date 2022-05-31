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
    public partial class kayipkitap : Form
    {
        MySqlConnection con;

        public kayipkitap()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id=132030020; pwd=Ogrenci9512357.; database=132030020");
        }

        private void Kayip_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlDataAdapter ShowinDgv = new MySqlDataAdapter("SELECT Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Durum.D_Adi FROM Kitap INNER JOIN Durum ON Kitap.Durum_Id = Durum.Id INNER JOIN Yazar ON Kitap.Yazar_Id = Yazar.Id WHERE Kitap.Durum_Id = '3'", con);
            DataTable dt = new DataTable();
            ShowinDgv.Fill(dt);
            Kayip_dgv.DataSource = dt;
            con.Close();
        }

        private void durumdegis_Btn_Click(object sender, EventArgs e)
        {
            int SecilenSatır = Convert.ToInt32(Kayip_dgv.CurrentRow.Cells[0].Value);
            //int SecilenKitap = Convert.ToInt32(Kayip_dgv.CurrentRow.Cells[1].Value);

            if (durumdegis_Cmb.SelectedIndex == 1)
            {
                con.Open();
                MySqlCommand update = new MySqlCommand("UPDATE Kitap SET Durum_Id = '"+ durumdegis_Cmb.SelectedIndex +"' WHERE Id = '"+ SecilenSatır +"'", con);
                update.ExecuteNonQuery();

                MySqlCommand delete = new MySqlCommand("DELETE FROM Kayip_Kitap WHERE Id = '"+ SecilenSatır +"'", con);
                delete.ExecuteNonQuery();

                MySqlDataAdapter ShowinDgv = new MySqlDataAdapter("SELECT Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Durum.D_Adi FROM Kitap INNER JOIN Durum ON Kitap.Durum_Id = Durum.Id INNER JOIN Yazar ON Kitap.Yazar_Id = Yazar.Id WHERE Kitap.Durum_Id = '3'", con);
                DataTable dt = new DataTable();
                ShowinDgv.Fill(dt);
                Kayip_dgv.DataSource = dt;
                con.Close();
            }
        }
    }
}
