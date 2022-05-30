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
    public partial class kitapekle : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;

        public kitapekle()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id=132030020; pwd=Ogrenci9512357.; database=132030020");
        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            con.Open();
            string Komut = "Select Kitap.Ki_Adi AS Kitap_Adi, Kitap.Demirbas_No, Yazar.Y_Adi AS Yazar_Adi, Yazar.Y_Soyadi AS Yazar_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi AS Yayinevi, Cevirmen.C_Adi AS Cevirmen_Adi, Cevirmen.C_Soyadi AS Cevirmen_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi AS Durumu, Kategori.K_Adi AS kategori_Adi, Kitap.Kitaplik_No, Kitap.Raf_No, Kitap.Kayit_Tarihi From Kitap Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KitapEkle_dgv.DataSource = dt;
            con.Close();
        }

        public int VarMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select COUNT(tc) from ogrenci WHERE tc='" + aranan + "'";
            cmd = new MySqlCommand(sorgu, con);
            con.Open();
            sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return sonuc;
        }

        private void KitapEkle_Btn_Click(object sender, EventArgs e)
        {
            string KitapAdi = KitapAdi_txt.Text;
            string YazarAdi = YazarAdi_txt.Text;
            string YazarSoyadi = YazarSoyadi_txt.Text;
            string Cevirmen_Adi = CevirmenAdi_txt.Text;
            string Cevirmen_Soyadi = CevirmenSoyadi_txt.Text;
            string Yayinevi = Yayinevi_txt.Text;
            string Kayit_Tarihi = KayitTarihi_dtp.Text;
            string Baski = BaskiNo_txt.Text;
            string YayimYili = YayimYili_txt.Text;
            string Demirbas = DemirbasNo_txt.Text;
            string ISBN = ISBN_txt.Text;
            int Kategori = Kategori_cmb.SelectedIndex;
            int Durum = Durum_cmb.SelectedIndex;
            int Kitaplik = Kitaaplik_cmb.SelectedIndex;
            int Raf = Raf_cmb.SelectedIndex;

            if (KitapAdi_txt.Text == "" || YazarAdi_txt.Text == "" || DemirbasNo_txt.Text == "" || Kitaaplik_cmb.SelectedIndex == 0 || Raf_cmb.SelectedIndex == 0 || Kategori_cmb.SelectedIndex == 0 || Durum_cmb.SelectedIndex == 0 || KayitTarihi_dtp.Text == "" || BaskiNo_txt.Text == "")
            {
                MessageBox.Show("Kitap bilgilerini eksiksiz giriniz!!");
            }
            
            if (VarMi(Cevirmen_Adi) == 0 && VarMi(Cevirmen_Soyadi) == 0)
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO Cevirmen (C_Adi, C_Soyadi) VALUES ('" + Cevirmen_Adi + "', '" + Cevirmen_Soyadi + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Uye başarıyla kayıt edildi.");
            }
            
            if (VarMi(Yayinevi) == 0)
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO Yayinevi (Yayin_Adi) VALUES ('" + Yayinevi + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            if (VarMi(YazarAdi) == 0 && VarMi(YazarSoyadi) == 0)
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO Yazar (Y_Adi, Y_Soyadi) VALUES ('" + YazarAdi + "', '"+ YazarSoyadi +"')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }



            string Komut = "Select Kitap.Ki_Adi AS Kitap_Adi, Kitap.Demirbas_No, Yazar.Y_Adi AS Yazar_Adi, Yazar.Y_Soyadi AS Yazar_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi AS Yayinevi, Cevirmen.C_Adi AS Cevirmen_Adi, Cevirmen.C_Soyadi AS Cevirmen_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi AS Durumu, Kategori.K_Adi AS kategori_Adi, Kitap.Kitaplik_No, Kitap.Raf_No, Kitap.Kayit_Tarihi From Kitap Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Durum On Kitap.Durum_Id = Durum.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KitapEkle_dgv.DataSource = dt;
            con.Close();
        }

    }
}
