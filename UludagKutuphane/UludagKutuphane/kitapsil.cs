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

        public int VarMi(string sorgu)
        {
            int sonuc;
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd = new MySqlCommand(sorgu, con);
            sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return sonuc;
        }

        private void KitapSil_Load(object sender, EventArgs e)
        {
            con.Open();
            string Komut = "Select Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi, Cevirmen.C_Adi, Cevirmen.C_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi, Kategori.K_Adi, Kitaplik.Kitaplik_Adi, Raf.Raf_No From Kitap Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KitapSil_dgv.DataSource = dt;
            con.Close();
        }

        private void KitapSil_btn_Click(object sender, EventArgs e)
        {
            int SecilenId = Convert.ToInt32(KitapSil_dgv.CurrentRow.Cells[0].Value);

            if (VarMi("Select COUNT('') from Kitap WHERE Id = '" + SecilenId + "'") == 0)
            {
                DialogResult dr = System.Windows.Forms.MessageBox.Show("Silmek istediğinize emin misiniz?", "Confirmation", (MessageBoxButtons)MessageBoxButton.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new MySqlCommand("DELETE FROM Kitap WHERE Id = '" + SecilenId + "'", con);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Kitap emanette olduğundan dolayı silinemez.");
            }

            string Komut = "Select Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi, Cevirmen.C_Adi, Cevirmen.C_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi, Kategori.K_Adi, Kitaplik.Kitaplik_Adi, Raf.Raf_No From Kitap Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id";
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

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi, Cevirmen.C_Adi, Cevirmen.C_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi, Kategori.K_Adi, Kitaplik.Kitaplik_Adi, Raf.Raf_No From Kitap Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id where Ki_Adi like '%" + textBox1.Text + "%' ", con);
                ara.Fill(tbl);
                con.Close();
                KitapSil_dgv.DataSource = tbl;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi, Cevirmen.C_Adi, Cevirmen.C_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi, Kategori.K_Adi, Kitaplik.Kitaplik_Adi, Raf.Raf_No From Kitap Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id where Y_Adi like '%" + textBox1.Text + "%' ", con);
                ara.Fill(tbl);
                con.Close();
                KitapSil_dgv.DataSource = tbl;

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi, Cevirmen.C_Adi, Cevirmen.C_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi, Kategori.K_Adi, Kitaplik.Kitaplik_Adi, Raf.Raf_No From Kitap Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id where Demirbas_No like '%" + textBox1.Text + "%' ", con);
                ara.Fill(tbl);
                con.Close();
                KitapSil_dgv.DataSource = tbl;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi, Cevirmen.C_Adi, Cevirmen.C_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi, Kategori.K_Adi, Kitaplik.Kitaplik_Adi, Raf.Raf_No From Kitap Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id where C_Adi like '%" + textBox1.Text + "%' ", con);
                ara.Fill(tbl);
                con.Close();
                KitapSil_dgv.DataSource = tbl;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                con.Open();
                DataTable tbl = new DataTable();

                MySqlDataAdapter ara = new MySqlDataAdapter("Select Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi, Cevirmen.C_Adi, Cevirmen.C_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi, Kategori.K_Adi, Kitaplik.Kitaplik_Adi, Raf.Raf_No From Kitap Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id where Yayin_Adi like '%" + textBox1.Text + "%' ", con);
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

