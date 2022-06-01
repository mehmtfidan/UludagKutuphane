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
        MySqlCommand cmd1;
        int YazarId;
        int YayineviId;
        int CevirmenId;

        public kitapekle()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id=132030020; pwd=Ogrenci9512357.; database=132030020");
        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            con.Open();
            string Komut = "Select Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi, Cevirmen.C_Adi, Cevirmen.C_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi, Kategori.K_Adi, Kitaplik.Kitaplik_Adi, Raf.Raf_No From Kitap Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KitapEkle_dgv.DataSource = dt;
            con.Close();

            con.Open();
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM Kategori", con);
            MySqlDataReader dr;
            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                Kategori_cmb.Items.Add(dr["K_Adi"]);
            }
            con.Close();


        }

        public int VarMi(string sorgu)
        {
            int sonuc;
            con.Open();
            cmd = new MySqlCommand(sorgu, con);           
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
            
            if (VarMi("SELECT COUNT(*) From Cevirmen WHERE C_Adi='" + Cevirmen_Adi + "'") == 0 && VarMi("Select COUNT(*) from Cevirmen WHERE C_Soyadi='" + Cevirmen_Soyadi + "'") == 0)
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO Cevirmen (C_Adi, C_Soyadi) VALUES ('" + Cevirmen_Adi + "', '" + Cevirmen_Soyadi + "')", con);
                cmd.ExecuteNonQuery();
                cmd1 = new MySqlCommand("Select LAST_INSERT_ID()",con);
                CevirmenId = Convert.ToInt32(cmd1.ExecuteScalar());
                con.Close();
            }
            else
            {
                con.Open();
                cmd = new MySqlCommand("Select Id from Cevirmen where C_Adi like '%"+ Cevirmen_Adi +"%' AND C_Soyadi like '%"+ Cevirmen_Soyadi +"%'", con);
                CevirmenId = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }                       
            
            if (VarMi("Select COUNT('') from Yayinevi WHERE Yayin_Adi='" + Yayinevi + "'") == 0)
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO Yayinevi (Yayin_Adi) VALUES ('" + Yayinevi + "')", con);
                cmd.ExecuteNonQuery();
                cmd1 = new MySqlCommand("Select LAST_INSERT_ID()", con);
                YayineviId = Convert.ToInt32(cmd1.ExecuteScalar());
                con.Close();
            }
            else 
            {
                con.Open();
                cmd = new MySqlCommand("Select Id from Yayinevi WHERE Yayin_Adi like '%" + Yayinevi + "%'", con);
                YayineviId = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }           

            if (VarMi("Select COUNT('') from Yazar WHERE Y_Adi='" + YazarAdi + "'") == 0 || VarMi("Select COUNT('') from Yazar WHERE Y_Soyadi='" + YazarSoyadi + "'") == 0)
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO Yazar (Y_Adi, Y_Soyadi) VALUES ('" + YazarAdi + "', '"+ YazarSoyadi +"')", con);
                cmd.ExecuteNonQuery();
                cmd1 = new MySqlCommand("Select LAST_INSERT_ID()" ,con);
                YazarId = Convert.ToInt32(cmd1.ExecuteScalar());
                con.Close();
            }
            else
            {
                con.Open();
                cmd = new MySqlCommand("Select Id from Yazar where Y_Adi like '%" + YazarAdi + "%' AND Y_Soyadi like '%" + YazarSoyadi + "%'", con);
                YazarId = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }

            con.Open();
            cmd = new MySqlCommand("INSERT INTO Baski (Baski_Sayisi, Yayinevi_Id, Cevirmen_Id) VALUES ('" + Baski + "', '" + YayineviId + "', '" + CevirmenId + "')", con);
            cmd.ExecuteNonQuery();
            cmd1 = new MySqlCommand("SELECT LAST_INSERT_ID()", con);
            int BaskiId = Convert.ToInt32(cmd1.ExecuteScalar());

            MySqlCommand Komut = new MySqlCommand("INSERT INTO Kitap (Ki_Adi, Demirbas_No, Yazar_Id, Baski_Id, ISBN, Yayim_Yili, Kategori_Id, Durum_Id, Kitaplik_Id, Raf_Id, Kayit_Tarihi) VALUES ('" + KitapAdi + "', '" + Demirbas + "', '" + YazarId + "', '" + BaskiId + "', '" + ISBN + "', '" + YayimYili + "', '" + Kategori + "', '" + Durum + "', '" + Kitaplik + "', '" + Raf + "', '" + Kayit_Tarihi + "')", con);
            Komut.ExecuteNonQuery();

            MessageBox.Show("Kitap kayıt edildi.");

            string Komut1 = "Select Kitap.Id, Kitap.Ki_Adi, Kitap.Demirbas_No, Yazar.Y_Adi, Yazar.Y_Soyadi, Baski.Baski_Sayisi, Yayinevi.Yayin_Adi, Cevirmen.C_Adi, Cevirmen.C_Soyadi, Kitap.ISBN, Kitap.Yayim_Yili, Durum.D_Adi, Kategori.K_Adi, Kitaplik.Kitaplik_Adi, Raf.Raf_No From Kitap Inner Join Durum On Kitap.Durum_Id = Durum.Id Inner Join Kategori On Kitap.Kategori_Id = Kategori.Id Inner Join Kitaplik On Kitap.Kitaplik_Id = Kitaplik.Id Inner Join Raf On Kitap.Raf_Id = Raf.Id Inner Join Yazar On Kitap.Yazar_Id = Yazar.Id Inner Join Baski On Kitap.Baski_Id = Baski.Id Inner Join Cevirmen On Baski.Cevirmen_Id = Cevirmen.Id Inner Join Yayinevi On Baski.Yayinevi_Id = Yayinevi.Id";
            MySqlDataAdapter adp = new MySqlDataAdapter(Komut1, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            KitapEkle_dgv.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand insert = new MySqlCommand("INSERT INTO Kategori (K_Adi) VALUES ('" + textBox1.Text + "')", con);
            insert.ExecuteNonQuery();
            con.Close();

            Kategori_cmb.Items.Add(textBox1.Text);
            MessageBox.Show("Kategori Eklendi");
            textBox1.Clear();
        }
    }
}
