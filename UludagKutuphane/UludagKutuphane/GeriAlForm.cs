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
    public partial class GeriAlForm : Form
    {
        MySqlConnection con;

        public GeriAlForm()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id=132030020; pwd=Ogrenci9512357.; database=132030020");
        }

        private void GeriAlForm_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlDataAdapter ShowinDgv = new MySqlDataAdapter("Select Odunc.Id, Odunc.Alis_Tarihi, Odunc.Teslim_Tarihi, Kitap.Ki_Adi, Kitap.Demirbas_No, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta From Odunc Inner Join Kitap On Odunc.Kitap_Id = Kitap.Id Inner Join Uye On Odunc.Uye_Id = Uye.Id", con);
            DataTable dt = new DataTable();
            ShowinDgv.Fill(dt);
            GeriAl_dgv.DataSource = dt;
            con.Close();
        }

        private void GeriAl_Btn_Click(object sender, EventArgs e)
        {
            int SecilenSatır = Convert.ToInt32(GeriAl_dgv.CurrentRow.Cells[0].Value);

            con.Open();

            MySqlCommand KitapId = new MySqlCommand("SELECT Kitap_Id FROM Odunc WHERE Id = '"+ SecilenSatır +"'", con);
            int SecilenKitapId = Convert.ToInt32(KitapId.ExecuteScalar());

            MySqlCommand update = new MySqlCommand("UPDATE Kitap SET Durum_Id = '" + 1 + "' WHERE Id = '" + SecilenKitapId + "'");

            MySqlCommand delete = new MySqlCommand("DELETE FROM Odunc WHERE Id = '"+ SecilenSatır +"'", con);
            delete.ExecuteNonQuery();

            MySqlDataAdapter ShowinDgv = new MySqlDataAdapter("Select Odunc.Id, Odunc.Alis_Tarihi, Odunc.Teslim_Tarihi, Kitap.Ki_Adi, Kitap.Demirbas_No, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta From Odunc Inner Join Kitap On Odunc.Kitap_Id = Kitap.Id Inner Join Uye On Odunc.Uye_Id = Uye.Id", con);
            DataTable dt = new DataTable();
            ShowinDgv.Fill(dt);
            GeriAl_dgv.DataSource = dt;

            MessageBox.Show("Kitap teslim alındı.");

            con.Close();
        }
    }
}
