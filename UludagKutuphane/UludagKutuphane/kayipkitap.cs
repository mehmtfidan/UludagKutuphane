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
            MySqlDataAdapter ShowinDgv = new MySqlDataAdapter("Select Kitap.Id, Kayip_Kitap.Id As Id1, Kayip_Kitap.Bildirildigi_Tarih, Kitap.Ki_Adi, Kitap.Demirbas_No, Memur.Adi, Memur.Soyadi From Kayip_Kitap Inner Join Kitap On Kayip_Kitap.Kitap_Id = Kitap.Id Inner Join Memur On Kayip_Kitap.Memur_Id = Memur.Id WHERE Kitap.Durum_Id = '"+ 3 +"'", con);
            DataTable dt = new DataTable();
            ShowinDgv.Fill(dt);
            Kayip_dgv.DataSource = dt;
            con.Close();
        }

        private void durumdegis_Btn_Click(object sender, EventArgs e)
        {
            int SecilenSatır = Convert.ToInt32(Kayip_dgv.CurrentRow.Cells[0].Value);
            int SecilenKitap = Convert.ToInt32(Kayip_dgv.CurrentRow.Cells[1].Value);

            if (durumdegis_Cmb.SelectedIndex == 1)
            {
                con.Open();
                MySqlCommand update = new MySqlCommand("UPDATE Kitap SET Durum_Id = '"+ durumdegis_Cmb.SelectedIndex +"' WHERE Id = '"+ SecilenKitap +"'", con);
                update.ExecuteNonQuery();

                MySqlCommand delete = new MySqlCommand("DELETE FROM Kayip_Kitap WHERE Id = '"+ SecilenSatır +"'", con);
                delete.ExecuteNonQuery();

                MySqlDataAdapter ShowinDgv = new MySqlDataAdapter("Select Kitap.Id, Kayip_Kitap.Id As Id1, Kayip_Kitap.Bildirildigi_Tarih, Kitap.Ki_Adi, Kitap.Demirbas_No, Memur.Adi, Memur.Soyadi From Kayip_Kitap Inner Join Kitap On Kayip_Kitap.Kitap_Id = Kitap.Id Inner Join Memur On Kayip_Kitap.Memur_Id = Memur.Id WHERE Kitap.Durum_Id = '" + 3 + "'", con);
                DataTable dt = new DataTable();
                ShowinDgv.Fill(dt);
                Kayip_dgv.DataSource = dt;
                con.Close();
            }
        }
    }
}
