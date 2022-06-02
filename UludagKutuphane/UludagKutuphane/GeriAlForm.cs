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
            MySqlDataAdapter ShowinDgv = new MySqlDataAdapter("Select Odunc.Id, Odunc.Alis_Tarihi, Son_Teslim_Tarihi, Odunc.Teslim_Ettigi_Tarih, Odunc.Uye_Id, Odunc.Kitap_Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Kitap.Durum_Id, Durum.D_Adi, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta, Odunc.Teslim_Durumu From Odunc Inner Join Kitap On Odunc.Kitap_Id = Kitap.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Uye On Odunc.Uye_Id = Uye.Id", con);
            DataTable dt = new DataTable();
            ShowinDgv.Fill(dt);
            GeriAl_dgv.DataSource = dt;
            con.Close();
        }

        private void GeriAl_Btn_Click(object sender, EventArgs e)
        {
            int SecilenSatir = Convert.ToInt32(GeriAl_dgv.CurrentRow.Cells[5].Value);

            int SeciliSatir1 = Convert.ToInt32(GeriAl_dgv.CurrentRow.Cells[0].Value);

            DateTime dtn = new DateTime();
            dtn = DateTime.Today;
            
            con.Open();

            //MySqlCommand KitapId = new MySqlCommand("SELECT Kitap_Id FROM Odunc WHERE Id = '"+ SeciliSatir1 + "'", con);
            //int SecilenKitapId = Convert.ToInt32(KitapId.ExecuteScalar());


            

            //MySqlCommand update3 = new MySqlCommand("UPDATE Odunc SET Durum_Id = '" + 1 + "' WHERE Id = '" + SecilenKitapId + "'", con);
            //update.ExecuteNonQuery();

            MySqlCommand update1 = new MySqlCommand("UPDATE Odunc SET Teslim_Ettigi_Tarih = '"+ dtn +"' WHERE Id = '"+ SeciliSatir1 +"'", con);
            update1.ExecuteNonQuery();

            MySqlCommand update2 = new MySqlCommand("UPDATE Odunc SET Teslim_Durumu = '" + 0 + "' WHERE Id = '" + SeciliSatir1 + "'", con);
            update2.ExecuteNonQuery();
            

            MySqlCommand update = new MySqlCommand("UPDATE Kitap SET Durum_Id = '" + 1 + "' WHERE Id = '" + SecilenSatir + "'", con);
            update.ExecuteNonQuery();



            MySqlDataAdapter ShowinDgv = new MySqlDataAdapter("Select Odunc.Id, Odunc.Alis_Tarihi, Odunc.Son_Teslim_Tarihi, Odunc.Teslim_Ettigi_Tarih, Odunc.Uye_Id, Odunc.Kitap_Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Kitap.Durum_Id, Durum.D_Adi, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta, Odunc.Teslim_Durumu From Odunc Inner Join Kitap On Odunc.Kitap_Id = Kitap.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Uye On Odunc.Uye_Id = Uye.Id", con);
            DataTable dt = new DataTable();
            ShowinDgv.Fill(dt);
            GeriAl_dgv.DataSource = dt;

            MessageBox.Show("Kitap teslim alındı.");

            con.Close();
        }

        private void GeriAlFiltre_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void GeriAlFiltreBtn_Click(object sender, EventArgs e)
        {
           GeriAl_Btn.Text = "";
        }

        private void Name_Tb_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Odunc.Id, Odunc.Alis_Tarihi, Odunc.Son_Teslim_Tarihi, Odunc.Teslim_Ettigi_Tarih, Odunc.Uye_Id, Odunc.Kitap_Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Kitap.Durum_Id, Durum.D_Adi, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta, Odunc.Teslim_Durumu From Odunc Inner Join Kitap On Odunc.Kitap_Id = Kitap.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Uye On Odunc.Uye_Id = Uye.Id WHERE Adi like '%" + Name_Tb.Text + "%'  ", con);
                ara.Fill(tbl);
                con.Close();
                GeriAl_dgv.DataSource = tbl;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Odunc.Id, Odunc.Alis_Tarihi, Odunc.Son_Teslim_Tarihi, Odunc.Teslim_Ettigi_Tarih, Odunc.Uye_Id, Odunc.Kitap_Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Kitap.Durum_Id, Durum.D_Adi, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta, Odunc.Teslim_Durumu From Odunc Inner Join Kitap On Odunc.Kitap_Id = Kitap.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Uye On Odunc.Uye_Id = Uye.Id WHERE Ki_Adi like '%" + Name_Tb.Text + "%'  ", con);
                ara.Fill(tbl);
                con.Close();
                GeriAl_dgv.DataSource = tbl;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Odunc.Id, Odunc.Alis_Tarihi, Odunc.Son_Teslim_Tarihi, Odunc.Teslim_Ettigi_Tarih, Odunc.Uye_Id, Odunc.Kitap_Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Kitap.Durum_Id, Durum.D_Adi, Uye.Adi, Uye.Soyadi, Uye.Uye_Numarasi, Uye.Telefon_No, Uye.E_Posta, Odunc.Teslim_Durumu From Odunc Inner Join Kitap On Odunc.Kitap_Id = Kitap.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Uye On Odunc.Uye_Id = Uye.Id WHERE Demirbas_No like '%" + Name_Tb.Text + "%'  ", con);
                ara.Fill(tbl);
                con.Close();
                GeriAl_dgv.DataSource = tbl;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name_Tb.Text = "";
        }
    }
}
