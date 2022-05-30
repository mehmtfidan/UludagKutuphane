using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UludagKutuphane
{
    public partial class kitapsil : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;

        public kitapsil()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id=132030020; pwd=Ogrenci9512357.; database=132030020");
        }

        private void KitapSil_Load(object sender, EventArgs e)
        {
            con.Open();
            string Komut = "Select Kitap.Id, Kitap.Ki_Adi AS Kitap_Adi, Kitap.Demirbas_No, Yazar.Y_Adi AS Yazar_Adi, Yazar.Y_Soyadi AS Yazar_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi AS Yayinevi, Cevirmen.C_Adi AS Cevirmen_Adi, Cevirmen.C_Soyadi AS Cevirmen_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi AS Durumu, Kategori.K_Adi AS kategori_Adi, Kitap.Kitaplik_No, Kitap.Raf_No, Kitap.Kayit_Tarihi From Kitap Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KitapSil_dgv.DataSource = dt;
            con.Close();
        }

        private void KitapSil_btn_Click(object sender, EventArgs e)
        {
            int SecilenId = Convert.ToInt32(KitapSil_dgv.CurrentRow.Cells[0].Value);

            DialogResult dr = System.Windows.Forms.MessageBox.Show("Silmek istediğinize emin misiniz?", "Confirmation", (MessageBoxButtons)MessageBoxButton.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                con.Open();
                cmd = new MySqlCommand("DELETE FROM Kitap WHERE Id = '" + SecilenId + "'", con);
                cmd.ExecuteNonQuery();
            }

            string Komut = "Select Kitap.Id, Kitap.Ki_Adi AS Kitap_Adi, Kitap.Demirbas_No, Yazar.Y_Adi AS Yazar_Adi, Yazar.Y_Soyadi AS Yazar_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi AS Yayinevi, Cevirmen.C_Adi AS Cevirmen_Adi, Cevirmen.C_Soyadi AS Cevirmen_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi AS Durumu, Kategori.K_Adi AS kategori_Adi, Kitap.Kitaplik_No, Kitap.Raf_No, Kitap.Kayit_Tarihi From Kitap Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KitapSil_dgv.DataSource = dt;
            con.Close();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Id, Kitap.Ki_Adi AS Kitap_Adi, Kitap.Demirbas_No, Yazar.Y_Adi AS Yazar_Adi, Yazar.Y_Soyadi AS Yazar_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi AS Yayinevi, Cevirmen.C_Adi AS Cevirmen_Adi, Cevirmen.C_Soyadi AS Cevirmen_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi AS Durumu, Kategori.K_Adi AS kategori_Adi, Kitap.Kitaplik_No, Kitap.Raf_No, Kitap.Kayit_Tarihi From Kitap Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id where Ki_Adi like '%" + textBox1.Text + "%' ", con);
                ara.Fill(tbl);
                con.Close();
                KitapSil_dgv.DataSource = tbl;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Id, Kitap.Ki_Adi AS Kitap_Adi, Kitap.Demirbas_No, Yazar.Y_Adi AS Yazar_Adi, Yazar.Y_Soyadi AS Yazar_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi AS Yayinevi, Cevirmen.C_Adi AS Cevirmen_Adi, Cevirmen.C_Soyadi AS Cevirmen_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi AS Durumu, Kategori.K_Adi AS kategori_Adi, Kitap.Kitaplik_No, Kitap.Raf_No, Kitap.Kayit_Tarihi From Kitap Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id where Y_Adi like '%" + textBox1.Text + "%' ", con);
                ara.Fill(tbl);
                con.Close();
                KitapSil_dgv.DataSource = tbl;

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Id, Kitap.Ki_Adi AS Kitap_Adi, Kitap.Demirbas_No, Yazar.Y_Adi AS Yazar_Adi, Yazar.Y_Soyadi AS Yazar_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi AS Yayinevi, Cevirmen.C_Adi AS Cevirmen_Adi, Cevirmen.C_Soyadi AS Cevirmen_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi AS Durumu, Kategori.K_Adi AS kategori_Adi, Kitap.Kitaplik_No, Kitap.Raf_No, Kitap.Kayit_Tarihi From Kitap Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id where Demirbas_No like '%" + textBox1.Text + "%' ", con);
                ara.Fill(tbl);
                con.Close();
                KitapSil_dgv.DataSource = tbl;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Ki_Adi AS Kitap_Adi, Kitap.Demirbas_No, Yazar.Y_Adi AS Yazar_Adi, Yazar.Y_Soyadi AS Yazar_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi AS Yayinevi, Cevirmen.C_Adi AS Cevirmen_Adi, Cevirmen.C_Soyadi AS Cevirmen_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi AS Durumu, Kategori.K_Adi AS kategori_Adi, Kitap.Kitaplik_No, Kitap.Raf_No, Kitap.Kayit_Tarihi From Kitap Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id where C_Adi like '%" + textBox1.Text + "%' ", con);
                ara.Fill(tbl);
                con.Close();
                KitapSil_dgv.DataSource = tbl;
            }
        }

        private void KitapFiltre_Btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}

